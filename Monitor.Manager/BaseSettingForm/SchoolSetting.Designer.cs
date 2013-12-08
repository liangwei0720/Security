namespace Monitor.Manager.BaseSettingForm
{
	partial class SchoolSetting
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
            this.btnSubmit = new System.Windows.Forms.Button ( );
            this.btnCancel = new System.Windows.Forms.Button ( );
            this.txtCode = new Monitor.Manager.UserTextBox ( );
            this.txtName = new Monitor.Manager.UserTextBox ( );
            this.rtbIntro = new Monitor.Manager.UserTextBox ( );
            this.SuspendLayout ( );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point (23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "学校名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point (23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "学校编码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point (23, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (85, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "学校简介";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.Location = new System.Drawing.Point (69, 295);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size (100, 39);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler (this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point (266, 295);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size (100, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler (this.btnCancel_Click);
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCode.Location = new System.Drawing.Point (119, 74);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size (247, 39);
            this.txtCode.TabIndex = 2;
            this.txtCode.TextValue = "";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.Location = new System.Drawing.Point (119, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size (247, 39);
            this.txtName.TabIndex = 1;
            this.txtName.TextValue = "";
            // 
            // rtbIntro
            // 
            this.rtbIntro.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbIntro.Location = new System.Drawing.Point (119, 119);
            this.rtbIntro.Name = "rtbIntro";
            this.rtbIntro.Size = new System.Drawing.Size (247, 155);
            this.rtbIntro.TabIndex = 2;
            this.rtbIntro.TextValue = "";
            // 
            // SchoolSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size (411, 364);
            this.Controls.Add (this.rtbIntro);
            this.Controls.Add (this.txtCode);
            this.Controls.Add (this.txtName);
            this.Controls.Add (this.btnCancel);
            this.Controls.Add (this.btnSubmit);
            this.Controls.Add (this.label3);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SchoolSetting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学校基本信息设置";
            this.Load += new System.EventHandler (this.SchoolSetting_Load);
            this.ResumeLayout (false);
            this.PerformLayout ( );

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnCancel;
        private UserTextBox txtName;
        private UserTextBox txtCode;
        private UserTextBox rtbIntro;
	}
}