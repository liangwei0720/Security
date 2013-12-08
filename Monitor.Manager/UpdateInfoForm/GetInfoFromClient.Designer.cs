namespace Monitor.Manager.UpdateInfoForm
{
    partial class GetInfoFromClient
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboxType = new System.Windows.Forms.ComboBox();
			this.comboxClient = new System.Windows.Forms.ComboBox();
			this.btnAddToDB = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgList = new System.Windows.Forms.DataGridView();
			this.tcInOutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tcInOutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tcStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tcLabelCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgErrorList = new System.Windows.Forms.DataGridView();
			this.tcCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.tcIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tcProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tcErrorInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tcErrorTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tcID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tcGuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgErrorList)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1370, 74);
			this.label1.TabIndex = 1;
			this.label1.Text = "从客户端获取信息";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboxType);
			this.groupBox1.Controls.Add(this.comboxClient);
			this.groupBox1.Controls.Add(this.btnAddToDB);
			this.groupBox1.Controls.Add(this.btnOk);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 74);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox1.Size = new System.Drawing.Size(1370, 89);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "条件选择区域";
			// 
			// comboxType
			// 
			this.comboxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboxType.FormattingEnabled = true;
			this.comboxType.Items.AddRange(new object[] {
            "日志",
            "出入记录"});
			this.comboxType.Location = new System.Drawing.Point(535, 33);
			this.comboxType.Margin = new System.Windows.Forms.Padding(5);
			this.comboxType.Name = "comboxType";
			this.comboxType.Size = new System.Drawing.Size(227, 27);
			this.comboxType.TabIndex = 4;
			// 
			// comboxClient
			// 
			this.comboxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboxClient.FormattingEnabled = true;
			this.comboxClient.Location = new System.Drawing.Point(115, 33);
			this.comboxClient.Margin = new System.Windows.Forms.Padding(5);
			this.comboxClient.Name = "comboxClient";
			this.comboxClient.Size = new System.Drawing.Size(227, 27);
			this.comboxClient.TabIndex = 4;
			// 
			// btnAddToDB
			// 
			this.btnAddToDB.Location = new System.Drawing.Point(987, 31);
			this.btnAddToDB.Margin = new System.Windows.Forms.Padding(5);
			this.btnAddToDB.Name = "btnAddToDB";
			this.btnAddToDB.Size = new System.Drawing.Size(221, 36);
			this.btnAddToDB.TabIndex = 2;
			this.btnAddToDB.Text = "将当前数据放入数据库";
			this.btnAddToDB.UseVisualStyleBackColor = true;
			this.btnAddToDB.Visible = false;
			this.btnAddToDB.Click += new System.EventHandler(this.btnAddToDB_Click);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(811, 31);
			this.btnOk.Margin = new System.Windows.Forms.Padding(5);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(125, 36);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "取数据";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 40);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "客户端";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(437, 40);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "信息类型";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel3);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 163);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox2.Size = new System.Drawing.Size(1370, 464);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "获取的信息列表";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgErrorList);
			this.panel3.Controls.Add(this.dgList);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(5, 27);
			this.panel3.Margin = new System.Windows.Forms.Padding(5);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1360, 432);
			this.panel3.TabIndex = 7;
			// 
			// dgList
			// 
			this.dgList.AllowUserToAddRows = false;
			this.dgList.AllowUserToDeleteRows = false;
			this.dgList.AllowUserToOrderColumns = true;
			this.dgList.AllowUserToResizeColumns = false;
			this.dgList.AllowUserToResizeRows = false;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcInOutID,
            this.tcInOutTime,
            this.tcStatus,
            this.tcLabelCode});
			this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgList.Location = new System.Drawing.Point(0, 0);
			this.dgList.Margin = new System.Windows.Forms.Padding(5);
			this.dgList.Name = "dgList";
			this.dgList.RowHeadersVisible = false;
			this.dgList.RowTemplate.Height = 23;
			this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgList.Size = new System.Drawing.Size(1360, 432);
			this.dgList.TabIndex = 0;
			this.dgList.Visible = false;
			// 
			// tcInOutID
			// 
			this.tcInOutID.DataPropertyName = "InOutID";
			this.tcInOutID.HeaderText = "出入ID";
			this.tcInOutID.Name = "tcInOutID";
			this.tcInOutID.ReadOnly = true;
			// 
			// tcInOutTime
			// 
			this.tcInOutTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.tcInOutTime.DataPropertyName = "InOutTime";
			this.tcInOutTime.HeaderText = "出入时间";
			this.tcInOutTime.Name = "tcInOutTime";
			this.tcInOutTime.ReadOnly = true;
			// 
			// tcStatus
			// 
			this.tcStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.tcStatus.DataPropertyName = "CurrentStatus";
			this.tcStatus.HeaderText = "正常出入";
			this.tcStatus.Name = "tcStatus";
			this.tcStatus.ReadOnly = true;
			// 
			// tcLabelCode
			// 
			this.tcLabelCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.tcLabelCode.DataPropertyName = "LabelCode";
			this.tcLabelCode.HeaderText = "标签标号";
			this.tcLabelCode.Name = "tcLabelCode";
			this.tcLabelCode.ReadOnly = true;
			// 
			// dgErrorList
			// 
			this.dgErrorList.AllowUserToAddRows = false;
			this.dgErrorList.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgErrorList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgErrorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgErrorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcCheck,
            this.tcIP,
            this.tcProjectName,
            this.tcErrorInfo,
            this.tcErrorTime,
            this.tcID,
            this.tcGuID});
			this.dgErrorList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgErrorList.Location = new System.Drawing.Point(0, 0);
			this.dgErrorList.Margin = new System.Windows.Forms.Padding(5);
			this.dgErrorList.Name = "dgErrorList";
			this.dgErrorList.RowHeadersVisible = false;
			this.dgErrorList.RowTemplate.Height = 23;
			this.dgErrorList.Size = new System.Drawing.Size(1360, 432);
			this.dgErrorList.TabIndex = 10;
			this.dgErrorList.Visible = false;
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
			// GetInfoFromClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 627);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "GetInfoFromClient";
			this.Text = "从客户端获取信息";
			this.Load += new System.EventHandler(this.GetInfoFromClient_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgErrorList)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboxClient;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboxType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Button btnAddToDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcInOutID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcInOutTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcLabelCode;
		private System.Windows.Forms.DataGridView dgErrorList;
		private System.Windows.Forms.DataGridViewCheckBoxColumn tcCheck;
		private System.Windows.Forms.DataGridViewTextBoxColumn tcIP;
		private System.Windows.Forms.DataGridViewTextBoxColumn tcProjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn tcErrorInfo;
		private System.Windows.Forms.DataGridViewTextBoxColumn tcErrorTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn tcID;
		private System.Windows.Forms.DataGridViewTextBoxColumn tcGuID;
    }
}