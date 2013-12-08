namespace Monitor.Manager.LabelForm
{
    partial class SelectLabel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle ( );
            this.label1 = new System.Windows.Forms.Label ( );
            this.btnOK = new System.Windows.Forms.Button ( );
            this.dgList = new System.Windows.Forms.DataGridView ( );
            this.btnSearch = new System.Windows.Forms.Button ( );
            this.panel1 = new System.Windows.Forms.Panel ( );
            this.btnCancel = new System.Windows.Forms.Button ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.txtStudentNumber = new Monitor.Manager.UserTextBox ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.groupBox2 = new System.Windows.Forms.GroupBox ( );
            this.tcLabelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcLabelName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcPower = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit ( );
            this.panel1.SuspendLayout ( );
            this.groupBox1.SuspendLayout ( );
            this.groupBox2.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point (0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "        ";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point (112, 22);
            this.btnOK.Margin = new System.Windows.Forms.Padding (5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size (125, 36);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler (this.btnOK_Click);
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange (new System.Windows.Forms.DataGridViewColumn[] {
            this.tcLabelNumber,
            this.tcLabelName,
            this.tcPower});
            this.dgList.Location = new System.Drawing.Point (0, 86);
            this.dgList.Margin = new System.Windows.Forms.Padding (5);
            this.dgList.MultiSelect = false;
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowHeadersVisible = false;
            this.dgList.RowTemplate.Height = 23;
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size (657, 256);
            this.dgList.TabIndex = 0;
            this.dgList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler (this.dgList_CellDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point (430, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding (5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size (125, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler (this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add (this.btnCancel);
            this.panel1.Controls.Add (this.btnOK);
            this.panel1.Location = new System.Drawing.Point (0, 342);
            this.panel1.Margin = new System.Windows.Forms.Padding (5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size (657, 67);
            this.panel1.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point (375, 22);
            this.btnCancel.Margin = new System.Windows.Forms.Padding (5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size (125, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler (this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add (this.btnSearch);
            this.groupBox1.Controls.Add (this.txtStudentNumber);
            this.groupBox1.Controls.Add (this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point (0, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding (5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding (5);
            this.groupBox1.Size = new System.Drawing.Size (657, 85);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条件选择区";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point (112, 32);
            this.txtStudentNumber.Margin = new System.Windows.Forms.Padding (5);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.PasswordChar = '\0';
            this.txtStudentNumber.Size = new System.Drawing.Size (238, 35);
            this.txtStudentNumber.TabIndex = 1;
            this.txtStudentNumber.TextValue = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (13, 38);
            this.label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "标签编号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add (this.panel1);
            this.groupBox2.Controls.Add (this.dgList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point (0, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding (5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding (5);
            this.groupBox2.Size = new System.Drawing.Size (657, 412);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据显示区";
            // 
            // tcLabelNumber
            // 
            this.tcLabelNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcLabelNumber.DataPropertyName = "LabelNumber";
            this.tcLabelNumber.HeaderText = "编号";
            this.tcLabelNumber.Name = "tcLabelNumber";
            this.tcLabelNumber.ReadOnly = true;
            // 
            // tcLabelName
            // 
            this.tcLabelName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcLabelName.DataPropertyName = "LabelName";
            this.tcLabelName.HeaderText = "名称";
            this.tcLabelName.Name = "tcLabelName";
            this.tcLabelName.ReadOnly = true;
            // 
            // tcPower
            // 
            this.tcPower.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcPower.DataPropertyName = "Power";
            this.tcPower.HeaderText = "功率";
            this.tcPower.Name = "tcPower";
            this.tcPower.ReadOnly = true;
            this.tcPower.Visible = false;
            // 
            // SelectLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (657, 431);
            this.Controls.Add (this.groupBox1);
            this.Controls.Add (this.groupBox2);
            this.Controls.Add (this.label1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding (5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择标签";
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit ( );
            this.panel1.ResumeLayout (false);
            this.groupBox1.ResumeLayout (false);
            this.groupBox1.PerformLayout ( );
            this.groupBox2.ResumeLayout (false);
            this.ResumeLayout (false);
            this.PerformLayout ( );

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private UserTextBox txtStudentNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcLabelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcLabelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcPower;

    }
}