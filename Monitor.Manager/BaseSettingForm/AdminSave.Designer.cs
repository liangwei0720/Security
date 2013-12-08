namespace Monitor.Manager.BaseSettingForm
{
    partial class AdminSave
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
            this.label3 = new System.Windows.Forms.Label ( );
            this.btnCancel = new System.Windows.Forms.Button ( );
            this.btnAdd = new System.Windows.Forms.Button ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.label1 = new System.Windows.Forms.Label ( );
            this.txtPWD = new Monitor.Manager.UserTextBox ( );
            this.txtLandName = new Monitor.Manager.UserTextBox ( );
            this.SuspendLayout ( );
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point (109, 170);
            this.label3.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (47, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "密码";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point (366, 280);
            this.btnCancel.Margin = new System.Windows.Forms.Padding (5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size (125, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler (this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point (139, 280);
            this.btnAdd.Margin = new System.Windows.Forms.Padding (5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size (125, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "确定";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler (this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (90, 95);
            this.label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (66, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "登录名";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point (0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (657, 74);
            this.label1.TabIndex = 16;
            this.label1.Text = "添加管理员 ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point (157, 165);
            this.txtPWD.Margin = new System.Windows.Forms.Padding (8);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.PasswordChar = '\0';
            this.txtPWD.Size = new System.Drawing.Size (377, 29);
            this.txtPWD.TabIndex = 3;
            this.txtPWD.TextValue = "";
            // 
            // txtLandName
            // 
            this.txtLandName.Location = new System.Drawing.Point (157, 88);
            this.txtLandName.Margin = new System.Windows.Forms.Padding (8);
            this.txtLandName.Name = "txtLandName";
            this.txtLandName.PasswordChar = '\0';
            this.txtLandName.Size = new System.Drawing.Size (377, 32);
            this.txtLandName.TabIndex = 1;
            this.txtLandName.TextValue = "";
            // 
            // AdminSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (657, 431);
            this.Controls.Add (this.txtPWD);
            this.Controls.Add (this.txtLandName);
            this.Controls.Add (this.label3);
            this.Controls.Add (this.btnCancel);
            this.Controls.Add (this.btnAdd);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.label1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding (5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminSave";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加管理员";
            this.Load += new System.EventHandler (this.AdminSave_Load);
            this.ResumeLayout (false);
            this.PerformLayout ( );

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UserTextBox txtLandName;
        private UserTextBox txtPWD;
    }
}