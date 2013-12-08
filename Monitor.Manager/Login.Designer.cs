namespace Monitor.Manager
{
    partial class Login
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
            this.uC_Label1 = new Monitor.Manager.UC_Label ( );
            this.uC_Label2 = new Monitor.Manager.UC_Label ( );
            this.txtLoginName = new Monitor.Manager.UserTextBox ( );
            this.txtLoginPwd = new Monitor.Manager.UserTextBox ( );
            this.btnSubmit = new System.Windows.Forms.Button ( );
            this.btnCancel = new System.Windows.Forms.Button ( );
            this.pictureBox1 = new System.Windows.Forms.PictureBox ( );
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit ( );
            this.SuspendLayout ( );
            // 
            // uC_Label1
            // 
            this.uC_Label1.AutoSize = true;
            this.uC_Label1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uC_Label1.Location = new System.Drawing.Point (90, 122);
            this.uC_Label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.uC_Label1.Name = "uC_Label1";
            this.uC_Label1.Size = new System.Drawing.Size (66, 19);
            this.uC_Label1.TabIndex = 0;
            this.uC_Label1.Text = "登录名";
            // 
            // uC_Label2
            // 
            this.uC_Label2.AutoSize = true;
            this.uC_Label2.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uC_Label2.Location = new System.Drawing.Point (109, 203);
            this.uC_Label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.uC_Label2.Name = "uC_Label2";
            this.uC_Label2.Size = new System.Drawing.Size (47, 19);
            this.uC_Label2.TabIndex = 0;
            this.uC_Label2.Text = "密码";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point (165, 122);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding (8);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.PasswordChar = '\0';
            this.txtLoginName.Size = new System.Drawing.Size (333, 33);
            this.txtLoginName.TabIndex = 1;
            this.txtLoginName.TextValue = "";
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.Location = new System.Drawing.Point (165, 193);
            this.txtLoginPwd.Margin = new System.Windows.Forms.Padding (8);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.PasswordChar = '*';
            this.txtLoginPwd.Size = new System.Drawing.Size (333, 29);
            this.txtLoginPwd.TabIndex = 2;
            this.txtLoginPwd.TextValue = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point (138, 278);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding (5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size (125, 36);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler (this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point (373, 278);
            this.btnCancel.Margin = new System.Windows.Forms.Padding (5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size (125, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler (this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Monitor.Manager.Properties.Resources.软件头标;
            this.pictureBox1.Location = new System.Drawing.Point (-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size (640, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (640, 415);
            this.Controls.Add (this.pictureBox1);
            this.Controls.Add (this.btnCancel);
            this.Controls.Add (this.btnSubmit);
            this.Controls.Add (this.txtLoginPwd);
            this.Controls.Add (this.txtLoginName);
            this.Controls.Add (this.uC_Label2);
            this.Controls.Add (this.uC_Label1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding (5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "寓安通高校公寓贵重物品防盗搜寻系统 登录 ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit ( );
            this.ResumeLayout (false);
            this.PerformLayout ( );

        }

        #endregion

        private UC_Label uC_Label1;
        private UC_Label uC_Label2;
        private UserTextBox txtLoginName;
        private UserTextBox txtLoginPwd;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}