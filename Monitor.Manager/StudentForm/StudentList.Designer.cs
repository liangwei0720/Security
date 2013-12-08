namespace Monitor.Manager.StudentForm
{
    partial class StudentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgStudentsList = new System.Windows.Forms.DataGridView();
            this.tcCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.studentIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcFacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcStartSchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcSchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.工作站名称 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDormRoom = new System.Windows.Forms.ComboBox();
            this.cmbDorm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentNumber = new Monitor.Manager.UserTextBox();
            this.txtStudentName = new Monitor.Manager.UserTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxList.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentsList)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1465, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "学生列表";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.panel3);
            this.groupBoxList.Controls.Add(this.panel2);
            this.groupBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxList.Location = new System.Drawing.Point(0, 103);
            this.groupBoxList.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxList.Size = new System.Drawing.Size(1151, 272);
            this.groupBoxList.TabIndex = 9;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "学生信息列表";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgStudentsList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 85);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1141, 182);
            this.panel3.TabIndex = 7;
            // 
            // dgStudentsList
            // 
            this.dgStudentsList.AllowUserToAddRows = false;
            this.dgStudentsList.AllowUserToDeleteRows = false;
            this.dgStudentsList.AllowUserToOrderColumns = true;
            this.dgStudentsList.AllowUserToResizeColumns = false;
            this.dgStudentsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStudentsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgStudentsList.ColumnHeadersHeight = 32;
            this.dgStudentsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcCheck,
            this.studentIndex,
            this.tcNumber,
            this.tcName,
            this.tcMobile,
            this.tcFacultyName,
            this.tcClass,
            this.tcStartSchoolYear,
            this.tcSchoolYear,
            this.tcStudentID});
            this.dgStudentsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStudentsList.Location = new System.Drawing.Point(0, 0);
            this.dgStudentsList.Margin = new System.Windows.Forms.Padding(5);
            this.dgStudentsList.Name = "dgStudentsList";
            this.dgStudentsList.RowHeadersVisible = false;
            this.dgStudentsList.RowTemplate.Height = 23;
            this.dgStudentsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStudentsList.Size = new System.Drawing.Size(1141, 182);
            this.dgStudentsList.TabIndex = 0;
            this.dgStudentsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStudentsList_CellDoubleClick);
            // 
            // tcCheck
            // 
            this.tcCheck.HeaderText = "选择";
            this.tcCheck.Name = "tcCheck";
            this.tcCheck.Width = 60;
            // 
            // studentIndex
            // 
            this.studentIndex.DataPropertyName = "StudentIndex";
            this.studentIndex.HeaderText = "序号";
            this.studentIndex.Name = "studentIndex";
            this.studentIndex.ReadOnly = true;
            this.studentIndex.Width = 60;
            // 
            // tcNumber
            // 
            this.tcNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcNumber.DataPropertyName = "StudentNumber";
            this.tcNumber.HeaderText = "学号";
            this.tcNumber.Name = "tcNumber";
            this.tcNumber.ReadOnly = true;
            // 
            // tcName
            // 
            this.tcName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcName.DataPropertyName = "DormAndRoom";
            this.tcName.HeaderText = "姓名";
            this.tcName.Name = "tcName";
            this.tcName.ReadOnly = true;
            // 
            // tcMobile
            // 
            this.tcMobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcMobile.DataPropertyName = "Mobile";
            this.tcMobile.HeaderText = "联系方式";
            this.tcMobile.Name = "tcMobile";
            this.tcMobile.ReadOnly = true;
            // 
            // tcFacultyName
            // 
            this.tcFacultyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcFacultyName.DataPropertyName = "FacultyName";
            this.tcFacultyName.HeaderText = "院系";
            this.tcFacultyName.Name = "tcFacultyName";
            this.tcFacultyName.ReadOnly = true;
            // 
            // tcClass
            // 
            this.tcClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcClass.DataPropertyName = "ClassName";
            this.tcClass.HeaderText = "班级";
            this.tcClass.Name = "tcClass";
            this.tcClass.ReadOnly = true;
            // 
            // tcStartSchoolYear
            // 
            this.tcStartSchoolYear.DataPropertyName = "StartSchoolYear";
            this.tcStartSchoolYear.HeaderText = "入学时间";
            this.tcStartSchoolYear.Name = "tcStartSchoolYear";
            this.tcStartSchoolYear.ReadOnly = true;
            // 
            // tcSchoolYear
            // 
            this.tcSchoolYear.DataPropertyName = "SchoolYear";
            this.tcSchoolYear.HeaderText = "学制";
            this.tcSchoolYear.Name = "tcSchoolYear";
            this.tcSchoolYear.ReadOnly = true;
            this.tcSchoolYear.Width = 60;
            // 
            // tcStudentID
            // 
            this.tcStudentID.DataPropertyName = "StudentID";
            this.tcStudentID.HeaderText = "学生标识";
            this.tcStudentID.Name = "tcStudentID";
            this.tcStudentID.ReadOnly = true;
            this.tcStudentID.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1141, 58);
            this.panel2.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 48);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(423, 6);
            this.btnDel.Margin = new System.Windows.Forms.Padding(5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(125, 48);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(210, 6);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(152, 48);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(858, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // 工作站名称
            // 
            this.工作站名称.AutoSize = true;
            this.工作站名称.Location = new System.Drawing.Point(434, 27);
            this.工作站名称.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.工作站名称.Name = "工作站名称";
            this.工作站名称.Size = new System.Drawing.Size(47, 19);
            this.工作站名称.TabIndex = 0;
            this.工作站名称.Text = "姓名";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDormRoom);
            this.groupBox1.Controls.Add(this.cmbDorm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStudentNumber);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.工作站名称);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1151, 58);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检索区域";
            // 
            // cmbDormRoom
            // 
            this.cmbDormRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDormRoom.FormattingEnabled = true;
            this.cmbDormRoom.Location = new System.Drawing.Point(274, 24);
            this.cmbDormRoom.Name = "cmbDormRoom";
            this.cmbDormRoom.Size = new System.Drawing.Size(152, 27);
            this.cmbDormRoom.TabIndex = 7;
            this.cmbDormRoom.SelectedIndexChanged += new System.EventHandler(this.cmbDormRoom_SelectedIndexChanged);
            // 
            // cmbDorm
            // 
            this.cmbDorm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDorm.FormattingEnabled = true;
            this.cmbDorm.Location = new System.Drawing.Point(61, 24);
            this.cmbDorm.Name = "cmbDorm";
            this.cmbDorm.Size = new System.Drawing.Size(135, 27);
            this.cmbDorm.TabIndex = 8;
            this.cmbDorm.SelectedIndexChanged += new System.EventHandler(this.cmbDorm_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "房间号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "公寓";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(688, 24);
            this.txtStudentNumber.Margin = new System.Windows.Forms.Padding(5);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.PasswordChar = '\0';
            this.txtStudentNumber.Size = new System.Drawing.Size(135, 35);
            this.txtStudentNumber.TabIndex = 2;
            this.txtStudentNumber.TextValue = "";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(482, 24);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(5);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.PasswordChar = '\0';
            this.txtStudentName.Size = new System.Drawing.Size(139, 35);
            this.txtStudentName.TabIndex = 1;
            this.txtStudentName.TextValue = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 45);
            this.panel1.TabIndex = 7;
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 375);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StudentList";
            this.Text = "学生列表";
            this.Load += new System.EventHandler(this.StudentList_Load);
            this.groupBoxList.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentsList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private UserTextBox txtStudentName;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgStudentsList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label 工作站名称;
        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Panel panel1;
        private UserTextBox txtStudentNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tcCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcFacultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcStartSchoolYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcSchoolYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcStudentID;
        private System.Windows.Forms.ComboBox cmbDormRoom;
        private System.Windows.Forms.ComboBox cmbDorm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}