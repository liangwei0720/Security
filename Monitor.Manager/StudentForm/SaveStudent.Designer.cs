namespace Monitor.Manager.StudentForm
{
    partial class SaveStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ( );
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.lblTitle = new System.Windows.Forms.Label ( );
            this.btnCancle = new System.Windows.Forms.Button ( );
            this.btnSubmit = new System.Windows.Forms.Button ( );
            this.label4 = new System.Windows.Forms.Label ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.label3 = new System.Windows.Forms.Label ( );
            this.label1 = new System.Windows.Forms.Label ( );
            this.label5 = new System.Windows.Forms.Label ( );
            this.label6 = new System.Windows.Forms.Label ( );
            this.label7 = new System.Windows.Forms.Label ( );
            this.label8 = new System.Windows.Forms.Label ( );
            this.label9 = new System.Windows.Forms.Label ( );
            this.label10 = new System.Windows.Forms.Label ( );
            this.label11 = new System.Windows.Forms.Label ( );
            this.cmbDorm = new System.Windows.Forms.ComboBox ( );
            this.cmbDormRoom = new System.Windows.Forms.ComboBox ( );
            this.txtName = new Monitor.Manager.UserTextBox ( );
            this.txtNumber = new Monitor.Manager.UserTextBox ( );
            this.txtMobile = new Monitor.Manager.UserTextBox ( );
            this.txtFaculty = new Monitor.Manager.UserTextBox ( );
            this.txtClassName = new Monitor.Manager.UserTextBox ( );
            this.txtSpecialty = new Monitor.Manager.UserTextBox ( );
            this.txtSchoolYear = new Monitor.Manager.UserTextBox ( );
            this.rbtnMale = new System.Windows.Forms.RadioButton ( );
            this.rbtnFemale = new System.Windows.Forms.RadioButton ( );
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.button1 = new System.Windows.Forms.Button ( );
            this.textBox1 = new System.Windows.Forms.TextBox ( );
            this.pictureLogo = new System.Windows.Forms.PictureBox ( );
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker ( );
            this.groupBox1.SuspendLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit ( );
            this.SuspendLayout ( );
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point (0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size (1157, 62);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "添加学生信息";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point (473, 396);
            this.btnCancle.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size (125, 36);
            this.btnCancle.TabIndex = 15;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler (this.btnCancle_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point (218, 396);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size (125, 36);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler (this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point (70, 144);
            this.label4.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size (85, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "联系方式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (110, 333);
            this.label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (47, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "性别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point (445, 84);
            this.label3.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (47, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "学号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point (110, 84);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (47, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point (405, 144);
            this.label5.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size (85, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "所在院系";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point (70, 201);
            this.label6.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size (85, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "所在班级";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point (405, 201);
            this.label7.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size (85, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "入学年月";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point (110, 252);
            this.label8.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size (47, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "专业";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point (445, 252);
            this.label9.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size (47, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "年制";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point (110, 296);
            this.label10.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size (47, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "公寓";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point (445, 296);
            this.label11.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size (47, 19);
            this.label11.TabIndex = 7;
            this.label11.Text = "宿舍";
            // 
            // cmbDorm
            // 
            this.cmbDorm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDorm.FormattingEnabled = true;
            this.cmbDorm.Location = new System.Drawing.Point (170, 290);
            this.cmbDorm.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.cmbDorm.Name = "cmbDorm";
            this.cmbDorm.Size = new System.Drawing.Size (166, 27);
            this.cmbDorm.TabIndex = 9;
            this.cmbDorm.SelectedIndexChanged += new System.EventHandler (this.cmbDorm_SelectedIndexChanged);
            // 
            // cmbDormRoom
            // 
            this.cmbDormRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDormRoom.FormattingEnabled = true;
            this.cmbDormRoom.Location = new System.Drawing.Point (498, 290);
            this.cmbDormRoom.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.cmbDormRoom.Name = "cmbDormRoom";
            this.cmbDormRoom.Size = new System.Drawing.Size (166, 27);
            this.cmbDormRoom.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point (170, 76);
            this.txtName.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size (190, 35);
            this.txtName.TabIndex = 1;
            this.txtName.TextValue = "";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point (498, 76);
            this.txtNumber.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size (190, 35);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.TextValue = "";
            this.txtNumber.Leave += new System.EventHandler (this.txtNumber_Leave);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point (170, 136);
            this.txtMobile.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size (190, 35);
            this.txtMobile.TabIndex = 3;
            this.txtMobile.TextValue = "";
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point (498, 136);
            this.txtFaculty.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size (190, 35);
            this.txtFaculty.TabIndex = 4;
            this.txtFaculty.TextValue = "";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point (170, 193);
            this.txtClassName.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size (190, 35);
            this.txtClassName.TabIndex = 5;
            this.txtClassName.TextValue = "";
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Location = new System.Drawing.Point (170, 244);
            this.txtSpecialty.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size (190, 35);
            this.txtSpecialty.TabIndex = 7;
            this.txtSpecialty.TextValue = "";
            // 
            // txtSchoolYear
            // 
            this.txtSchoolYear.Location = new System.Drawing.Point (498, 244);
            this.txtSchoolYear.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtSchoolYear.Name = "txtSchoolYear";
            this.txtSchoolYear.Size = new System.Drawing.Size (190, 35);
            this.txtSchoolYear.TabIndex = 8;
            this.txtSchoolYear.TextValue = "";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Checked = true;
            this.rbtnMale.Location = new System.Drawing.Point (173, 333);
            this.rbtnMale.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size (46, 23);
            this.rbtnMale.TabIndex = 11;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "男";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point (260, 333);
            this.rbtnFemale.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size (46, 23);
            this.rbtnFemale.TabIndex = 12;
            this.rbtnFemale.Text = "女";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb (((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add (this.button1);
            this.groupBox1.Controls.Add (this.textBox1);
            this.groupBox1.Controls.Add (this.pictureLogo);
            this.groupBox1.Location = new System.Drawing.Point (742, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size (372, 350);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生照片";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point (262, 272);
            this.button1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size (97, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler (this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point (47, 272);
            this.textBox1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size (202, 29);
            this.textBox1.TabIndex = 5;
            this.textBox1.DoubleClick += new System.EventHandler (this.button1_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLogo.Location = new System.Drawing.Point (47, 38);
            this.pictureLogo.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size (274, 187);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 4;
            this.pictureLogo.TabStop = false;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point (498, 192);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size (187, 29);
            this.dtpStartDate.TabIndex = 6;
            // 
            // SaveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (1157, 478);
            this.Controls.Add (this.dtpStartDate);
            this.Controls.Add (this.groupBox1);
            this.Controls.Add (this.rbtnFemale);
            this.Controls.Add (this.rbtnMale);
            this.Controls.Add (this.txtSchoolYear);
            this.Controls.Add (this.txtFaculty);
            this.Controls.Add (this.txtNumber);
            this.Controls.Add (this.txtSpecialty);
            this.Controls.Add (this.txtClassName);
            this.Controls.Add (this.txtMobile);
            this.Controls.Add (this.txtName);
            this.Controls.Add (this.lblTitle);
            this.Controls.Add (this.btnCancle);
            this.Controls.Add (this.btnSubmit);
            this.Controls.Add (this.cmbDormRoom);
            this.Controls.Add (this.cmbDorm);
            this.Controls.Add (this.label11);
            this.Controls.Add (this.label9);
            this.Controls.Add (this.label10);
            this.Controls.Add (this.label7);
            this.Controls.Add (this.label8);
            this.Controls.Add (this.label5);
            this.Controls.Add (this.label6);
            this.Controls.Add (this.label4);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.label3);
            this.Controls.Add (this.label1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加学生信息";
            this.Load += new System.EventHandler (this.SaveStudent_Load);
            this.groupBox1.ResumeLayout (false);
            this.groupBox1.PerformLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit ( );
            this.ResumeLayout (false);
            this.PerformLayout ( );

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDorm;
        private System.Windows.Forms.ComboBox cmbDormRoom;
        private UserTextBox txtName;
        private UserTextBox txtNumber;
        private UserTextBox txtMobile;
        private UserTextBox txtFaculty;
        private UserTextBox txtClassName;
        private UserTextBox txtSpecialty;
        private UserTextBox txtSchoolYear;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
    }
}