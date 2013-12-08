namespace Monitor.Manager.StudentForm
{
    partial class SelectStudent
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
            this.label2 = new System.Windows.Forms.Label ( );
            this.txtStudentNumber = new Monitor.Manager.UserTextBox ( );
            this.txtName = new Monitor.Manager.UserTextBox ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.btnSearch = new System.Windows.Forms.Button ( );
            this.groupBox2 = new System.Windows.Forms.GroupBox ( );
            this.dgList = new System.Windows.Forms.DataGridView ( );
            this.panel1 = new System.Windows.Forms.Panel ( );
            this.btnCancel = new System.Windows.Forms.Button ( );
            this.btnOK = new System.Windows.Forms.Button ( );
            this.tcStudentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcSpecialty = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcStartSchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcSchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.groupBox1.SuspendLayout ( );
            this.groupBox2.SuspendLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit ( );
            this.panel1.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point (13, 38);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (355, 38);
            this.label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (47, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point (72, 30);
            this.txtStudentNumber.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size (202, 35);
            this.txtStudentNumber.TabIndex = 1;
            this.txtStudentNumber.TextValue = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point (413, 30);
            this.txtName.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size (202, 35);
            this.txtName.TabIndex = 2;
            this.txtName.TextValue = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add (this.btnSearch);
            this.groupBox1.Controls.Add (this.txtStudentNumber);
            this.groupBox1.Controls.Add (this.txtName);
            this.groupBox1.Controls.Add (this.label2);
            this.groupBox1.Controls.Add (this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point (0, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size (992, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条件选择区";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point (723, 32);
            this.btnSearch.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size (125, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler (this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add (this.dgList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point (0, 111);
            this.groupBox2.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size (992, 461);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据显示区";
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.AllowUserToOrderColumns = true;
            this.dgList.AllowUserToResizeColumns = false;
            this.dgList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange (new System.Windows.Forms.DataGridViewColumn[] {
            this.tcStudentNumber,
            this.tcStudentName,
            this.tcSpecialty,
            this.tcStartSchoolYear,
            this.tcSchoolYear});
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.Location = new System.Drawing.Point (5, 27);
            this.dgList.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.dgList.MultiSelect = false;
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowHeadersVisible = false;
            this.dgList.RowTemplate.Height = 23;
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size (982, 429);
            this.dgList.TabIndex = 0;
            this.dgList.DoubleClick += new System.EventHandler (this.dgList_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add (this.btnCancel);
            this.panel1.Controls.Add (this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point (0, 482);
            this.panel1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size (992, 90);
            this.panel1.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point (603, 35);
            this.btnCancel.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size (125, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler (this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point (225, 35);
            this.btnOK.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size (125, 36);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler (this.btnOK_Click);
            // 
            // tcStudentNumber
            // 
            this.tcStudentNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcStudentNumber.DataPropertyName = "StudentNumber";
            this.tcStudentNumber.HeaderText = "学号";
            this.tcStudentNumber.Name = "tcStudentNumber";
            this.tcStudentNumber.ReadOnly = true;
            // 
            // tcStudentName
            // 
            this.tcStudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcStudentName.DataPropertyName = "StudentName";
            this.tcStudentName.HeaderText = "姓名";
            this.tcStudentName.Name = "tcStudentName";
            this.tcStudentName.ReadOnly = true;
            // 
            // tcSpecialty
            // 
            this.tcSpecialty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcSpecialty.DataPropertyName = "Specialty";
            this.tcSpecialty.HeaderText = "专业";
            this.tcSpecialty.Name = "tcSpecialty";
            this.tcSpecialty.ReadOnly = true;
            // 
            // tcStartSchoolYear
            // 
            this.tcStartSchoolYear.DataPropertyName = "StartSchoolYear";
            this.tcStartSchoolYear.HeaderText = "入学时间";
            this.tcStartSchoolYear.Name = "tcStartSchoolYear";
            this.tcStartSchoolYear.ReadOnly = true;
            this.tcStartSchoolYear.Width = 160;
            // 
            // tcSchoolYear
            // 
            this.tcSchoolYear.DataPropertyName = "SchoolYear";
            this.tcSchoolYear.HeaderText = "年制";
            this.tcSchoolYear.Name = "tcSchoolYear";
            this.tcSchoolYear.ReadOnly = true;
            this.tcSchoolYear.Width = 70;
            // 
            // SelectStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (992, 572);
            this.Controls.Add (this.panel1);
            this.Controls.Add (this.groupBox2);
            this.Controls.Add (this.groupBox1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectStudent";
            this.Padding = new System.Windows.Forms.Padding (0, 16, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择学生";
            this.Load += new System.EventHandler (this.SelectStudent_Load);
            this.groupBox1.ResumeLayout (false);
            this.groupBox1.PerformLayout ( );
            this.groupBox2.ResumeLayout (false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit ( );
            this.panel1.ResumeLayout (false);
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private UserTextBox txtStudentNumber;
        private UserTextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcStudentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcSpecialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcStartSchoolYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcSchoolYear;
    }
}