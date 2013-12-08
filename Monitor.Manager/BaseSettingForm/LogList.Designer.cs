namespace Monitor.Manager.BaseSettingForm
{
    partial class LogList
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
            this.groupBox = new System.Windows.Forms.GroupBox ( );
            this.panel1 = new System.Windows.Forms.Panel ( );
            this.dataGridView1 = new System.Windows.Forms.DataGridView ( );
            this.panel2 = new System.Windows.Forms.Panel ( );
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker ( );
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker ( );
            this.label3 = new System.Windows.Forms.Label ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.btnDel = new System.Windows.Forms.Button ( );
            this.btnSearch = new System.Windows.Forms.Button ( );
            this.btnGetErrorInfo = new System.Windows.Forms.Button ( );
            this.tcCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn ( );
            this.tcIP = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcErrorInfo = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcErrorTime = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcID = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcGuID = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.groupBox.SuspendLayout ( );
            this.panel1.SuspendLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit ( );
            this.panel2.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point (0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (1338, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "错误日志信息列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add (this.panel1);
            this.groupBox.Controls.Add (this.panel2);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point (0, 45);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size (1338, 370);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "日志列表";
            // 
            // panel1
            // 
            this.panel1.Controls.Add (this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point (3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size (1332, 284);
            this.panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange (new System.Windows.Forms.DataGridViewColumn[] {
            this.tcCheck,
            this.tcIP,
            this.tcProjectName,
            this.tcErrorInfo,
            this.tcErrorTime,
            this.tcID,
            this.tcGuID});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point (0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding (5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size (1332, 284);
            this.dataGridView1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add (this.dateTimeEnd);
            this.panel2.Controls.Add (this.dateTimeBegin);
            this.panel2.Controls.Add (this.label3);
            this.panel2.Controls.Add (this.label2);
            this.panel2.Controls.Add (this.btnGetErrorInfo);
            this.panel2.Controls.Add (this.btnDel);
            this.panel2.Controls.Add (this.btnSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point (3, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding (5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size (1332, 58);
            this.panel2.TabIndex = 9;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point (344, 13);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size (200, 29);
            this.dateTimeEnd.TabIndex = 7;
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeBegin.Location = new System.Drawing.Point (113, 15);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size (200, 29);
            this.dateTimeBegin.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point (319, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (19, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (104, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "时间段选择";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point (860, 5);
            this.btnDel.Margin = new System.Windows.Forms.Padding (5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size (125, 48);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler (this.btnDel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point (635, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding (5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size (125, 48);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler (this.btnSearch_Click);
            // 
            // btnGetErrorInfo
            // 
            this.btnGetErrorInfo.Location = new System.Drawing.Point (1041, 5);
            this.btnGetErrorInfo.Margin = new System.Windows.Forms.Padding (5);
            this.btnGetErrorInfo.Name = "btnGetErrorInfo";
            this.btnGetErrorInfo.Size = new System.Drawing.Size (180, 48);
            this.btnGetErrorInfo.TabIndex = 5;
            this.btnGetErrorInfo.Text = "从客户端获取日志";
            this.btnGetErrorInfo.UseVisualStyleBackColor = true;
            this.btnGetErrorInfo.Click += new System.EventHandler (this.btnGetErrorInfo_Click);
            // 
            // tcCheck
            // 
            this.tcCheck.HeaderText = "选择";
            this.tcCheck.Name = "tcCheck";
            this.tcCheck.Width = 60;
            // 
            // tcIP
            // 
            this.tcIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcIP.DataPropertyName = "IPAddress";
            this.tcIP.HeaderText = "错误机IP地址";
            this.tcIP.Name = "tcIP";
            this.tcIP.ReadOnly = true;
            // 
            // tcProjectName
            // 
            this.tcProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcProjectName.DataPropertyName = "ProjectName";
            this.tcProjectName.HeaderText = "项目名称";
            this.tcProjectName.Name = "tcProjectName";
            this.tcProjectName.ReadOnly = true;
            // 
            // tcErrorInfo
            // 
            this.tcErrorInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcErrorInfo.DataPropertyName = "ErrorMsg";
            this.tcErrorInfo.HeaderText = "错误信息";
            this.tcErrorInfo.Name = "tcErrorInfo";
            this.tcErrorInfo.ReadOnly = true;
            // 
            // tcErrorTime
            // 
            this.tcErrorTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcErrorTime.DataPropertyName = "ErrorTime";
            dataGridViewCellStyle2.Format = "yyyy-MM-dd HH:mm";
            dataGridViewCellStyle2.NullValue = null;
            this.tcErrorTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.tcErrorTime.HeaderText = "发生时间";
            this.tcErrorTime.Name = "tcErrorTime";
            this.tcErrorTime.ReadOnly = true;
            // 
            // tcID
            // 
            this.tcID.DataPropertyName = "ID";
            this.tcID.HeaderText = "标识列";
            this.tcID.Name = "tcID";
            this.tcID.Visible = false;
            // 
            // tcGuID
            // 
            this.tcGuID.DataPropertyName = "guID";
            this.tcGuID.HeaderText = "服务器端标识列";
            this.tcGuID.Name = "tcGuID";
            this.tcGuID.Visible = false;
            // 
            // LogList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (1338, 415);
            this.Controls.Add (this.groupBox);
            this.Controls.Add (this.label1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding (5);
            this.Name = "LogList";
            this.Text = "错误日志列表";
            this.Load += new System.EventHandler (this.LogList_Load);
            this.groupBox.ResumeLayout (false);
            this.panel1.ResumeLayout (false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit ( );
            this.panel2.ResumeLayout (false);
            this.panel2.PerformLayout ( );
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetErrorInfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tcCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcErrorInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcErrorTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcGuID;
    }
}