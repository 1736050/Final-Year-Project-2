namespace MultiFaceRec
{
    partial class StudentRegistrationForm
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
            this.Cotxt = new System.Windows.Forms.TextBox();
            this.Coitxt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lobnt = new System.Windows.Forms.Button();
            this.Cbtn = new System.Windows.Forms.Button();
            this.Sitxt = new System.Windows.Forms.TextBox();
            this.Silb = new System.Windows.Forms.Label();
            this.Stsearchbtn = new System.Windows.Forms.Button();
            this.Stremovebtn = new System.Windows.Forms.Button();
            this.StAddbtn = new System.Windows.Forms.Button();
            this.Stupdatebtn = new System.Windows.Forms.Button();
            this.StDGV = new System.Windows.Forms.DataGridView();
            this.Dbtxt = new System.Windows.Forms.DateTimePicker();
            this.Gntxt = new System.Windows.Forms.ComboBox();
            this.stimlb = new System.Windows.Forms.Label();
            this.Adtxt = new System.Windows.Forms.TextBox();
            this.stadlb = new System.Windows.Forms.Label();
            this.Pntxt = new System.Windows.Forms.TextBox();
            this.stpnlb = new System.Windows.Forms.Label();
            this.Stclb = new System.Windows.Forms.Label();
            this.Stglb = new System.Windows.Forms.Label();
            this.Stdblb = new System.Windows.Forms.Label();
            this.Sntxt = new System.Windows.Forms.TextBox();
            this.Stsnlb = new System.Windows.Forms.Label();
            this.Fntxt = new System.Windows.Forms.TextBox();
            this.Stfnlb = new System.Windows.Forms.Label();
            this.Imbox = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Cotxt
            // 
            this.Cotxt.Enabled = false;
            this.Cotxt.Location = new System.Drawing.Point(100, 239);
            this.Cotxt.Name = "Cotxt";
            this.Cotxt.Size = new System.Drawing.Size(120, 20);
            this.Cotxt.TabIndex = 63;
            // 
            // Coitxt
            // 
            this.Coitxt.FormattingEnabled = true;
            this.Coitxt.Location = new System.Drawing.Point(100, 204);
            this.Coitxt.Name = "Coitxt";
            this.Coitxt.Size = new System.Drawing.Size(121, 21);
            this.Coitxt.TabIndex = 62;
            this.Coitxt.SelectionChangeCommitted += new System.EventHandler(this.Coitxt_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(15, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Course ID:";
            // 
            // lobnt
            // 
            this.lobnt.Location = new System.Drawing.Point(146, 471);
            this.lobnt.Name = "lobnt";
            this.lobnt.Size = new System.Drawing.Size(75, 23);
            this.lobnt.TabIndex = 60;
            this.lobnt.Text = "Load";
            this.lobnt.UseVisualStyleBackColor = true;
            this.lobnt.Click += new System.EventHandler(this.lobnt_Click);
            // 
            // Cbtn
            // 
            this.Cbtn.Location = new System.Drawing.Point(146, 431);
            this.Cbtn.Name = "Cbtn";
            this.Cbtn.Size = new System.Drawing.Size(75, 23);
            this.Cbtn.TabIndex = 59;
            this.Cbtn.Text = "Clear";
            this.Cbtn.UseVisualStyleBackColor = true;
            this.Cbtn.Click += new System.EventHandler(this.Cbtn_Click);
            // 
            // Sitxt
            // 
            this.Sitxt.Enabled = false;
            this.Sitxt.Location = new System.Drawing.Point(102, 14);
            this.Sitxt.Name = "Sitxt";
            this.Sitxt.Size = new System.Drawing.Size(120, 20);
            this.Sitxt.TabIndex = 58;
            // 
            // Silb
            // 
            this.Silb.AutoSize = true;
            this.Silb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Silb.Location = new System.Drawing.Point(17, 17);
            this.Silb.Name = "Silb";
            this.Silb.Size = new System.Drawing.Size(61, 13);
            this.Silb.TabIndex = 57;
            this.Silb.Text = "Student ID:";
            // 
            // Stsearchbtn
            // 
            this.Stsearchbtn.Location = new System.Drawing.Point(49, 393);
            this.Stsearchbtn.Name = "Stsearchbtn";
            this.Stsearchbtn.Size = new System.Drawing.Size(75, 23);
            this.Stsearchbtn.TabIndex = 56;
            this.Stsearchbtn.Text = "Search";
            this.Stsearchbtn.UseVisualStyleBackColor = true;
            this.Stsearchbtn.Click += new System.EventHandler(this.Stsearchbtn_Click);
            // 
            // Stremovebtn
            // 
            this.Stremovebtn.Location = new System.Drawing.Point(49, 471);
            this.Stremovebtn.Name = "Stremovebtn";
            this.Stremovebtn.Size = new System.Drawing.Size(75, 23);
            this.Stremovebtn.TabIndex = 55;
            this.Stremovebtn.Text = "Remove";
            this.Stremovebtn.UseVisualStyleBackColor = true;
            this.Stremovebtn.Click += new System.EventHandler(this.Stremovebtn_Click);
            // 
            // StAddbtn
            // 
            this.StAddbtn.Location = new System.Drawing.Point(146, 393);
            this.StAddbtn.Name = "StAddbtn";
            this.StAddbtn.Size = new System.Drawing.Size(75, 23);
            this.StAddbtn.TabIndex = 54;
            this.StAddbtn.Text = "Add";
            this.StAddbtn.UseVisualStyleBackColor = true;
            this.StAddbtn.Click += new System.EventHandler(this.StAddbtn_Click);
            // 
            // Stupdatebtn
            // 
            this.Stupdatebtn.Location = new System.Drawing.Point(49, 431);
            this.Stupdatebtn.Name = "Stupdatebtn";
            this.Stupdatebtn.Size = new System.Drawing.Size(75, 23);
            this.Stupdatebtn.TabIndex = 53;
            this.Stupdatebtn.Text = "Update";
            this.Stupdatebtn.UseVisualStyleBackColor = true;
            this.Stupdatebtn.Click += new System.EventHandler(this.Stupdatebtn_Click);
            // 
            // StDGV
            // 
            this.StDGV.AllowUserToAddRows = false;
            this.StDGV.AllowUserToDeleteRows = false;
            this.StDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StDGV.GridColor = System.Drawing.SystemColors.Control;
            this.StDGV.Location = new System.Drawing.Point(275, 204);
            this.StDGV.Name = "StDGV";
            this.StDGV.ReadOnly = true;
            this.StDGV.RowHeadersWidth = 20;
            this.StDGV.Size = new System.Drawing.Size(459, 250);
            this.StDGV.TabIndex = 48;
            this.StDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StDGV_CellClick);
            // 
            // Dbtxt
            // 
            this.Dbtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dbtxt.Location = new System.Drawing.Point(101, 131);
            this.Dbtxt.Name = "Dbtxt";
            this.Dbtxt.Size = new System.Drawing.Size(121, 18);
            this.Dbtxt.TabIndex = 51;
            // 
            // Gntxt
            // 
            this.Gntxt.FormattingEnabled = true;
            this.Gntxt.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Nobinary",
            "Others"});
            this.Gntxt.Location = new System.Drawing.Point(101, 170);
            this.Gntxt.Name = "Gntxt";
            this.Gntxt.Size = new System.Drawing.Size(121, 21);
            this.Gntxt.TabIndex = 50;
            // 
            // stimlb
            // 
            this.stimlb.AutoSize = true;
            this.stimlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.stimlb.Location = new System.Drawing.Point(272, 39);
            this.stimlb.Name = "stimlb";
            this.stimlb.Size = new System.Drawing.Size(39, 13);
            this.stimlb.TabIndex = 49;
            this.stimlb.Text = "Image:";
            // 
            // Adtxt
            // 
            this.Adtxt.Location = new System.Drawing.Point(101, 316);
            this.Adtxt.Multiline = true;
            this.Adtxt.Name = "Adtxt";
            this.Adtxt.Size = new System.Drawing.Size(120, 71);
            this.Adtxt.TabIndex = 47;
            // 
            // stadlb
            // 
            this.stadlb.AutoSize = true;
            this.stadlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.stadlb.Location = new System.Drawing.Point(16, 319);
            this.stadlb.Name = "stadlb";
            this.stadlb.Size = new System.Drawing.Size(48, 13);
            this.stadlb.TabIndex = 46;
            this.stadlb.Text = "Address:";
            // 
            // Pntxt
            // 
            this.Pntxt.Location = new System.Drawing.Point(101, 277);
            this.Pntxt.Name = "Pntxt";
            this.Pntxt.Size = new System.Drawing.Size(120, 20);
            this.Pntxt.TabIndex = 45;
            // 
            // stpnlb
            // 
            this.stpnlb.AutoSize = true;
            this.stpnlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.stpnlb.Location = new System.Drawing.Point(16, 280);
            this.stpnlb.Name = "stpnlb";
            this.stpnlb.Size = new System.Drawing.Size(81, 13);
            this.stpnlb.TabIndex = 44;
            this.stpnlb.Text = "Phone Number:";
            // 
            // Stclb
            // 
            this.Stclb.AutoSize = true;
            this.Stclb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Stclb.Location = new System.Drawing.Point(15, 242);
            this.Stclb.Name = "Stclb";
            this.Stclb.Size = new System.Drawing.Size(43, 13);
            this.Stclb.TabIndex = 43;
            this.Stclb.Text = "Course:";
            // 
            // Stglb
            // 
            this.Stglb.AutoSize = true;
            this.Stglb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Stglb.Location = new System.Drawing.Point(16, 170);
            this.Stglb.Name = "Stglb";
            this.Stglb.Size = new System.Drawing.Size(45, 13);
            this.Stglb.TabIndex = 42;
            this.Stglb.Text = "Gender:";
            // 
            // Stdblb
            // 
            this.Stdblb.AutoSize = true;
            this.Stdblb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Stdblb.Location = new System.Drawing.Point(16, 131);
            this.Stdblb.Name = "Stdblb";
            this.Stdblb.Size = new System.Drawing.Size(69, 13);
            this.Stdblb.TabIndex = 41;
            this.Stdblb.Text = "Date of Birth:";
            // 
            // Sntxt
            // 
            this.Sntxt.Location = new System.Drawing.Point(101, 89);
            this.Sntxt.Name = "Sntxt";
            this.Sntxt.Size = new System.Drawing.Size(120, 20);
            this.Sntxt.TabIndex = 40;
            // 
            // Stsnlb
            // 
            this.Stsnlb.AutoSize = true;
            this.Stsnlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Stsnlb.Location = new System.Drawing.Point(16, 92);
            this.Stsnlb.Name = "Stsnlb";
            this.Stsnlb.Size = new System.Drawing.Size(52, 13);
            this.Stsnlb.TabIndex = 39;
            this.Stsnlb.Text = "Surname:";
            // 
            // Fntxt
            // 
            this.Fntxt.Location = new System.Drawing.Point(101, 51);
            this.Fntxt.Name = "Fntxt";
            this.Fntxt.Size = new System.Drawing.Size(120, 20);
            this.Fntxt.TabIndex = 38;
            // 
            // Stfnlb
            // 
            this.Stfnlb.AutoSize = true;
            this.Stfnlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Stfnlb.Location = new System.Drawing.Point(16, 54);
            this.Stfnlb.Name = "Stfnlb";
            this.Stfnlb.Size = new System.Drawing.Size(60, 13);
            this.Stfnlb.TabIndex = 37;
            this.Stfnlb.Text = "First Name:";
            // 
            // Imbox
            // 
            this.Imbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Imbox.Location = new System.Drawing.Point(348, 39);
            this.Imbox.Name = "Imbox";
            this.Imbox.Size = new System.Drawing.Size(162, 149);
            this.Imbox.TabIndex = 52;
            this.Imbox.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(528, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 64;
            this.button5.Text = "Browse";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // StudentRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 521);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Cotxt);
            this.Controls.Add(this.Coitxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lobnt);
            this.Controls.Add(this.Cbtn);
            this.Controls.Add(this.Sitxt);
            this.Controls.Add(this.Silb);
            this.Controls.Add(this.Stsearchbtn);
            this.Controls.Add(this.Stremovebtn);
            this.Controls.Add(this.StAddbtn);
            this.Controls.Add(this.Stupdatebtn);
            this.Controls.Add(this.StDGV);
            this.Controls.Add(this.Imbox);
            this.Controls.Add(this.Dbtxt);
            this.Controls.Add(this.Gntxt);
            this.Controls.Add(this.stimlb);
            this.Controls.Add(this.Adtxt);
            this.Controls.Add(this.stadlb);
            this.Controls.Add(this.Pntxt);
            this.Controls.Add(this.stpnlb);
            this.Controls.Add(this.Stclb);
            this.Controls.Add(this.Stglb);
            this.Controls.Add(this.Stdblb);
            this.Controls.Add(this.Sntxt);
            this.Controls.Add(this.Stsnlb);
            this.Controls.Add(this.Fntxt);
            this.Controls.Add(this.Stfnlb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentRegistrationForm";
            this.Load += new System.EventHandler(this.StudentRegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cotxt;
        private System.Windows.Forms.ComboBox Coitxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lobnt;
        private System.Windows.Forms.Button Cbtn;
        private System.Windows.Forms.TextBox Sitxt;
        private System.Windows.Forms.Label Silb;
        private System.Windows.Forms.Button Stsearchbtn;
        private System.Windows.Forms.Button Stremovebtn;
        private System.Windows.Forms.Button StAddbtn;
        private System.Windows.Forms.Button Stupdatebtn;
        private System.Windows.Forms.DataGridView StDGV;
        private System.Windows.Forms.PictureBox Imbox;
        private System.Windows.Forms.DateTimePicker Dbtxt;
        private System.Windows.Forms.ComboBox Gntxt;
        private System.Windows.Forms.Label stimlb;
        private System.Windows.Forms.TextBox Adtxt;
        private System.Windows.Forms.Label stadlb;
        private System.Windows.Forms.TextBox Pntxt;
        private System.Windows.Forms.Label stpnlb;
        private System.Windows.Forms.Label Stclb;
        private System.Windows.Forms.Label Stglb;
        private System.Windows.Forms.Label Stdblb;
        private System.Windows.Forms.TextBox Sntxt;
        private System.Windows.Forms.Label Stsnlb;
        private System.Windows.Forms.TextBox Fntxt;
        private System.Windows.Forms.Label Stfnlb;
        private System.Windows.Forms.Button button5;
    }
}