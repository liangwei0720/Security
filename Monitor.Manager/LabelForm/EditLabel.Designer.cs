namespace Monitor.Manager.LabelForm
{
	partial class EditLabel
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
            this.label2 = new System.Windows.Forms.Label ( );
            this.label3 = new System.Windows.Forms.Label ( );
            this.label4 = new System.Windows.Forms.Label ( );
            this.label5 = new System.Windows.Forms.Label ( );
            this.cmbLabelStatus = new System.Windows.Forms.ComboBox ( );
            this.btnSubmit = new System.Windows.Forms.Button ( );
            this.btnCancel = new System.Windows.Forms.Button ( );
            this.lblTitle = new System.Windows.Forms.Label ( );
            this.txtLabelNumber = new Monitor.Manager.UserTextBox ( );
            this.txtLabelName = new Monitor.Manager.UserTextBox ( );
            this.txtLabelPower = new Monitor.Manager.UserTextBox ( );
            this.txtLableRemark = new Monitor.Manager.UserTextBox ( );
            this.SuspendLayout ( );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point (42, 122);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (328, 122);
            this.label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (47, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point (42, 193);
            this.label3.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (47, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "状态";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point (328, 193);
            this.label4.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size (47, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "功率";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point (42, 257);
            this.label5.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size (47, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "说明";
            // 
            // cmbLabelStatus
            // 
            this.cmbLabelStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLabelStatus.FormattingEnabled = true;
            this.cmbLabelStatus.Location = new System.Drawing.Point (100, 190);
            this.cmbLabelStatus.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.cmbLabelStatus.Name = "cmbLabelStatus";
            this.cmbLabelStatus.Size = new System.Drawing.Size (171, 27);
            this.cmbLabelStatus.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point (115, 325);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size (125, 36);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler (this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point (387, 325);
            this.btnCancel.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size (125, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler (this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point (0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size (657, 62);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "添加标签信息";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLabelNumber
            // 
            this.txtLabelNumber.Location = new System.Drawing.Point (100, 117);
            this.txtLabelNumber.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtLabelNumber.Name = "txtLabelNumber";
            this.txtLabelNumber.Size = new System.Drawing.Size (218, 35);
            this.txtLabelNumber.TabIndex = 1;
            this.txtLabelNumber.TextValue = "";
            this.txtLabelNumber.Leave += new System.EventHandler (this.txtLabelNumber_Leave);
            // 
            // txtLabelName
            // 
            this.txtLabelName.Location = new System.Drawing.Point (387, 117);
            this.txtLabelName.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtLabelName.Name = "txtLabelName";
            this.txtLabelName.Size = new System.Drawing.Size (218, 35);
            this.txtLabelName.TabIndex = 2;
            this.txtLabelName.TextValue = "";
            // 
            // txtLabelPower
            // 
            this.txtLabelPower.Location = new System.Drawing.Point (387, 187);
            this.txtLabelPower.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtLabelPower.Name = "txtLabelPower";
            this.txtLabelPower.Size = new System.Drawing.Size (218, 35);
            this.txtLabelPower.TabIndex = 4;
            this.txtLabelPower.TextValue = "";
            // 
            // txtLableRemark
            // 
            this.txtLableRemark.Location = new System.Drawing.Point (100, 249);
            this.txtLableRemark.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtLableRemark.Name = "txtLableRemark";
            this.txtLableRemark.Size = new System.Drawing.Size (505, 35);
            this.txtLableRemark.TabIndex = 5;
            this.txtLableRemark.TextValue = "";
            // 
            // EditLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (657, 431);
            this.Controls.Add (this.txtLableRemark);
            this.Controls.Add (this.txtLabelPower);
            this.Controls.Add (this.txtLabelName);
            this.Controls.Add (this.txtLabelNumber);
            this.Controls.Add (this.lblTitle);
            this.Controls.Add (this.btnCancel);
            this.Controls.Add (this.btnSubmit);
            this.Controls.Add (this.cmbLabelStatus);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.label5);
            this.Controls.Add (this.label4);
            this.Controls.Add (this.label3);
            this.Controls.Add (this.label1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加标签信息";
            this.Load += new System.EventHandler (this.EditLabel_Load);
            this.ResumeLayout (false);
            this.PerformLayout ( );

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbLabelStatus;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private UserTextBox txtLabelNumber;
        private UserTextBox txtLabelName;
        private UserTextBox txtLabelPower;
        private UserTextBox txtLableRemark;
	}
}