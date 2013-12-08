namespace Monitor.Manager.WorkStationForms
{
	partial class SaveWorkStation
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
			if ( disposing && (components != null) )
			{
				components.Dispose( );
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
            this.label1 = new System.Windows.Forms.Label ( );
            this.cmbDorm = new System.Windows.Forms.ComboBox ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.label3 = new System.Windows.Forms.Label ( );
            this.cmbWorkStationType = new System.Windows.Forms.ComboBox ( );
            this.label4 = new System.Windows.Forms.Label ( );
            this.cmbStatus = new System.Windows.Forms.ComboBox ( );
            this.btnSubmit = new System.Windows.Forms.Button ( );
            this.btnCancle = new System.Windows.Forms.Button ( );
            this.lblTitle = new System.Windows.Forms.Label ( );
            this.txtPosition = new Monitor.Manager.UserTextBox ( );
            this.label5 = new System.Windows.Forms.Label ( );
            this.txtStationNumber = new Monitor.Manager.UserTextBox ( );
            this.SuspendLayout ( );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point (322, 95);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "所在公寓";
            // 
            // cmbDorm
            // 
            this.cmbDorm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDorm.FormattingEnabled = true;
            this.cmbDorm.Location = new System.Drawing.Point (418, 95);
            this.cmbDorm.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.cmbDorm.Name = "cmbDorm";
            this.cmbDorm.Size = new System.Drawing.Size (166, 27);
            this.cmbDorm.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (42, 219);
            this.label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "具体位置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point (80, 166);
            this.label3.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (47, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "类型";
            // 
            // cmbWorkStationType
            // 
            this.cmbWorkStationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkStationType.FormattingEnabled = true;
            this.cmbWorkStationType.Items.AddRange (new object[] {
            "主站",
            "子站"});
            this.cmbWorkStationType.Location = new System.Drawing.Point (140, 162);
            this.cmbWorkStationType.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.cmbWorkStationType.Name = "cmbWorkStationType";
            this.cmbWorkStationType.Size = new System.Drawing.Size (170, 27);
            this.cmbWorkStationType.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point (360, 166);
            this.label4.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size (47, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "状态";
            this.label4.Visible = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point (418, 162);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size (166, 27);
            this.cmbStatus.TabIndex = 4;
            this.cmbStatus.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point (122, 311);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size (125, 36);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler (this.btnSubmit_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point (377, 311);
            this.btnCancle.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size (125, 36);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler (this.btnCancle_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point (0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size (640, 74);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "添加工作站信息";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point (142, 211);
            this.txtPosition.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size (445, 35);
            this.txtPosition.TabIndex = 5;
            this.txtPosition.TextValue = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point (80, 98);
            this.label5.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size (47, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "编号";
            // 
            // txtStationNumber
            // 
            this.txtStationNumber.Location = new System.Drawing.Point (140, 90);
            this.txtStationNumber.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtStationNumber.Name = "txtStationNumber";
            this.txtStationNumber.Size = new System.Drawing.Size (170, 35);
            this.txtStationNumber.TabIndex = 1;
            this.txtStationNumber.TextValue = "";
            this.txtStationNumber.Leave += new System.EventHandler (this.txtStationNumber_Leave);
            // 
            // SaveWorkStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (640, 415);
            this.Controls.Add (this.txtStationNumber);
            this.Controls.Add (this.txtPosition);
            this.Controls.Add (this.lblTitle);
            this.Controls.Add (this.btnCancle);
            this.Controls.Add (this.btnSubmit);
            this.Controls.Add (this.cmbWorkStationType);
            this.Controls.Add (this.cmbStatus);
            this.Controls.Add (this.cmbDorm);
            this.Controls.Add (this.label4);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.label3);
            this.Controls.Add (this.label5);
            this.Controls.Add (this.label1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveWorkStation";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加工作站";
            this.Load += new System.EventHandler (this.SaveWorkStation_Load);
            this.ResumeLayout (false);
            this.PerformLayout ( );

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbDorm;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbWorkStationType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label lblTitle;
        private UserTextBox txtPosition;
        private System.Windows.Forms.Label label5;
        private UserTextBox txtStationNumber;
	}
}