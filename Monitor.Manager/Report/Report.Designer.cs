namespace Monitor.Manager.Report
{
    partial class Report
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
            this.lableTitle = new System.Windows.Forms.Label ( );
            this.panel1 = new System.Windows.Forms.Panel ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.button1 = new System.Windows.Forms.Button ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.groupBox2 = new System.Windows.Forms.GroupBox ( );
            this.panel3 = new System.Windows.Forms.Panel ( );
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer ( );
            this.txtCondition = new Monitor.Manager.UserTextBox ( );
            this.panel1.SuspendLayout ( );
            this.groupBox1.SuspendLayout ( );
            this.groupBox2.SuspendLayout ( );
            this.panel3.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // lableTitle
            // 
            this.lableTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lableTitle.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lableTitle.Location = new System.Drawing.Point (0, 0);
            this.lableTitle.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.lableTitle.Name = "lableTitle";
            this.lableTitle.Size = new System.Drawing.Size (1362, 47);
            this.lableTitle.TabIndex = 0;
            this.lableTitle.Text = "报表预览";
            this.lableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add (this.lableTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point (0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding (5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size (1362, 52);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add (this.txtCondition);
            this.groupBox1.Controls.Add (this.button1);
            this.groupBox1.Controls.Add (this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point (0, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding (5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding (5);
            this.groupBox1.Size = new System.Drawing.Size (1362, 66);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检索区域";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point (643, 21);
            this.button1.Margin = new System.Windows.Forms.Padding (5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size (125, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler (this.button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (29, 28);
            this.label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (104, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "学号或姓名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add (this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point (0, 118);
            this.groupBox2.Margin = new System.Windows.Forms.Padding (5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding (5);
            this.groupBox2.Size = new System.Drawing.Size (1362, 487);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "报表预览区";
            // 
            // panel3
            // 
            this.panel3.Controls.Add (this.crystalReportViewer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point (5, 27);
            this.panel3.Margin = new System.Windows.Forms.Padding (5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size (1352, 455);
            this.panel3.TabIndex = 7;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point (0, 0);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding (5);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size (1352, 455);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point (143, 22);
            this.txtCondition.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.PasswordChar = '\0';
            this.txtCondition.Size = new System.Drawing.Size (381, 38);
            this.txtCondition.TabIndex = 3;
            this.txtCondition.TextValue = "";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (1362, 605);
            this.Controls.Add (this.groupBox2);
            this.Controls.Add (this.groupBox1);
            this.Controls.Add (this.panel1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding (5);
            this.Name = "Report";
            this.Text = "报表预览";
            this.Load += new System.EventHandler (this.Report_Load);
            this.panel1.ResumeLayout (false);
            this.groupBox1.ResumeLayout (false);
            this.groupBox1.PerformLayout ( );
            this.groupBox2.ResumeLayout (false);
            this.panel3.ResumeLayout (false);
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.Label lableTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private UserTextBox txtCondition;
        //private StudentGoods StudentGoods1;
    }
}