namespace Monitor.Manager.DormForm
{
    partial class SaveDorm
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
            this.label2 = new System.Windows.Forms.Label ( );
            this.label5 = new System.Windows.Forms.Label ( );
            this.label1 = new System.Windows.Forms.Label ( );
            this.txtDormName = new Monitor.Manager.UserTextBox ( );
            this.txtFlools = new Monitor.Manager.UserTextBox ( );
            this.txtRemark = new Monitor.Manager.UserTextBox ( );
            this.labTitle = new System.Windows.Forms.Label ( );
            this.SuspendLayout ( );
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point (392, 317);
            this.btnCancel.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size (125, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler (this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point (120, 317);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size (125, 36);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler (this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (313, 117);
            this.label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (66, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "总层数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point (47, 217);
            this.label5.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size (47, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "备注";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point (47, 117);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (47, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "名称";
            // 
            // txtDormName
            // 
            this.txtDormName.Location = new System.Drawing.Point (107, 109);
            this.txtDormName.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtDormName.Name = "txtDormName";
            this.txtDormName.Size = new System.Drawing.Size (172, 35);
            this.txtDormName.TabIndex = 1;
            this.txtDormName.TextValue = "";
            // 
            // txtFlools
            // 
            this.txtFlools.Location = new System.Drawing.Point (392, 109);
            this.txtFlools.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtFlools.Name = "txtFlools";
            this.txtFlools.Size = new System.Drawing.Size (183, 35);
            this.txtFlools.TabIndex = 2;
            this.txtFlools.TextValue = "";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point (107, 209);
            this.txtRemark.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size (468, 35);
            this.txtRemark.TabIndex = 3;
            this.txtRemark.TextValue = "";
            // 
            // labTitle
            // 
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labTitle.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.Location = new System.Drawing.Point (0, 0);
            this.labTitle.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size (657, 74);
            this.labTitle.TabIndex = 12;
            this.labTitle.Text = "保存公寓信息";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveDorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (657, 431);
            this.Controls.Add (this.labTitle);
            this.Controls.Add (this.txtRemark);
            this.Controls.Add (this.txtFlools);
            this.Controls.Add (this.txtDormName);
            this.Controls.Add (this.btnCancel);
            this.Controls.Add (this.btnSubmit);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.label5);
            this.Controls.Add (this.label1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveDorm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "保存公寓信息";
            this.Load += new System.EventHandler (this.SaveDorm_Load);
            this.ResumeLayout (false);
            this.PerformLayout ( );

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private UserTextBox txtDormName;
        private UserTextBox txtFlools;
        private UserTextBox txtRemark;
        private System.Windows.Forms.Label labTitle;
    }
}