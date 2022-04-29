namespace MultiFaceRec
{
    partial class FrmMainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnstartcam = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbModule = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.save_Frame_With_Face_Recognized = new System.Windows.Forms.SaveFileDialog();
            this.save_Frame_Without_Face_Recognized = new System.Windows.Forms.SaveFileDialog();
            this.btnSubmitAttendance = new System.Windows.Forms.Button();
            this.btnStopCamera = new System.Windows.Forms.Button();
            this.Imbox = new Emgu.CV.UI.ImageBox();
            this.btnTrainFaces = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Imbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(129, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(21, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "No faces detected: ";
            // 
            // btnstartcam
            // 
            this.btnstartcam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnstartcam.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstartcam.Location = new System.Drawing.Point(23, 293);
            this.btnstartcam.Name = "btnstartcam";
            this.btnstartcam.Size = new System.Drawing.Size(114, 25);
            this.btnstartcam.TabIndex = 2;
            this.btnstartcam.Text = "Start Camera";
            this.btnstartcam.UseVisualStyleBackColor = true;
            this.btnstartcam.Click += new System.EventHandler(this.btnstartcam_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(379, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Name(s):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(386, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "Module:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label9.Location = new System.Drawing.Point(386, 221);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 14);
            this.label9.TabIndex = 13;
            this.label9.Text = "Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label10.Location = new System.Drawing.Point(386, 263);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 14);
            this.label10.TabIndex = 14;
            this.label10.Text = "Time:";
            // 
            // lbldate
            // 
            this.lbldate.BackColor = System.Drawing.Color.White;
            this.lbldate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(451, 213);
            this.lbldate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(166, 22);
            this.lbldate.TabIndex = 18;
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbltime
            // 
            this.lbltime.BackColor = System.Drawing.Color.White;
            this.lbltime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(451, 256);
            this.lbltime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(166, 21);
            this.lbltime.TabIndex = 19;
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbModule
            // 
            this.cmbModule.BackColor = System.Drawing.Color.White;
            this.cmbModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModule.FormattingEnabled = true;
            this.cmbModule.Items.AddRange(new object[] {
            "CZ1005",
            "CZ1006",
            "CZ1007",
            "CZ1011",
            "CZ1012",
            "CZ2001",
            "CZ2002",
            "CZ2003",
            "CZ2004",
            "CZ2005",
            "CZ2006",
            "CZ2007",
            "CZ3001",
            "CZ3002",
            "CZ3003",
            "CZ3004",
            "CZ3005",
            "CZ3006",
            "CZ3007",
            "CZ4062",
            "CZ4064",
            "CZ4046",
            "CZ4065",
            "CZ0001"});
            this.cmbModule.Location = new System.Drawing.Point(451, 91);
            this.cmbModule.Margin = new System.Windows.Forms.Padding(2);
            this.cmbModule.Name = "cmbModule";
            this.cmbModule.Size = new System.Drawing.Size(166, 32);
            this.cmbModule.TabIndex = 23;
            // 
            // cmbClass
            // 
            this.cmbClass.BackColor = System.Drawing.Color.White;
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "FSP1",
            "FSP2",
            "FSP3",
            "FSP4",
            "FSP5",
            "FSP6",
            "FSP7",
            "BCG1",
            "BCG2",
            "BCG3"});
            this.cmbClass.Location = new System.Drawing.Point(451, 148);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(166, 32);
            this.cmbClass.TabIndex = 24;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(451, 40);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(166, 21);
            this.lblName.TabIndex = 27;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSubmitAttendance
            // 
            this.btnSubmitAttendance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAttendance.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitAttendance.Location = new System.Drawing.Point(203, 378);
            this.btnSubmitAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitAttendance.Name = "btnSubmitAttendance";
            this.btnSubmitAttendance.Size = new System.Drawing.Size(117, 30);
            this.btnSubmitAttendance.TabIndex = 38;
            this.btnSubmitAttendance.Text = "Submit Attendance";
            this.btnSubmitAttendance.UseVisualStyleBackColor = true;
            // 
            // btnStopCamera
            // 
            this.btnStopCamera.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopCamera.ForeColor = System.Drawing.Color.Black;
            this.btnStopCamera.Location = new System.Drawing.Point(22, 326);
            this.btnStopCamera.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopCamera.Name = "btnStopCamera";
            this.btnStopCamera.Size = new System.Drawing.Size(115, 25);
            this.btnStopCamera.TabIndex = 41;
            this.btnStopCamera.Text = "Turn Off Camera";
            this.btnStopCamera.UseVisualStyleBackColor = true;
            this.btnStopCamera.Click += new System.EventHandler(this.btnStopCamera_Click);
            // 
            // Imbox
            // 
            this.Imbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Imbox.Location = new System.Drawing.Point(23, 30);
            this.Imbox.Name = "Imbox";
            this.Imbox.Size = new System.Drawing.Size(331, 229);
            this.Imbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imbox.TabIndex = 4;
            this.Imbox.TabStop = false;
            // 
            // btnTrainFaces
            // 
            this.btnTrainFaces.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainFaces.ForeColor = System.Drawing.Color.Black;
            this.btnTrainFaces.Location = new System.Drawing.Point(237, 296);
            this.btnTrainFaces.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrainFaces.Name = "btnTrainFaces";
            this.btnTrainFaces.Size = new System.Drawing.Size(83, 55);
            this.btnTrainFaces.TabIndex = 45;
            this.btnTrainFaces.Text = "Train Faces";
            this.btnTrainFaces.UseVisualStyleBackColor = true;
            // 
            // FrmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 521);
            this.Controls.Add(this.btnTrainFaces);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStopCamera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmitAttendance);
            this.Controls.Add(this.btnstartcam);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.cmbModule);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Imbox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Emgu.CV.UI.ImageBox Imbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnstartcam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbModule;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog save_Frame_With_Face_Recognized;
        private System.Windows.Forms.SaveFileDialog save_Frame_Without_Face_Recognized;
        private System.Windows.Forms.Button btnSubmitAttendance;
        private System.Windows.Forms.Button btnStopCamera;
        private System.Windows.Forms.Button btnTrainFaces;
    }
}

