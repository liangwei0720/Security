namespace Monitor.Manager.WorkStationForms
{
	partial class WorkStationsList
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && (components != null) )
			{
				components.Dispose( );
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle ( );
            this.lblTitle = new System.Windows.Forms.Label ( );
            this.panel3 = new System.Windows.Forms.Panel ( );
            this.dgWorkStationsList = new System.Windows.Forms.DataGridView ( );
            this.btnEdit = new System.Windows.Forms.Button ( );
            this.btnDel = new System.Windows.Forms.Button ( );
            this.btnAdd = new System.Windows.Forms.Button ( );
            this.panel2 = new System.Windows.Forms.Panel ( );
            this.btnSearch = new System.Windows.Forms.Button ( );
            this.groupBoxList = new System.Windows.Forms.GroupBox ( );
            this.工作站名称 = new System.Windows.Forms.Label ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.txtWorkStationID = new Monitor.Manager.UserTextBox ( );
            this.panel1 = new System.Windows.Forms.Panel ( );
            this.tcCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn ( );
            this.tcStationID = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcDormID = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcDormName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcPosition = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.panel3.SuspendLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkStationsList)).BeginInit ( );
            this.panel2.SuspendLayout ( );
            this.groupBoxList.SuspendLayout ( );
            this.groupBox1.SuspendLayout ( );
            this.panel1.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point (0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size (1370, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "工作站信息列表";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add (this.dgWorkStationsList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point (5, 85);
            this.panel3.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size (1360, 489);
            this.panel3.TabIndex = 7;
            // 
            // dgWorkStationsList
            // 
            this.dgWorkStationsList.AllowUserToAddRows = false;
            this.dgWorkStationsList.AllowUserToDeleteRows = false;
            this.dgWorkStationsList.AllowUserToOrderColumns = true;
            this.dgWorkStationsList.AllowUserToResizeColumns = false;
            this.dgWorkStationsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgWorkStationsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgWorkStationsList.ColumnHeadersHeight = 32;
            this.dgWorkStationsList.Columns.AddRange (new System.Windows.Forms.DataGridViewColumn[] {
            this.tcCheck,
            this.tcStationID,
            this.tcDormID,
            this.tcDormName,
            this.tcTypeName,
            this.tcPosition});
            this.dgWorkStationsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgWorkStationsList.Location = new System.Drawing.Point (0, 0);
            this.dgWorkStationsList.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.dgWorkStationsList.MultiSelect = false;
            this.dgWorkStationsList.Name = "dgWorkStationsList";
            this.dgWorkStationsList.RowHeadersVisible = false;
            this.dgWorkStationsList.RowTemplate.Height = 23;
            this.dgWorkStationsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgWorkStationsList.Size = new System.Drawing.Size (1360, 489);
            this.dgWorkStationsList.TabIndex = 0;
            this.dgWorkStationsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler (this.dgWorkStationsList_CellDoubleClick);
            this.dgWorkStationsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler (this.dgWorkStationsList_DataBindingComplete);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point (177, 5);
            this.btnEdit.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size (100, 48);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler (this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point (331, 5);
            this.btnDel.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size (100, 48);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler (this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point (40, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size (100, 48);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler (this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add (this.btnAdd);
            this.panel2.Controls.Add (this.btnDel);
            this.panel2.Controls.Add (this.btnEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point (5, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size (1360, 58);
            this.panel2.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point (878, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size (125, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler (this.btnSearch_Click);
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add (this.panel3);
            this.groupBoxList.Controls.Add (this.panel2);
            this.groupBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxList.Location = new System.Drawing.Point (0, 124);
            this.groupBoxList.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Padding = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBoxList.Size = new System.Drawing.Size (1370, 579);
            this.groupBoxList.TabIndex = 5;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "工作站信息列表";
            // 
            // 工作站名称
            // 
            this.工作站名称.AutoSize = true;
            this.工作站名称.Location = new System.Drawing.Point (62, 34);
            this.工作站名称.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.工作站名称.Name = "工作站名称";
            this.工作站名称.Size = new System.Drawing.Size (104, 19);
            this.工作站名称.TabIndex = 0;
            this.工作站名称.Text = "工作站名称";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add (this.txtWorkStationID);
            this.groupBox1.Controls.Add (this.btnSearch);
            this.groupBox1.Controls.Add (this.工作站名称);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point (0, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size (1370, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检索区域";
            // 
            // txtWorkStationID
            // 
            this.txtWorkStationID.Location = new System.Drawing.Point (182, 27);
            this.txtWorkStationID.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtWorkStationID.Name = "txtWorkStationID";
            this.txtWorkStationID.Size = new System.Drawing.Size (652, 36);
            this.txtWorkStationID.TabIndex = 3;
            this.txtWorkStationID.TextValue = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add (this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point (0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size (1370, 48);
            this.panel1.TabIndex = 3;
            // 
            // tcCheck
            // 
            this.tcCheck.Frozen = true;
            this.tcCheck.HeaderText = "选择";
            this.tcCheck.Name = "tcCheck";
            this.tcCheck.Width = 60;
            // 
            // tcStationID
            // 
            this.tcStationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcStationID.DataPropertyName = "StationID";
            this.tcStationID.HeaderText = "编号";
            this.tcStationID.Name = "tcStationID";
            this.tcStationID.ReadOnly = true;
            // 
            // tcDormID
            // 
            this.tcDormID.DataPropertyName = "DormID";
            this.tcDormID.HeaderText = "所在公寓ID";
            this.tcDormID.Name = "tcDormID";
            this.tcDormID.ReadOnly = true;
            this.tcDormID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tcDormID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tcDormID.Visible = false;
            // 
            // tcDormName
            // 
            this.tcDormName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcDormName.HeaderText = "所在公寓";
            this.tcDormName.Name = "tcDormName";
            this.tcDormName.ReadOnly = true;
            // 
            // tcTypeName
            // 
            this.tcTypeName.DataPropertyName = "StationType";
            this.tcTypeName.HeaderText = "类型";
            this.tcTypeName.Name = "tcTypeName";
            this.tcTypeName.ReadOnly = true;
            // 
            // tcPosition
            // 
            this.tcPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcPosition.DataPropertyName = "StationPostion";
            this.tcPosition.HeaderText = "所在位置";
            this.tcPosition.Name = "tcPosition";
            this.tcPosition.ReadOnly = true;
            this.tcPosition.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tcPosition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WorkStationsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (1370, 703);
            this.Controls.Add (this.groupBoxList);
            this.Controls.Add (this.groupBox1);
            this.Controls.Add (this.panel1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.Name = "WorkStationsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "工作站信息";
            this.Load += new System.EventHandler (this.WorkStationsList_Load);
            this.panel3.ResumeLayout (false);
            ((System.ComponentModel.ISupportInitialize)(this.dgWorkStationsList)).EndInit ( );
            this.panel2.ResumeLayout (false);
            this.groupBoxList.ResumeLayout (false);
            this.groupBox1.ResumeLayout (false);
            this.groupBox1.PerformLayout ( );
            this.panel1.ResumeLayout (false);
            this.ResumeLayout (false);

		}

		#endregion

       
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgWorkStationsList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.Label 工作站名称;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private UserTextBox txtWorkStationID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tcCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcStationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDormID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDormName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcPosition;
	}
}