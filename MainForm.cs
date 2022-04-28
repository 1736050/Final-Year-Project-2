using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Threading;
using System.Data.OleDb;
using System.Drawing.Imaging;
using System.Speech;
using System.Speech.Synthesis;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing.Drawing2D;

namespace MultiFaceRec
{
    public partial class FrmMainForm : Form
    {
        Image<Bgr, byte> frame;
        Image<Bgr, byte> imageframe;
        Capture capture;
        HaarCascade faceDetect;
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> TrainingImages = new List<Image<Gray, byte>>();
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.5d, 0.5d);
        List<string> labels = new List<string>();
        List<string> personsname = new List<string>();
        int ContTrain, NLabels, t;
        private bool captureInProgress;
        string name, names = null;
        private bool Cameraoncheck = false;
        private bool saveToFileWithoutFaceRecognition = false;
        private bool enableFaceDetectioAndRecognition = true;
        private bool is_12HR_format;

        public FrmMainForm()
        {
            InitializeComponent();

            faceDetect = new HaarCascade("haarcascade_frontalface_default.xml");
            try
            {
                //Load of previusly trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NLabels;
                string LoadFaces;

                for (int tf = 1; tf < NLabels + 1; tf++)
                {
                    LoadFaces = "Face" + tf + ".bmp";
                    TrainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Training set is Empty. Please train a face.");
            }
        }
        
        private void btnstartcam_Click(object sender, EventArgs e)
        {

            Cameraoncheck = true;

            if (capture == null)
            {
                try
                {
                    capture = new Capture(0);
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            if (capture != null)
            {
                if (captureInProgress)
                {

                    btnstartcam.Text = "Resume Camera";
                    Application.Idle -= FrameGrabber;
                }
                else
                {

                    btnstartcam.Text = "Pause Camera";
                    Application.Idle += FrameGrabber;
                }
                captureInProgress = !captureInProgress;
            }
        }

        private void FrmMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStopCamera_Click(object sender, EventArgs e)
        {
            Cameraoncheck = false;
            if (capture != null)
            {
                if (captureInProgress)
                {

                    btnstartcam.Text = "Start Camera";
                    Application.Idle -= FrameGrabber;
                    ReleaseData();
                    capture = null;
                    Imbox.Image = null;
                }
                else
                {
                    ReleaseData();
                    capture = null;
                    Imbox.Image = null;
                }
                captureInProgress = !captureInProgress;
            }
        }
        private void ReleaseData()
        {
            if(capture!=null)
            {
                capture.Dispose();
            }
        }
        void FrameGrabber(object sender, EventArgs e)
        {
            try
            {
               
                personsname.Add("");

                frame = capture.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                if (frame != null)
                {

                    Bitmap ConvertedTobitmap = new Bitmap(capture.QueryFrame().Bitmap);

                    if (saveToFileWithoutFaceRecognition)
                    {

                        SaveFileDialog SFWFRecognition = new SaveFileDialog();
                        SFWFRecognition.Filter = "Images|*.png;*.bmp;*.jpg";
                        ImageFormat format = ImageFormat.Png;
                        if (SFWFRecognition.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            string ext = System.IO.Path.GetExtension(SFWFRecognition.FileName);
                            switch (ext)
                            {
                                case ".jpg":
                                    format = ImageFormat.Jpeg;
                                    break;
                                case ".bmp":
                                    format = ImageFormat.Bmp;
                                    break;
                            }
                            ConvertedTobitmap.Save(SFWFRecognition.FileName, format);
                        }
                        saveToFileWithoutFaceRecognition = !saveToFileWithoutFaceRecognition;
                    }
                    else
                    {

                    }
                    if (enableFaceDetectioAndRecognition == true)
                    {
                        gray = frame.Convert<Gray, byte>();
                        MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                        faceDetect,
                        1.2,
                        8,
                        Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                        new Size(20, 20));
                        if (facesDetected[0].Length > 0)
                        {
                            foreach (MCvAvgComp f in facesDetected[0])
                            {

                                t = t + 1;
                                frame.Draw(f.rect, new Bgr(Color.Red), 2);

                                result = frame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                                if (TrainingImages.ToArray().Length != 0)
                                {


                                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);
                                    EigenFaceRecognizer recognizer = new EigenFaceRecognizer(
                                        TrainingImages.ToArray(),
                                        labels.ToArray(),
                                        5000,
                                        ref termCrit
                                        );
                                    name = recognizer.Recognize(result);
                                    if (string.IsNullOrEmpty(name) == true)
                                    {
                                        name = "UNKNOWN";
                                    }
                                    frame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));
                                }
                                //Now draw the rectangle on the detected image
                                personsname[t - 1] = name;
                                personsname.Add("");
                                
                            }
                        }
                        
                    }
                    else if (enableFaceDetectioAndRecognition == false)
                    {
                        Imbox.Image = frame;
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        private void DetectFaces()
        {
            personsname.Add("");
            Image<Gray, byte> grayframe = imageframe.Convert<Gray, byte>();
            Imbox.Image = imageframe;
            MCvAvgComp[][] facesDetected = grayframe.DetectHaarCascade(
            faceDetect,
            1.1,
            2,
            Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
            new Size(20, 20));
            if (facesDetected[0].Length > 0)
            {
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    t = t + 1;
                    result = imageframe.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    imageframe.Draw(f.rect, new Bgr(Color.Green), 3);
                    if (TrainingImages.ToArray().Length != 0)
                    {
                        MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.01);
                        EigenFaceRecognizer recognizer = new EigenFaceRecognizer(
                             TrainingImages.ToArray(),
                             labels.ToArray(),
                             5000,
                             ref termCrit
                             );
                        name = recognizer.Recognize(result);
                        if (string.IsNullOrEmpty(name) == true)
                        {
                            name = "UNKNOWN";
                        }
                        imageframe.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Red));
                    }
                    //Now draw the rectangle on the detected image
                    personsname[t - 1] = name;
                    personsname.Add("");
                }

            }




        }




    }
}