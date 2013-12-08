namespace Monitor.Manager.UpdateInfoForm
{
    partial class UpdateInfoToClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle ( );
            this.label1 = new System.Windows.Forms.Label ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.txtClassName = new Monitor.Manager.UserTextBox ( );
            this.txtSpecialty = new Monitor.Manager.UserTextBox ( );
            this.txtStudentName = new Monitor.Manager.UserTextBox ( );
            this.txtStudentNumber = new Monitor.Manager.UserTextBox ( );
            this.label6 = new System.Windows.Forms.Label ( );
            this.btnAddToClient = new System.Windows.Forms.Button ( );
            this.label5 = new System.Windows.Forms.Label ( );
            this.btnOk = new System.Windows.Forms.Button ( );
            this.label4 = new System.Windows.Forms.Label ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.groupBox2 = new System.Windows.Forms.GroupBox ( );
            this.panel3 = new System.Windows.Forms.Panel ( );
            this.dgStudentsList = new System.Windows.Forms.DataGridView ( );
            this.tcNumber = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcMobile = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcFacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcClass = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcStartSchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcSchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.groupBox1.SuspendLayout ( );
            this.groupBox2.SuspendLayout ( );
            this.panel3.SuspendLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentsList)).BeginInit ( );
            this.SuspendLayout ( );
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point (0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding (8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (1370, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "更新信息到客户端";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add (this.txtClassName);
            this.groupBox1.Controls.Add (this.txtSpecialty);
            this.groupBox1.Controls.Add (this.txtStudentName);
            this.groupBox1.Controls.Add (this.txtStudentNumber);
            this.groupBox1.Controls.Add (this.label6);
            this.groupBox1.Controls.Add (this.btnAddToClient);
            this.groupBox1.Controls.Add (this.label5);
            this.groupBox1.Controls.Add (this.btnOk);
            this.groupBox1.Controls.Add (this.label4);
            this.groupBox1.Controls.Add (this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point (0, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding (8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding (8);
            this.groupBox1.Size = new System.Drawing.Size (1370, 140);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条件选择区域";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point (846, 24);
            this.txtClassName.Margin = new System.Windows.Forms.Padding (22, 21, 22, 21);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.PasswordChar = '\0';
            this.txtClassName.Size = new System.Drawing.Size (197, 35);
            this.txtClassName.TabIndex = 4;
            this.txtClassName.TextValue = "";
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Location = new System.Drawing.Point (595, 24);
            this.txtSpecialty.Margin = new System.Windows.Forms.Padding (13);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.PasswordChar = '\0';
            this.txtSpecialty.Size = new System.Drawing.Size (197, 35);
            this.txtSpecialty.TabIndex = 3;
            this.txtSpecialty.TextValue = "";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point (351, 24);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding (8);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.PasswordChar = '\0';
            this.txtStudentName.Size = new System.Drawing.Size (197, 30);
            this.txtStudentName.TabIndex = 2;
            this.txtStudentName.TextValue = "";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point (99, 24);
            this.txtStudentNumber.Margin = new System.Windows.Forms.Padding (5);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.PasswordChar = '\0';
            this.txtStudentNumber.Size = new System.Drawing.Size (197, 30);
            this.txtStudentNumber.TabIndex = 1;
            this.txtStudentNumber.TextValue = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point (794, 30);
            this.label6.Margin = new System.Windows.Forms.Padding (8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size (47, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "班级";
            // 
            // btnAddToClient
            // 
            this.btnAddToClient.Location = new System.Drawing.Point (83, 77);
            this.btnAddToClient.Margin = new System.Windows.Forms.Padding (8);
            this.btnAddToClient.Name = "btnAddToClient";
            this.btnAddToClient.Size = new System.Drawing.Size (314, 47);
            this.btnAddToClient.TabIndex = 7;
            this.btnAddToClient.Text = "将当前数据更新到客户端";
            this.btnAddToClient.UseVisualStyleBackColor = true;
            this.btnAddToClient.Click += new System.EventHandler (this.btnAddToClient_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point (544, 30);
            this.label5.Margin = new System.Windows.Forms.Padding (8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size (47, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "专业";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point (1062, 16);
            this.btnOk.Margin = new System.Windows.Forms.Padding (8);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size (192, 57);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "取数据";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler (this.btnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point (301, 30);
            this.label4.Margin = new System.Windows.Forms.Padding (8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size (47, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (39, 30);
            this.label2.Margin = new System.Windows.Forms.Padding (8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (47, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "学号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add (this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point (0, 192);
            this.groupBox2.Margin = new System.Windows.Forms.Padding (8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding (8);
            this.groupBox2.Size = new System.Drawing.Size (1370, 348);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "获取的信息列表";
            // 
            // panel3
            // 
            this.panel3.Controls.Add (this.dgStudentsList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point (8, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding (8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size (1354, 310);
            this.panel3.TabIndex = 7;
            // 
            // dgStudentsList
            // 
            this.dgStudentsList.AllowUserToAddRows = false;
            this.dgStudentsList.AllowUserToDeleteRows = false;
            this.dgStudentsList.AllowUserToOrderColumns = true;
            this.dgStudentsList.AllowUserToResizeColumns = false;
            this.dgStudentsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStudentsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgStudentsList.ColumnHeadersHeight = 32;
            this.dgStudentsList.Columns.AddRange (new System.Windows.Forms.DataGridViewColumn[] {
            this.tcNumber,
            this.tcName,
            this.tcMobile,
            this.tcFacultyName,
            this.tcClass,
            this.tcStartSchoolYear,
            this.tcSchoolYear,
            this.tcStudentID});
            this.dgStudentsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStudentsList.Location = new System.Drawing.Point (0, 0);
            this.dgStudentsList.Margin = new System.Windows.Forms.Padding (5);
            this.dgStudentsList.Name = "dgStudentsList";
            this.dgStudentsList.RowHeadersVisible = false;
            this.dgStudentsList.RowTemplate.Height = 23;
            this.dgStudentsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStudentsList.Size = new System.Drawing.Size (1354, 310);
            this.dgStudentsList.TabIndex = 1;
            // 
            // tcNumber
            // 
            this.tcNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcNumber.DataPropertyName = "StudentNumber";
            this.tcNumber.HeaderText = "学号";
            this.tcNumber.Name = "tcNumber";
            // 
            // tcName
            // 
            this.tcName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcName.DataPropertyName = "StudentName";
            this.tcName.HeaderText = "姓名";
            this.tcName.Name = "tcName";
            // 
            // tcMobile
            // 
            this.tcMobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcMobile.DataPropertyName = "Mobile";
            this.tcMobile.HeaderText = "联系方式";
            this.tcMobile.Name = "tcMobile";
            // 
            // tcFacultyName
            // 
            this.tcFacultyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcFacultyName.DataPropertyName = "FacultyName";
            this.tcFacultyName.HeaderText = "院系";
            this.tcFacultyName.Name = "tcFacultyName";
            // 
            // tcClass
            // 
            this.tcClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcClass.DataPropertyName = "ClassName";
            this.tcClass.HeaderText = "班级";
            this.tcClass.Name = "tcClass";
            // 
            // tcStartSchoolYear
            // 
            this.tcStartSchoolYear.DataPropertyName = "StartSchoolYear";
            this.tcStartSchoolYear.HeaderText = "入学时间";
            this.tcStartSchoolYear.Name = "tcStartSchoolYear";
            // 
            // tcSchoolYear
            // 
            this.tcSchoolYear.DataPropertyName = "SchoolYear";
            this.tcSchoolYear.HeaderText = "学制";
            this.tcSchoolYear.Name = "tcSchoolYear";
            this.tcSchoolYear.Width = 60;
            // 
            // tcStudentID
            // 
            this.tcStudentID.DataPropertyName = "StudentID";
            this.tcStudentID.HeaderText = "学生标识";
            this.tcStudentID.Name = "tcStudentID";
            this.tcStudentID.Visible = false;
            // 
            // UpdateInfoToClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (1370, 540);
            this.Controls.Add (this.groupBox2);
            this.Controls.Add (this.groupBox1);
            this.Controls.Add (this.label1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding (5);
            this.Name = "UpdateInfoToClient";
            this.Text = "更新信息到客户端";
            this.groupBox1.ResumeLayout (false);
            this.groupBox1.PerformLayout ( );
            this.groupBox2.ResumeLayout (false);
            this.panel3.ResumeLayout (false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentsList)).EndInit ( );
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddToClient;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private UserTextBox txtClassName;
        private UserTextBox txtSpecialty;
        private UserTextBox txtStudentName;
        private UserTextBox txtStudentNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgStudentsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcFacultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcStartSchoolYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcSchoolYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcStudentID;
    }
}