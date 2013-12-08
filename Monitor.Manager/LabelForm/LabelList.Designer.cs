namespace Monitor.Manager
{
	partial class fm_LabelList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle ( );
            this.AddDate = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.LabelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.LabelName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn ( );
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.panel2 = new System.Windows.Forms.Panel ( );
            this.btnAdd = new System.Windows.Forms.Button ( );
            this.btnDel = new System.Windows.Forms.Button ( );
            this.btnEdit = new System.Windows.Forms.Button ( );
            this.label1 = new System.Windows.Forms.Label ( );
            this.panel3 = new System.Windows.Forms.Panel ( );
            this.dg_List = new System.Windows.Forms.DataGridView ( );
            this.chkLabelID = new System.Windows.Forms.DataGridViewCheckBoxColumn ( );
            this.txlabelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.txLabelName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcStatus = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcLablePower = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.txAddDate = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.btnSearch = new System.Windows.Forms.Button ( );
            this.groupBox2 = new System.Windows.Forms.GroupBox ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.uC_Label1 = new Monitor.Manager.UC_Label ( );
            this.txtSearch = new Monitor.Manager.UserTextBox ( );
            this.panel1 = new System.Windows.Forms.Panel ( );
            this.panel2.SuspendLayout ( );
            this.panel3.SuspendLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.dg_List)).BeginInit ( );
            this.groupBox2.SuspendLayout ( );
            this.groupBox1.SuspendLayout ( );
            this.panel1.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // AddDate
            // 
            this.AddDate.DataPropertyName = "AddDate";
            this.AddDate.HeaderText = "添加时间";
            this.AddDate.Name = "AddDate";
            this.AddDate.ReadOnly = true;
            // 
            // LabelNumber
            // 
            this.LabelNumber.DataPropertyName = "LabelNumber";
            this.LabelNumber.HeaderText = "标签编码";
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.ReadOnly = true;
            // 
            // LabelName
            // 
            this.LabelName.DataPropertyName = "LabelName";
            this.LabelName.HeaderText = "标签名称";
            this.LabelName.Name = "LabelName";
            this.LabelName.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "选择";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Power
            // 
            this.Power.DataPropertyName = "Power";
            this.Power.HeaderText = "功率";
            this.Power.Name = "Power";
            this.Power.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add (this.btnAdd);
            this.panel2.Controls.Add (this.btnDel);
            this.panel2.Controls.Add (this.btnEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point (3, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size (620, 49);
            this.panel2.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point (9, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size (75, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler (this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point (209, 13);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size (75, 30);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler (this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point (106, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size (75, 30);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler (this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point (0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (626, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "标签信息列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add (this.dg_List);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point (3, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size (620, 149);
            this.panel3.TabIndex = 7;
            // 
            // dg_List
            // 
            this.dg_List.AllowUserToAddRows = false;
            this.dg_List.AllowUserToDeleteRows = false;
            this.dg_List.AllowUserToOrderColumns = true;
            this.dg_List.AllowUserToResizeColumns = false;
            this.dg_List.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_List.ColumnHeadersHeight = 32;
            this.dg_List.Columns.AddRange (new System.Windows.Forms.DataGridViewColumn[] {
            this.chkLabelID,
            this.txlabelNumber,
            this.txLabelName,
            this.tcStatusName,
            this.tcStatus,
            this.tcLablePower,
            this.txAddDate});
            this.dg_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_List.Location = new System.Drawing.Point (0, 0);
            this.dg_List.Name = "dg_List";
            this.dg_List.RowHeadersVisible = false;
            this.dg_List.RowTemplate.Height = 23;
            this.dg_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_List.Size = new System.Drawing.Size (620, 149);
            this.dg_List.TabIndex = 0;
            this.dg_List.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler (this.dg_List_CellDoubleClick);
            this.dg_List.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler (this.dg_List_DataBindingComplete);
            // 
            // chkLabelID
            // 
            this.chkLabelID.Frozen = true;
            this.chkLabelID.HeaderText = "选择";
            this.chkLabelID.Name = "chkLabelID";
            this.chkLabelID.Width = 60;
            // 
            // txlabelNumber
            // 
            this.txlabelNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txlabelNumber.DataPropertyName = "LabelNumber";
            this.txlabelNumber.HeaderText = "编号";
            this.txlabelNumber.Name = "txlabelNumber";
            this.txlabelNumber.ReadOnly = true;
            // 
            // txLabelName
            // 
            this.txLabelName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txLabelName.DataPropertyName = "LabelName";
            this.txLabelName.HeaderText = "名称";
            this.txLabelName.Name = "txLabelName";
            this.txLabelName.ReadOnly = true;
            // 
            // tcStatusName
            // 
            this.tcStatusName.HeaderText = "当前状态";
            this.tcStatusName.Name = "tcStatusName";
            this.tcStatusName.ReadOnly = true;
            // 
            // tcStatus
            // 
            this.tcStatus.DataPropertyName = "Status";
            this.tcStatus.HeaderText = "当前状态";
            this.tcStatus.Name = "tcStatus";
            this.tcStatus.ReadOnly = true;
            this.tcStatus.Visible = false;
            // 
            // tcLablePower
            // 
            this.tcLablePower.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcLablePower.DataPropertyName = "Power";
            this.tcLablePower.HeaderText = "功率";
            this.tcLablePower.Name = "tcLablePower";
            this.tcLablePower.ReadOnly = true;
            // 
            // txAddDate
            // 
            this.txAddDate.DataPropertyName = "AddDate";
            this.txAddDate.HeaderText = "添加时间";
            this.txAddDate.Name = "txAddDate";
            this.txAddDate.ReadOnly = true;
            this.txAddDate.Width = 160;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point (464, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size (83, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler (this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add (this.panel3);
            this.groupBox2.Controls.Add (this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point (0, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size (626, 226);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "标签信息列表";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add (this.uC_Label1);
            this.groupBox1.Controls.Add (this.txtSearch);
            this.groupBox1.Controls.Add (this.btnSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point (0, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size (626, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检索区域";
            // 
            // uC_Label1
            // 
            this.uC_Label1.AutoSize = true;
            this.uC_Label1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uC_Label1.Location = new System.Drawing.Point (24, 25);
            this.uC_Label1.Name = "uC_Label1";
            this.uC_Label1.Size = new System.Drawing.Size (142, 19);
            this.uC_Label1.TabIndex = 4;
            this.uC_Label1.Text = "标签名称或编号";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point (172, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Size = new System.Drawing.Size (258, 30);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextValue = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add (this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point (0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size (626, 47);
            this.panel1.TabIndex = 3;
            // 
            // fm_LabelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (626, 331);
            this.Controls.Add (this.groupBox2);
            this.Controls.Add (this.groupBox1);
            this.Controls.Add (this.panel1);
            this.Name = "fm_LabelList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "标签列表";
            this.Load += new System.EventHandler (this.fm_LabelList_Load);
            this.panel2.ResumeLayout (false);
            this.panel3.ResumeLayout (false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_List)).EndInit ( );
            this.groupBox2.ResumeLayout (false);
            this.groupBox1.ResumeLayout (false);
            this.groupBox1.PerformLayout ( );
            this.panel1.ResumeLayout (false);
            this.ResumeLayout (false);

		}

		#endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn AddDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dg_List;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private UserTextBox txtSearch;
        private UC_Label uC_Label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkLabelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txlabelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn txLabelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcLablePower;
        private System.Windows.Forms.DataGridViewTextBoxColumn txAddDate;

    }
}