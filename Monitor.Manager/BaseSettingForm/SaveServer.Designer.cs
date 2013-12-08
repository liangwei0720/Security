namespace Monitor.Manager.BaseSettingForm
{
    partial class SaveServer
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
            this.btnCancel = new System.Windows.Forms.Button ( );
            this.btnSubmit = new System.Windows.Forms.Button ( );
            this.lblTitle = new System.Windows.Forms.Label ( );
            this.txtServerName = new Monitor.Manager.UserTextBox ( );
            this.txtServerIP = new Monitor.Manager.UserTextBox ( );
            this.cmbDormList = new System.Windows.Forms.ComboBox ( );
            this.txtConnection = new Monitor.Manager.UserTextBox ( );
            this.uC_Label1 = new Monitor.Manager.UC_Label ( );
            this.uC_Label2 = new Monitor.Manager.UC_Label ( );
            this.uC_Label3 = new Monitor.Manager.UC_Label ( );
            this.uC_Label4 = new Monitor.Manager.UC_Label ( );
            this.SuspendLayout ( );
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point (460, 382);
            this.btnCancel.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size (150, 62);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler (this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.Location = new System.Drawing.Point (170, 382);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size (150, 62);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler (this.btnSubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point (0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size (794, 92);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "添加服务器";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point (179, 164);
            this.txtServerName.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size (199, 35);
            this.txtServerName.TabIndex = 1;
            this.txtServerName.TextValue = "";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point (449, 164);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size (204, 35);
            this.txtServerIP.TabIndex = 2;
            this.txtServerIP.TextValue = "";
            // 
            // cmbDormList
            // 
            this.cmbDormList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDormList.FormattingEnabled = true;
            this.cmbDormList.Location = new System.Drawing.Point (179, 226);
            this.cmbDormList.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.cmbDormList.Name = "cmbDormList";
            this.cmbDormList.Size = new System.Drawing.Size (199, 27);
            this.cmbDormList.TabIndex = 3;
            // 
            // txtConnection
            // 
            this.txtConnection.Location = new System.Drawing.Point (179, 292);
            this.txtConnection.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.Size = new System.Drawing.Size (474, 41);
            this.txtConnection.TabIndex = 4;
            this.txtConnection.TextValue = "";
            // 
            // uC_Label1
            // 
            this.uC_Label1.AutoSize = true;
            this.uC_Label1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uC_Label1.Location = new System.Drawing.Point (122, 172);
            this.uC_Label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.uC_Label1.Name = "uC_Label1";
            this.uC_Label1.Size = new System.Drawing.Size (47, 19);
            this.uC_Label1.TabIndex = 22;
            this.uC_Label1.Text = "名称";
            // 
            // uC_Label2
            // 
            this.uC_Label2.AutoSize = true;
            this.uC_Label2.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uC_Label2.Location = new System.Drawing.Point (398, 172);
            this.uC_Label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.uC_Label2.Name = "uC_Label2";
            this.uC_Label2.Size = new System.Drawing.Size (29, 19);
            this.uC_Label2.TabIndex = 22;
            this.uC_Label2.Text = "IP";
            // 
            // uC_Label3
            // 
            this.uC_Label3.AutoSize = true;
            this.uC_Label3.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uC_Label3.Location = new System.Drawing.Point (84, 230);
            this.uC_Label3.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.uC_Label3.Name = "uC_Label3";
            this.uC_Label3.Size = new System.Drawing.Size (85, 19);
            this.uC_Label3.TabIndex = 22;
            this.uC_Label3.Text = "所在公寓";
            // 
            // uC_Label4
            // 
            this.uC_Label4.AutoSize = true;
            this.uC_Label4.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uC_Label4.Location = new System.Drawing.Point (65, 292);
            this.uC_Label4.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.uC_Label4.Name = "uC_Label4";
            this.uC_Label4.Size = new System.Drawing.Size (104, 19);
            this.uC_Label4.TabIndex = 22;
            this.uC_Label4.Text = "客户端实例";
            // 
            // SaveServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (794, 572);
            this.Controls.Add (this.uC_Label2);
            this.Controls.Add (this.uC_Label4);
            this.Controls.Add (this.uC_Label3);
            this.Controls.Add (this.uC_Label1);
            this.Controls.Add (this.cmbDormList);
            this.Controls.Add (this.txtServerIP);
            this.Controls.Add (this.txtConnection);
            this.Controls.Add (this.txtServerName);
            this.Controls.Add (this.btnCancel);
            this.Controls.Add (this.btnSubmit);
            this.Controls.Add (this.lblTitle);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveServer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加服务器信息";
            this.Load += new System.EventHandler (this.SaveServer_Load);
            this.ResumeLayout (false);
            this.PerformLayout ( );

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTitle;
        private UserTextBox txtServerName;
        private UserTextBox txtServerIP;
        private System.Windows.Forms.ComboBox cmbDormList;
        private UserTextBox txtConnection;
        private UC_Label uC_Label1;
        private UC_Label uC_Label2;
        private UC_Label uC_Label3;
        private UC_Label uC_Label4;

    }
}