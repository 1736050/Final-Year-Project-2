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
using System.Media;
using System.Drawing.Drawing2D;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace MultiFaceRec
{
    public partial class FrmTrainFaces : Form
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

        int NoFDetected = 0;
        public FrmTrainFaces()
        {
            InitializeComponent();
            //Load HaarCascades for face detection
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
        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            Cameraoncheck = true;
       
            if(capture == null)
            {
                try
                {
                    capture = new Capture(0);
                }
                catch(NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            if(capture !=null)
            {
                if(captureInProgress)
                {
                    
                    btnStartCamera.Text = "Resume Camera";
                    Application.Idle -= FrameGrabber;
                }
                else
                {
                   
                    btnStartCamera.Text = "Pause Camera";
                    Application.Idle += FrameGrabber;
                }
                captureInProgress = !captureInProgress;
            }
        }

        

        private void btnTurnOffCamera_Click(object sender, EventArgs e)
        {
            Cameraoncheck = false;
            addnametxt.Clear();
            TNFD.Text = "";
            Exname.Text = "";
            Imbox2.Image = null;
            if (capture != null)
            {
                if (captureInProgress)
                {
                    
                    btnStartCamera.Text = "Start Camera";
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
            if (capture != null)
            {
                capture.Dispose();
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            if (Cameraoncheck == false)
            {
                
                OpenFileDialog the_open_file_dialog = new OpenFileDialog();
                the_open_file_dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png,*.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png;*.bmp";
                if (the_open_file_dialog.ShowDialog() == DialogResult.OK)
                {
                    
                    Image theInputImg = Image.FromFile(the_open_file_dialog.FileName);
                    try
                    {
                        if (theInputImg == null)
                        {
                            throw new Exception("Please select an image");
                        }
                        imageframe = new Image<Bgr, byte>(new Bitmap(theInputImg));
                        Imbox.Image = imageframe;
                        string fileName = Path.GetFileName(the_open_file_dialog.FileName);
                            int index = fileName.IndexOfAny("_0123456789.".ToCharArray());
                            string extTrainingLb = fileName.Substring(0, index);
                            if (index > 0)
                            {
                                addnametxt.Text = extTrainingLb;
                            }


                        DetectFaces();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("Turn off the camera first!");
            }
        }

        void FrameGrabber(object sender, EventArgs e)
        {
            try
            {
                TNFD.Text = "0";
                NoFDetected = 0;
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
                                TNFD.Text = facesDetected[0].Length.ToString();
                                Imbox2.Image = result;
                            }
                        }
                        else if(facesDetected[0].Length==0)
                        {
                            Imbox2.Image = null;
                        }
                        else
                        {
                        }
                        t = 0;
                        Imbox.Image = frame;
                        if (facesDetected[0].Length < 1)
                        {
                            Exname.Text = "";
                            names = "";
                            personsname.Clear();
                        }
                        else if (facesDetected[0].Length >= 1)
                        {
                            for (int namelabel = 0; namelabel < facesDetected[0].Length; namelabel++)
                            {
                                names = names + personsname[namelabel] + ",";
                            }                       
                            string names_without_comma_at_the_end = names.Remove(names.Length - 1);
                            Exname.Text = names_without_comma_at_the_end;
                            names = "";
                            personsname.Clear();
                        }
                    }
                    else if(enableFaceDetectioAndRecognition==false)
                    {
                        Imbox.Image = frame;
                    }
                    else
                    {
                    }
                }                
            }
            catch(Exception)
            {

            }
        }

        private void Clbtn_Click(object sender, EventArgs e)
        {
            ReleaseData();
        }

        private void FrmTrainFaces_Load(object sender, EventArgs e)
        {

        }

        private void ExtractedtrainedFaces()
        {
            if (Cameraoncheck == true)
            {

                gray = capture.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                faceDetect,
                1.1,
                3,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = frame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }
            }
            else
            {
            }
          
            TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
        }
        private void btnAddTrainingImage_Click(object sender, EventArgs e)
        {
            //Create the trained faces folder if there is no folder with that name
            string folder_name = Application.StartupPath + "/TrainedFaces/";
            if (!Directory.Exists(folder_name))
            {
                Directory.CreateDirectory(folder_name);
            }
            string file_name = "TrainedLabels.txt";
            string path_string = Path.Combine(folder_name, file_name);
            Console.WriteLine("Path to my file {0}\n", path_string);
            if (!File.Exists(path_string))
            {
                {
                    using (FileStream fs = File.Create(path_string))
                    {
                    }
                }
            }
             
            if (addnametxt.Text == "")
            {
                MessageBox.Show("Please enter the name of the person you are training the image for", "Training image Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                  
                    ContTrain = ContTrain + 1;
                    ExtractedtrainedFaces();
                    Imbox2.Image = TrainedFace;
                    TrainingImages.Add(TrainedFace);
                    labels.Add(addnametxt.Text);

                    
                    File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", TrainingImages.ToArray().Length.ToString() + "%");

                    
                    for (int i = 1; i < TrainingImages.ToArray().Length + 1; i++)
                    {
                        TrainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/Face" + i + ".bmp");
                        File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                    }

                    MessageBox.Show(addnametxt.Text + "face detected and added to the training set", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("A face needs to be detected first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

                private void btnStopVideo_Click(object sender, EventArgs e)
        {
            Cameraoncheck = false;
            addnametxt.Clear();
            TNFD.Text = "";
            Exname.Text = "";
            Imbox2.Image = null;
            if (capture != null)
            {
                if (captureInProgress)
                {                
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
            TNFD.Text = facesDetected[0].Length.ToString();
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
                TNFD.Text = facesDetected[0].Length.ToString();
            }
            t = 0;
            Imbox2.Image = result;
            for (int nameL1 = 0; nameL1 < facesDetected[0].Length; nameL1++)
            {
                names = names + personsname[nameL1] + ",";
            }
            string nameFormat = names.Remove(names.Length - 1);
            Exname.Text = nameFormat;
            names = "";
            personsname.Clear();
        }   
       
    }
}
