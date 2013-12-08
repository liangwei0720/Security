namespace Monitor.Manager.LabelForm
{
    partial class LabelLocation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle ( );
            this.label1 = new System.Windows.Forms.Label ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker ( );
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker ( );
            this.uC_Label3 = new Monitor.Manager.UC_Label ( );
            this.uC_Label2 = new Monitor.Manager.UC_Label ( );
            this.uC_Label4 = new Monitor.Manager.UC_Label ( );
            this.uC_Label1 = new Monitor.Manager.UC_Label ( );
            this.txtStudentNumber = new Monitor.Manager.UserTextBox ( );
            this.txtLabelNumber = new Monitor.Manager.UserTextBox ( );
            this.btnSearch = new System.Windows.Forms.Button ( );
            this.groupBox2 = new System.Windows.Forms.GroupBox ( );
            this.panel3 = new System.Windows.Forms.Panel ( );
            this.dg_List = new System.Windows.Forms.DataGridView ( );
            this.chkLabelID = new System.Windows.Forms.DataGridViewCheckBoxColumn ( );
            this.txlabelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.txLabelName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcStatus = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.txAddDate = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.groupBox1.SuspendLayout ( );
            this.groupBox2.SuspendLayout ( );
            this.panel3.SuspendLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.dg_List)).BeginInit ( );
            this.SuspendLayout ( );
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point (0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (938, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "标签定位信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add (this.dateTimeEnd);
            this.groupBox1.Controls.Add (this.dateTimeBegin);
            this.groupBox1.Controls.Add (this.uC_Label3);
            this.groupBox1.Controls.Add (this.uC_Label2);
            this.groupBox1.Controls.Add (this.uC_Label4);
            this.groupBox1.Controls.Add (this.uC_Label1);
            this.groupBox1.Controls.Add (this.txtStudentNumber);
            this.groupBox1.Controls.Add (this.txtLabelNumber);
            this.groupBox1.Controls.Add (this.btnSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point (0, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding (5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding (5);
            this.groupBox1.Size = new System.Drawing.Size (938, 69);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检索区域";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point (870, 23);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding (5);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size (198, 29);
            this.dateTimeEnd.TabIndex = 5;
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBegin.Location = new System.Drawing.Point (641, 25);
            this.dateTimeBegin.Margin = new System.Windows.Forms.Padding (5);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size (202, 29);
            this.dateTimeBegin.TabIndex = 5;
            // 
            // uC_Label3
            // 
            this.uC_Label3.AutoSize = true;
            this.uC_Label3.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uC_Label3.Location = new System.Drawing.Point (853, 28);
            this.uC_Label3.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.uC_Label3.Name = "uC_Label3";
            this.uC_Label3.Size = new System.Drawing.Size (19, 19);
            this.uC_Label3.TabIndex = 4;
            this.uC_Label3.Text = "~";
            // 
            // uC_Label2
            // 
            this.uC_Label2.AutoSize = true;
            this.uC_Label2.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uC_Label2.Location = new System.Drawing.Point (555, 30);
            this.uC_Label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.uC_Label2.Name = "uC_Label2";
            this.uC_Label2.Size = new System.Drawing.Size (85, 19);
            this.uC_Label2.TabIndex = 4;
            this.uC_Label2.Text = "时间区间";
            // 
            // uC_Label4
            // 
            this.uC_Label4.AutoSize = true;
            this.uC_Label4.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uC_Label4.Location = new System.Drawing.Point (292, 30);
            this.uC_Label4.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.uC_Label4.Name = "uC_Label4";
            this.uC_Label4.Size = new System.Drawing.Size (47, 19);
            this.uC_Label4.TabIndex = 4;
            this.uC_Label4.Text = "学号";
            // 
            // uC_Label1
            // 
            this.uC_Label1.AutoSize = true;
            this.uC_Label1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uC_Label1.Location = new System.Drawing.Point (27, 30);
            this.uC_Label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.uC_Label1.Name = "uC_Label1";
            this.uC_Label1.Size = new System.Drawing.Size (47, 19);
            this.uC_Label1.TabIndex = 4;
            this.uC_Label1.Text = "标签";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point (340, 23);
            this.txtStudentNumber.Margin = new System.Windows.Forms.Padding (8);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.PasswordChar = '\0';
            this.txtStudentNumber.Size = new System.Drawing.Size (202, 52);
            this.txtStudentNumber.TabIndex = 3;
            this.txtStudentNumber.TextValue = "";
            // 
            // txtLabelNumber
            // 
            this.txtLabelNumber.Location = new System.Drawing.Point (75, 23);
            this.txtLabelNumber.Margin = new System.Windows.Forms.Padding (5);
            this.txtLabelNumber.Name = "txtLabelNumber";
            this.txtLabelNumber.PasswordChar = '\0';
            this.txtLabelNumber.Size = new System.Drawing.Size (205, 33);
            this.txtLabelNumber.TabIndex = 3;
            this.txtLabelNumber.TextValue = "";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point (1102, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding (5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size (138, 46);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler (this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add (this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point (0, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding (5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding (5);
            this.groupBox2.Size = new System.Drawing.Size (938, 444);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "标签信息列表";
            // 
            // panel3
            // 
            this.panel3.Controls.Add (this.dg_List);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point (5, 27);
            this.panel3.Margin = new System.Windows.Forms.Padding (5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size (928, 412);
            this.panel3.TabIndex = 7;
            // 
            // dg_List
            // 
            this.dg_List.AllowUserToAddRows = false;
            this.dg_List.AllowUserToDeleteRows = false;
            this.dg_List.AllowUserToResizeColumns = false;
            this.dg_List.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_List.ColumnHeadersHeight = 32;
            this.dg_List.Columns.AddRange (new System.Windows.Forms.DataGridViewColumn[] {
            this.chkLabelID,
            this.txlabelNumber,
            this.txLabelName,
            this.tcStatusName,
            this.tcStatus,
            this.txAddDate});
            this.dg_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_List.Location = new System.Drawing.Point (0, 0);
            this.dg_List.Margin = new System.Windows.Forms.Padding (5);
            this.dg_List.Name = "dg_List";
            this.dg_List.RowHeadersVisible = false;
            this.dg_List.RowTemplate.Height = 23;
            this.dg_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_List.Size = new System.Drawing.Size (928, 412);
            this.dg_List.TabIndex = 0;
            // 
            // chkLabelID
            // 
            this.chkLabelID.Frozen = true;
            this.chkLabelID.HeaderText = "选择";
            this.chkLabelID.Name = "chkLabelID";
            this.chkLabelID.Visible = false;
            this.chkLabelID.Width = 60;
            // 
            // txlabelNumber
            // 
            this.txlabelNumber.DataPropertyName = "HistoryID";
            this.txlabelNumber.HeaderText = "编号";
            this.txlabelNumber.Name = "txlabelNumber";
            this.txlabelNumber.ReadOnly = true;
            this.txlabelNumber.Visible = false;
            // 
            // txLabelName
            // 
            this.txLabelName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txLabelName.DataPropertyName = "LabelMac";
            this.txLabelName.HeaderText = "名称及位置";
            this.txLabelName.Name = "txLabelName";
            // 
            // tcStatusName
            // 
            this.tcStatusName.HeaderText = "当前状态";
            this.tcStatusName.Name = "tcStatusName";
            this.tcStatusName.ReadOnly = true;
            this.tcStatusName.Visible = false;
            // 
            // tcStatus
            // 
            this.tcStatus.DataPropertyName = "Status";
            this.tcStatus.HeaderText = "当前状态";
            this.tcStatus.Name = "tcStatus";
            this.tcStatus.ReadOnly = true;
            this.tcStatus.Visible = false;
            // 
            // txAddDate
            // 
            this.txAddDate.DataPropertyName = "ReceiveTime";
            dataGridViewCellStyle2.Format = "F";
            dataGridViewCellStyle2.NullValue = null;
            this.txAddDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.txAddDate.HeaderText = "定位时间";
            this.txAddDate.Name = "txAddDate";
            this.txAddDate.ReadOnly = true;
            this.txAddDate.Width = 240;
            // 
            // LabelLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (938, 556);
            this.Controls.Add (this.groupBox2);
            this.Controls.Add (this.groupBox1);
            this.Controls.Add (this.label1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding (5);
            this.Name = "LabelLocation";
            this.Text = "定位信息";
            this.groupBox1.ResumeLayout (false);
            this.groupBox1.PerformLayout ( );
            this.groupBox2.ResumeLayout (false);
            this.panel3.ResumeLayout (false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_List)).EndInit ( );
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private UC_Label uC_Label3;
        private UC_Label uC_Label2;
        private UC_Label uC_Label1;
        private UserTextBox txtLabelNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dg_List;
		private UC_Label uC_Label4;
        private UserTextBox txtStudentNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkLabelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txlabelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn txLabelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn txAddDate;
    }
}