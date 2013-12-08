namespace Monitor.Manager.RepealForm
{
    partial class RepealLabel
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
            this.lblTitle = new System.Windows.Forms.Label ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.txtClassName = new Monitor.Manager.UserTextBox ( );
            this.txtStudentNumber = new Monitor.Manager.UserTextBox ( );
            this.btnSearch = new System.Windows.Forms.Button ( );
            this.label1 = new System.Windows.Forms.Label ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.groupBox2 = new System.Windows.Forms.GroupBox ( );
            this.panel3 = new System.Windows.Forms.Panel ( );
            this.dataGridView1 = new System.Windows.Forms.DataGridView ( );
            this.tcCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn ( );
            this.物品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.品牌 = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.型号 = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.标签号 = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcClassName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.学制 = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.入学时间 = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.专业 = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.物品编号 = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.panel2 = new System.Windows.Forms.Panel ( );
            this.btnRepeal = new System.Windows.Forms.Button ( );
            this.groupBox1.SuspendLayout ( );
            this.groupBox2.SuspendLayout ( );
            this.panel3.SuspendLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit ( );
            this.panel2.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point (0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size (1207, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "标签物品对应表";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add (this.txtClassName);
            this.groupBox1.Controls.Add (this.txtStudentNumber);
            this.groupBox1.Controls.Add (this.btnSearch);
            this.groupBox1.Controls.Add (this.label1);
            this.groupBox1.Controls.Add (this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point (0, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding (5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding (5);
            this.groupBox1.Size = new System.Drawing.Size (1207, 93);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检索区域";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point (538, 33);
            this.txtClassName.Margin = new System.Windows.Forms.Padding (5);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.PasswordChar = '\0';
            this.txtClassName.Size = new System.Drawing.Size (305, 35);
            this.txtClassName.TabIndex = 3;
            this.txtClassName.TextValue = "";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point (120, 33);
            this.txtStudentNumber.Margin = new System.Windows.Forms.Padding (5);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.PasswordChar = '\0';
            this.txtStudentNumber.Size = new System.Drawing.Size (305, 35);
            this.txtStudentNumber.TabIndex = 3;
            this.txtStudentNumber.TextValue = "";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point (912, 33);
            this.btnSearch.Margin = new System.Windows.Forms.Padding (5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size (125, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler (this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point (460, 41);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "班级名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (62, 41);
            this.label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (47, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "学号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add (this.panel3);
            this.groupBox2.Controls.Add (this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point (0, 139);
            this.groupBox2.Margin = new System.Windows.Forms.Padding (5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding (5);
            this.groupBox2.Size = new System.Drawing.Size (1207, 379);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "标签物品对应表";
            // 
            // panel3
            // 
            this.panel3.Controls.Add (this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point (5, 86);
            this.panel3.Margin = new System.Windows.Forms.Padding (5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size (1197, 288);
            this.panel3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange (new System.Windows.Forms.DataGridViewColumn[] {
            this.tcCheck,
            this.物品名称,
            this.品牌,
            this.型号,
            this.标签号,
            this.姓名,
            this.学号,
            this.tcClassName,
            this.学制,
            this.入学时间,
            this.专业,
            this.物品编号});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point (0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding (5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size (1197, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler (this.dataGridView1_CellContentClick);
            // 
            // tcCheck
            // 
            this.tcCheck.HeaderText = "选择";
            this.tcCheck.Name = "tcCheck";
            this.tcCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tcCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tcCheck.Width = 75;
            // 
            // 物品名称
            // 
            this.物品名称.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.物品名称.DataPropertyName = "物品名称";
            this.物品名称.HeaderText = "物品名称";
            this.物品名称.Name = "物品名称";
            this.物品名称.ReadOnly = true;
            // 
            // 品牌
            // 
            this.品牌.DataPropertyName = "品牌";
            this.品牌.HeaderText = "品牌";
            this.品牌.Name = "品牌";
            this.品牌.ReadOnly = true;
            this.品牌.Width = 160;
            // 
            // 型号
            // 
            this.型号.DataPropertyName = "型号";
            this.型号.HeaderText = "型号";
            this.型号.Name = "型号";
            this.型号.ReadOnly = true;
            // 
            // 标签号
            // 
            this.标签号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.标签号.DataPropertyName = "标签号";
            this.标签号.HeaderText = "标签号";
            this.标签号.Name = "标签号";
            this.标签号.ReadOnly = true;
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "姓名";
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            this.姓名.Width = 200;
            // 
            // 学号
            // 
            this.学号.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.学号.DataPropertyName = "学号";
            this.学号.HeaderText = "学号";
            this.学号.Name = "学号";
            this.学号.ReadOnly = true;
            // 
            // tcClassName
            // 
            this.tcClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcClassName.DataPropertyName = "班级";
            this.tcClassName.HeaderText = "班级";
            this.tcClassName.Name = "tcClassName";
            this.tcClassName.ReadOnly = true;
            // 
            // 学制
            // 
            this.学制.DataPropertyName = "学制";
            this.学制.HeaderText = "学制";
            this.学制.Name = "学制";
            this.学制.ReadOnly = true;
            // 
            // 入学时间
            // 
            this.入学时间.DataPropertyName = "入学时间";
            this.入学时间.HeaderText = "入学时间";
            this.入学时间.Name = "入学时间";
            this.入学时间.ReadOnly = true;
            this.入学时间.Width = 140;
            // 
            // 专业
            // 
            this.专业.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.专业.DataPropertyName = "专业";
            this.专业.HeaderText = "专业";
            this.专业.Name = "专业";
            this.专业.ReadOnly = true;
            // 
            // 物品编号
            // 
            this.物品编号.DataPropertyName = "物品ID";
            this.物品编号.HeaderText = "物品编号";
            this.物品编号.Name = "物品编号";
            this.物品编号.ReadOnly = true;
            this.物品编号.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add (this.btnRepeal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point (5, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding (5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size (1197, 59);
            this.panel2.TabIndex = 6;
            // 
            // btnRepeal
            // 
            this.btnRepeal.Location = new System.Drawing.Point (61, 5);
            this.btnRepeal.Margin = new System.Windows.Forms.Padding (5);
            this.btnRepeal.Name = "btnRepeal";
            this.btnRepeal.Size = new System.Drawing.Size (125, 48);
            this.btnRepeal.TabIndex = 3;
            this.btnRepeal.Text = "销户";
            this.btnRepeal.UseVisualStyleBackColor = true;
            this.btnRepeal.Visible = false;
            this.btnRepeal.Click += new System.EventHandler (this.btnRepeal_Click);
            // 
            // RepealLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (1207, 518);
            this.Controls.Add (this.groupBox2);
            this.Controls.Add (this.groupBox1);
            this.Controls.Add (this.lblTitle);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding (5);
            this.Name = "RepealLabel";
            this.Text = "射频卡销户";
            this.groupBox1.ResumeLayout (false);
            this.groupBox1.PerformLayout ( );
            this.groupBox2.ResumeLayout (false);
            this.panel3.ResumeLayout (false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit ( );
            this.panel2.ResumeLayout (false);
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRepeal;
        private UserTextBox txtClassName;
        private UserTextBox txtStudentNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tcCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品牌;
        private System.Windows.Forms.DataGridViewTextBoxColumn 型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 标签号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学制;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入学时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 专业;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物品编号;

    }
}