namespace MultiFaceRec
{
    partial class FrmTrainFaces
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Imbox = new Emgu.CV.UI.ImageBox();
            this.addnametxt = new System.Windows.Forms.TextBox();
            this.Imbox2 = new Emgu.CV.UI.ImageBox();
            this.btnAddTrainingImage = new System.Windows.Forms.Button();
            this.btnStartCamera = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Exname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TNFD = new System.Windows.Forms.Label();
            this.the_open_file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnTurnOffCamera = new System.Windows.Forms.Button();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tmrRunImagesInFolder = new System.Windows.Forms.Timer(this.components);
            this.Clbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Imbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imbox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Imbox
            // 
            this.Imbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Imbox.Location = new System.Drawing.Point(11, 11);
            this.Imbox.Margin = new System.Windows.Forms.Padding(2);
            this.Imbox.Name = "Imbox";
            this.Imbox.Size = new System.Drawing.Size(407, 282);
            this.Imbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imbox.TabIndex = 2;
            this.Imbox.TabStop = false;
            // 
            // addnametxt
            // 
            this.addnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnametxt.Location = new System.Drawing.Point(513, 259);
            this.addnametxt.Margin = new System.Windows.Forms.Padding(2);
            this.addnametxt.Name = "addnametxt";
            this.addnametxt.Size = new System.Drawing.Size(205, 29);
            this.addnametxt.TabIndex = 3;
            // 
            // Imbox2
            // 
            this.Imbox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Imbox2.Location = new System.Drawing.Point(542, 128);
            this.Imbox2.Margin = new System.Windows.Forms.Padding(2);
            this.Imbox2.Name = "Imbox2";
            this.Imbox2.Size = new System.Drawing.Size(136, 116);
            this.Imbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imbox2.TabIndex = 2;
            this.Imbox2.TabStop = false;
            // 
            // btnAddTrainingImage
            // 
            this.btnAddTrainingImage.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrainingImage.Location = new System.Drawing.Point(534, 292);
            this.btnAddTrainingImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTrainingImage.Name = "btnAddTrainingImage";
            this.btnAddTrainingImage.Size = new System.Drawing.Size(144, 40);
            this.btnAddTrainingImage.TabIndex = 6;
            this.btnAddTrainingImage.Text = "Add Trained Face";
            this.btnAddTrainingImage.UseVisualStyleBackColor = true;
            this.btnAddTrainingImage.Click += new System.EventHandler(this.btnAddTrainingImage_Click);
            // 
            // btnStartCamera
            // 
            this.btnStartCamera.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCamera.Location = new System.Drawing.Point(11, 315);
            this.btnStartCamera.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartCamera.Name = "btnStartCamera";
            this.btnStartCamera.Size = new System.Drawing.Size(159, 36);
            this.btnStartCamera.TabIndex = 7;
            this.btnStartCamera.Text = "Start Camera";
            this.btnStartCamera.UseVisualStyleBackColor = true;
            this.btnStartCamera.Click += new System.EventHandler(this.btnStartCamera_Click);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(422, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Names:";
            // 
            // Exname
            // 
            this.Exname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Exname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exname.Location = new System.Drawing.Point(488, 11);
            this.Exname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Exname.Name = "Exname";
            this.Exname.Size = new System.Drawing.Size(229, 50);
            this.Exname.TabIndex = 13;
            this.Exname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(422, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "No of Faces Detected:";
            // 
            // TNFD
            // 
            this.TNFD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TNFD.Location = new System.Drawing.Point(488, 75);
            this.TNFD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TNFD.Name = "TNFD";
            this.TNFD.Size = new System.Drawing.Size(43, 38);
            this.TNFD.TabIndex = 15;
            this.TNFD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // the_open_file_dialog
            // 
            this.the_open_file_dialog.FileName = "openFileDialog1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnTurnOffCamera
            // 
            this.btnTurnOffCamera.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnOffCamera.Location = new System.Drawing.Point(11, 359);
            this.btnTurnOffCamera.Margin = new System.Windows.Forms.Padding(2);
            this.btnTurnOffCamera.Name = "btnTurnOffCamera";
            this.btnTurnOffCamera.Size = new System.Drawing.Size(159, 38);
            this.btnTurnOffCamera.TabIndex = 17;
            this.btnTurnOffCamera.Text = "Turn Off Camera";
            this.btnTurnOffCamera.UseVisualStyleBackColor = true;
            this.btnTurnOffCamera.Click += new System.EventHandler(this.btnTurnOffCamera_Click);
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImage.Location = new System.Drawing.Point(194, 315);
            this.btnBrowseImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(163, 36);
            this.btnBrowseImage.TabIndex = 18;
            this.btnBrowseImage.Text = "Browse Image";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(19, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Train Faces From a Camera";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(191, 300);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Train Faces From an Image";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(422, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 26);
            this.label8.TabIndex = 31;
            this.label8.Text = "Image Name:";
            // 
            // Clbtn
            // 
            this.Clbtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clbtn.Location = new System.Drawing.Point(194, 355);
            this.Clbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Clbtn.Name = "Clbtn";
            this.Clbtn.Size = new System.Drawing.Size(163, 36);
            this.Clbtn.TabIndex = 32;
            this.Clbtn.Text = "Clear Image";
            this.Clbtn.UseVisualStyleBackColor = true;
            this.Clbtn.Click += new System.EventHandler(this.Clbtn_Click);
            // 
            // FrmTrainFaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 521);
            this.Controls.Add(this.Clbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTurnOffCamera);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnStartCamera);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.TNFD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Exname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddTrainingImage);
            this.Controls.Add(this.Imbox2);
            this.Controls.Add(this.addnametxt);
            this.Controls.Add(this.Imbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTrainFaces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainFaces";
            this.Load += new System.EventHandler(this.FrmTrainFaces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imbox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox Imbox;
        private System.Windows.Forms.TextBox addnametxt;
        private Emgu.CV.UI.ImageBox Imbox2;
        private System.Windows.Forms.Button btnAddTrainingImage;
        private System.Windows.Forms.Button btnStartCamera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Exname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TNFD;
        private System.Windows.Forms.OpenFileDialog the_open_file_dialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnTurnOffCamera;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer tmrRunImagesInFolder;
        private System.Windows.Forms.Button Clbtn;
    }
}