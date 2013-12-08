namespace Monitor.Manager.DormForm
{
    partial class SaveDormRoom
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
            this.btnSubmit = new System.Windows.Forms.Button ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.labTitle = new System.Windows.Forms.Label ( );
            this.cmbDormList = new System.Windows.Forms.ComboBox ( );
            this.txtRoomName = new Monitor.Manager.UserTextBox ( );
            this.SuspendLayout ( );
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point (123, 171);
            this.label3.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (85, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "宿舍名称";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point (359, 268);
            this.btnCancel.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size (125, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler (this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point (182, 268);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size (125, 36);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler (this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (123, 101);
            this.label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (85, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "所属公寓";
            // 
            // labTitle
            // 
            this.labTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labTitle.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.Location = new System.Drawing.Point (0, 0);
            this.labTitle.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size (640, 54);
            this.labTitle.TabIndex = 16;
            this.labTitle.Text = "添加宿舍";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDormList
            // 
            this.cmbDormList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDormList.FormattingEnabled = true;
            this.cmbDormList.Location = new System.Drawing.Point (222, 97);
            this.cmbDormList.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.cmbDormList.Name = "cmbDormList";
            this.cmbDormList.Size = new System.Drawing.Size (292, 27);
            this.cmbDormList.TabIndex = 1;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point (223, 163);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size (293, 35);
            this.txtRoomName.TabIndex = 2;
            this.txtRoomName.TextValue = "";
            // 
            // SaveDormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (640, 415);
            this.Controls.Add (this.txtRoomName);
            this.Controls.Add (this.cmbDormList);
            this.Controls.Add (this.label3);
            this.Controls.Add (this.btnCancel);
            this.Controls.Add (this.btnSubmit);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.labTitle);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveDormRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加宿舍";
            this.Load += new System.EventHandler (this.SaveDormRoom_Load);
            this.ResumeLayout (false);
            this.PerformLayout ( );

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.ComboBox cmbDormList;
        private UserTextBox txtRoomName;
    }
}