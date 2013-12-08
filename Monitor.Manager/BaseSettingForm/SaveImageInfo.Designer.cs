namespace Monitor.Manager.BaseSettingForm
{
    partial class SaveImageInfo
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
            this.label4 = new System.Windows.Forms.Label ( );
            this.btnCancel = new System.Windows.Forms.Button ( );
            this.btnAdd = new System.Windows.Forms.Button ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.label1 = new System.Windows.Forms.Label ( );
            this.txtImageName = new Monitor.Manager.UserTextBox ( );
            this.txtSort = new Monitor.Manager.UserTextBox ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.textBox1 = new System.Windows.Forms.TextBox ( );
            this.pictureBox1 = new System.Windows.Forms.PictureBox ( );
            this.btnBrower = new System.Windows.Forms.Button ( );
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog ( );
            this.groupBox1.SuspendLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit ( );
            this.SuspendLayout ( );
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point (45, 182);
            this.label4.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size (66, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "排序值";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point (233, 288);
            this.btnCancel.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size (125, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler (this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point (57, 288);
            this.btnAdd.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size (125, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler (this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (65, 117);
            this.label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (47, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "名称";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point (0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (905, 74);
            this.label1.TabIndex = 16;
            this.label1.Text = "保存图片";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtImageName
            // 
            this.txtImageName.Location = new System.Drawing.Point (123, 117);
            this.txtImageName.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size (255, 35);
            this.txtImageName.TabIndex = 1;
            this.txtImageName.TextValue = "";
            // 
            // txtSort
            // 
            this.txtSort.Location = new System.Drawing.Point (123, 176);
            this.txtSort.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size (65, 35);
            this.txtSort.TabIndex = 2;
            this.txtSort.TextValue = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add (this.textBox1);
            this.groupBox1.Controls.Add (this.pictureBox1);
            this.groupBox1.Controls.Add (this.btnBrower);
            this.groupBox1.Location = new System.Drawing.Point (410, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size (475, 263);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图片选择";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point (20, 220);
            this.textBox1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size (259, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.DoubleClick += new System.EventHandler (this.textBox1_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point (20, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size (418, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBrower
            // 
            this.btnBrower.Location = new System.Drawing.Point (313, 217);
            this.btnBrower.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size (125, 36);
            this.btnBrower.TabIndex = 3;
            this.btnBrower.Text = "浏览";
            this.btnBrower.UseVisualStyleBackColor = true;
            this.btnBrower.Click += new System.EventHandler (this.btnBrower_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.jpg";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "图片文件|*.jpg;*.gif;*.bmp";
            this.openFileDialog1.Title = "图片信息选择";
            // 
            // SaveImageInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (905, 401);
            this.Controls.Add (this.groupBox1);
            this.Controls.Add (this.txtSort);
            this.Controls.Add (this.txtImageName);
            this.Controls.Add (this.label4);
            this.Controls.Add (this.btnCancel);
            this.Controls.Add (this.btnAdd);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.label1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveImageInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "保存图片";
            this.Load += new System.EventHandler (this.SaveImageInfo_Load);
            this.groupBox1.ResumeLayout (false);
            this.groupBox1.PerformLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit ( );
            this.ResumeLayout (false);
            this.PerformLayout ( );

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UserTextBox txtImageName;
        private UserTextBox txtSort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrower;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}