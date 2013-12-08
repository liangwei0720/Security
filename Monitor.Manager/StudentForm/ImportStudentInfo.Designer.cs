namespace Monitor.Manager.StudentForm
{
    partial class ImportStudentInfo
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
            this.label1 = new System.Windows.Forms.Label ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.btnImport = new System.Windows.Forms.Button ( );
            this.btnBrower = new System.Windows.Forms.Button ( );
            this.textBox1 = new System.Windows.Forms.TextBox ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.dgList = new System.Windows.Forms.DataGridView ( );
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog ( );
            this.lblInfo = new System.Windows.Forms.Label ( );
            this.groupBox1.SuspendLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit ( );
            this.SuspendLayout ( );
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point (0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (1128, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "导入学生信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add (this.btnImport);
            this.groupBox1.Controls.Add (this.lblInfo);
            this.groupBox1.Controls.Add (this.btnBrower);
            this.groupBox1.Controls.Add (this.textBox1);
            this.groupBox1.Controls.Add (this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point (0, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size (1128, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件选择区";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point (652, 27);
            this.btnImport.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size (125, 36);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "导入数据库";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Visible = false;
            this.btnImport.Click += new System.EventHandler (this.btnImport_Click);
            // 
            // btnBrower
            // 
            this.btnBrower.Location = new System.Drawing.Point (494, 27);
            this.btnBrower.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size (125, 36);
            this.btnBrower.TabIndex = 2;
            this.btnBrower.Text = "浏览";
            this.btnBrower.UseVisualStyleBackColor = true;
            this.btnBrower.Click += new System.EventHandler (this.btnBrower_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point (140, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size (344, 29);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (62, 36);
            this.label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (47, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "路径";
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.AllowUserToOrderColumns = true;
            this.dgList.AllowUserToResizeColumns = false;
            this.dgList.AllowUserToResizeRows = false;
            this.dgList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgList.ColumnHeadersHeight = 32;
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.Location = new System.Drawing.Point (0, 116);
            this.dgList.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowTemplate.Height = 23;
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size (1128, 365);
            this.dgList.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "excel文档|*.xls";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point (804, 36);
            this.lblInfo.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size (0, 19);
            this.lblInfo.TabIndex = 3;
            // 
            // ImportStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (1128, 481);
            this.Controls.Add (this.dgList);
            this.Controls.Add (this.groupBox1);
            this.Controls.Add (this.label1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.Name = "ImportStudentInfo";
            this.Text = "学生信息导入";
            this.groupBox1.ResumeLayout (false);
            this.groupBox1.PerformLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit ( );
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrower;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblInfo;
    }
}