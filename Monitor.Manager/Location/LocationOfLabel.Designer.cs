namespace Monitor.Manager.Location
{
	partial class LocationOfLabel
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.dgGoodsList = new System.Windows.Forms.DataGridView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtLabelName = new Monitor.Manager.UserTextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tcCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.tcGoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tcBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tcModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgGoodsList)).BeginInit();
			this.panel3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1370, 43);
			this.label1.TabIndex = 0;
			this.label1.Text = "标签信息列表";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgGoodsList
			// 
			this.dgGoodsList.AllowUserToAddRows = false;
			this.dgGoodsList.AllowUserToDeleteRows = false;
			this.dgGoodsList.AllowUserToOrderColumns = true;
			this.dgGoodsList.AllowUserToResizeColumns = false;
			this.dgGoodsList.AllowUserToResizeRows = false;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgGoodsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgGoodsList.ColumnHeadersHeight = 32;
			this.dgGoodsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcCheck,
            this.tcGoodsName,
            this.tcBrand,
            this.tcModel});
			this.dgGoodsList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgGoodsList.Location = new System.Drawing.Point(0, 0);
			this.dgGoodsList.Margin = new System.Windows.Forms.Padding(5);
			this.dgGoodsList.Name = "dgGoodsList";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgGoodsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgGoodsList.RowHeadersVisible = false;
			this.dgGoodsList.RowTemplate.Height = 23;
			this.dgGoodsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgGoodsList.Size = new System.Drawing.Size(1360, 439);
			this.dgGoodsList.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgGoodsList);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(5, 27);
			this.panel3.Margin = new System.Windows.Forms.Padding(5);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1360, 439);
			this.panel3.TabIndex = 7;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel3);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 102);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox2.Size = new System.Drawing.Size(1370, 471);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "标签信息定位";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtLabelName);
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 44);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox1.Size = new System.Drawing.Size(1370, 58);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "检索区域";
			// 
			// txtLabelName
			// 
			this.txtLabelName.Location = new System.Drawing.Point(160, 23);
			this.txtLabelName.Margin = new System.Windows.Forms.Padding(5);
			this.txtLabelName.Name = "txtLabelName";
			this.txtLabelName.PasswordChar = '\0';
			this.txtLabelName.Size = new System.Drawing.Size(523, 35);
			this.txtLabelName.TabIndex = 3;
			this.txtLabelName.TextValue = "";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(764, 18);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(125, 36);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "搜索";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(62, 31);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "标签名称";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1370, 44);
			this.panel1.TabIndex = 3;
			// 
			// tcCheck
			// 
			this.tcCheck.HeaderText = "选择";
			this.tcCheck.Name = "tcCheck";
			this.tcCheck.Visible = false;
			this.tcCheck.Width = 60;
			// 
			// tcGoodsName
			// 
			this.tcGoodsName.DataPropertyName = "GoodsName";
			this.tcGoodsName.HeaderText = "标签名称";
			this.tcGoodsName.Name = "tcGoodsName";
			this.tcGoodsName.ReadOnly = true;
			this.tcGoodsName.Width = 150;
			// 
			// tcBrand
			// 
			this.tcBrand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.tcBrand.DataPropertyName = "Brand";
			this.tcBrand.HeaderText = "当前位置";
			this.tcBrand.Name = "tcBrand";
			this.tcBrand.ReadOnly = true;
			// 
			// tcModel
			// 
			this.tcModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.tcModel.DataPropertyName = "Model";
			this.tcModel.HeaderText = "获取位置时间";
			this.tcModel.Name = "tcModel";
			this.tcModel.ReadOnly = true;
			// 
			// LocationOfLabel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 573);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "LocationOfLabel";
			this.Text = "标签信息列表";
			((System.ComponentModel.ISupportInitialize)(this.dgGoodsList)).EndInit();
			this.panel3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgGoodsList;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private UserTextBox txtLabelName;
		private System.Windows.Forms.DataGridViewCheckBoxColumn tcCheck;
		private System.Windows.Forms.DataGridViewTextBoxColumn tcGoodsName;
		private System.Windows.Forms.DataGridViewTextBoxColumn tcBrand;
		private System.Windows.Forms.DataGridViewTextBoxColumn tcModel;
	}
}