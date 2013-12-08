namespace Monitor.Manager.StudentForm
{
    partial class GoodsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle ( );
            this.label1 = new System.Windows.Forms.Label ( );
            this.dgGoodsList = new System.Windows.Forms.DataGridView ( );
            this.panel2 = new System.Windows.Forms.Panel ( );
            this.btnAdd = new System.Windows.Forms.Button ( );
            this.btnDel = new System.Windows.Forms.Button ( );
            this.btnEdit = new System.Windows.Forms.Button ( );
            this.panel3 = new System.Windows.Forms.Panel ( );
            this.groupBox2 = new System.Windows.Forms.GroupBox ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.cmbDormRoom = new System.Windows.Forms.ComboBox ( );
            this.cmbDorm = new System.Windows.Forms.ComboBox ( );
            this.txtGoodsName = new Monitor.Manager.UserTextBox ( );
            this.btnSearch = new System.Windows.Forms.Button ( );
            this.label4 = new System.Windows.Forms.Label ( );
            this.label3 = new System.Windows.Forms.Label ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.panel1 = new System.Windows.Forms.Panel ( );
            this.tcCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn ( );
            this.goodsIndex = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcGoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcBrand = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcModel = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.labelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.studuentName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcAddDate = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcGoodsID = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.studentRealNumber = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            ((System.ComponentModel.ISupportInitialize)(this.dgGoodsList)).BeginInit ( );
            this.panel2.SuspendLayout ( );
            this.panel3.SuspendLayout ( );
            this.groupBox2.SuspendLayout ( );
            this.groupBox1.SuspendLayout ( );
            this.panel1.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point (0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (1370, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生物品信息列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgGoodsList
            // 
            this.dgGoodsList.AllowUserToAddRows = false;
            this.dgGoodsList.AllowUserToDeleteRows = false;
            this.dgGoodsList.AllowUserToOrderColumns = true;
            this.dgGoodsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgGoodsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgGoodsList.ColumnHeadersHeight = 32;
            this.dgGoodsList.Columns.AddRange (new System.Windows.Forms.DataGridViewColumn[] {
            this.tcCheck,
            this.goodsIndex,
            this.tcGoodsName,
            this.tcBrand,
            this.tcModel,
            this.labelNumber,
            this.studuentName,
            this.tcAddDate,
            this.tcInvoice,
            this.tcGoodsID,
            this.studentRealNumber});
            this.dgGoodsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgGoodsList.Location = new System.Drawing.Point (0, 0);
            this.dgGoodsList.Margin = new System.Windows.Forms.Padding (5);
            this.dgGoodsList.Name = "dgGoodsList";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgGoodsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgGoodsList.RowHeadersVisible = false;
            this.dgGoodsList.RowTemplate.Height = 23;
            this.dgGoodsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgGoodsList.Size = new System.Drawing.Size (1360, 386);
            this.dgGoodsList.TabIndex = 0;
            this.dgGoodsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler (this.dgGoodsList_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add (this.btnAdd);
            this.panel2.Controls.Add (this.btnDel);
            this.panel2.Controls.Add (this.btnEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point (5, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding (5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size (1360, 53);
            this.panel2.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point (15, 3);
            this.btnAdd.Margin = new System.Windows.Forms.Padding (5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size (125, 48);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler (this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point (348, 3);
            this.btnDel.Margin = new System.Windows.Forms.Padding (5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size (125, 48);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler (this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point (177, 3);
            this.btnEdit.Margin = new System.Windows.Forms.Padding (5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size (125, 48);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler (this.btnEdit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add (this.dgGoodsList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point (5, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding (5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size (1360, 386);
            this.panel3.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add (this.panel3);
            this.groupBox2.Controls.Add (this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point (0, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding (5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding (5);
            this.groupBox2.Size = new System.Drawing.Size (1370, 471);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学生物品信息列表";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add (this.cmbDormRoom);
            this.groupBox1.Controls.Add (this.cmbDorm);
            this.groupBox1.Controls.Add (this.txtGoodsName);
            this.groupBox1.Controls.Add (this.btnSearch);
            this.groupBox1.Controls.Add (this.label4);
            this.groupBox1.Controls.Add (this.label3);
            this.groupBox1.Controls.Add (this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point (0, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding (5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding (5);
            this.groupBox1.Size = new System.Drawing.Size (1370, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检索区域";
            // 
            // cmbDormRoom
            // 
            this.cmbDormRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDormRoom.FormattingEnabled = true;
            this.cmbDormRoom.Location = new System.Drawing.Point (334, 20);
            this.cmbDormRoom.Name = "cmbDormRoom";
            this.cmbDormRoom.Size = new System.Drawing.Size (152, 27);
            this.cmbDormRoom.TabIndex = 4;
            this.cmbDormRoom.SelectedIndexChanged += new System.EventHandler (this.cmbDormRoom_SelectedIndexChanged);
            // 
            // cmbDorm
            // 
            this.cmbDorm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDorm.FormattingEnabled = true;
            this.cmbDorm.Location = new System.Drawing.Point (86, 20);
            this.cmbDorm.Name = "cmbDorm";
            this.cmbDorm.Size = new System.Drawing.Size (172, 27);
            this.cmbDorm.TabIndex = 4;
            this.cmbDorm.SelectedIndexChanged += new System.EventHandler (this.cmbDorm_SelectedIndexChanged);
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point (581, 18);
            this.txtGoodsName.Margin = new System.Windows.Forms.Padding (5);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.PasswordChar = '\0';
            this.txtGoodsName.Size = new System.Drawing.Size (266, 35);
            this.txtGoodsName.TabIndex = 3;
            this.txtGoodsName.TextValue = "";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point (992, 14);
            this.btnSearch.Margin = new System.Windows.Forms.Padding (5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size (125, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler (this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point (266, 23);
            this.label4.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size (66, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "房间号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point (31, 23);
            this.label3.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (47, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "公寓";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (494, 23);
            this.label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "物品名称";
            // 
            // panel1
            // 
            this.panel1.Controls.Add (this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point (0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding (5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size (1370, 44);
            this.panel1.TabIndex = 3;
            // 
            // tcCheck
            // 
            this.tcCheck.HeaderText = "选择";
            this.tcCheck.Name = "tcCheck";
            this.tcCheck.Width = 60;
            // 
            // goodsIndex
            // 
            this.goodsIndex.DataPropertyName = "GoodsIndex";
            this.goodsIndex.HeaderText = "序号";
            this.goodsIndex.Name = "goodsIndex";
            this.goodsIndex.Width = 60;
            // 
            // tcGoodsName
            // 
            this.tcGoodsName.DataPropertyName = "GoodsName";
            this.tcGoodsName.HeaderText = "物品名称";
            this.tcGoodsName.Name = "tcGoodsName";
            this.tcGoodsName.ReadOnly = true;
            this.tcGoodsName.Width = 203;
            // 
            // tcBrand
            // 
            this.tcBrand.DataPropertyName = "Brand";
            this.tcBrand.HeaderText = "品牌";
            this.tcBrand.Name = "tcBrand";
            this.tcBrand.ReadOnly = true;
            this.tcBrand.Width = 203;
            // 
            // tcModel
            // 
            this.tcModel.DataPropertyName = "Model";
            this.tcModel.HeaderText = "型号";
            this.tcModel.Name = "tcModel";
            this.tcModel.ReadOnly = true;
            this.tcModel.Width = 203;
            // 
            // labelNumber
            // 
            this.labelNumber.DataPropertyName = "LabelNumber";
            this.labelNumber.HeaderText = "对应标签";
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.ReadOnly = true;
            // 
            // studuentName
            // 
            this.studuentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studuentName.DataPropertyName = "AllInfo";
            this.studuentName.HeaderText = "学生学号";
            this.studuentName.Name = "studuentName";
            this.studuentName.ReadOnly = true;
            // 
            // tcAddDate
            // 
            this.tcAddDate.DataPropertyName = "AddDate";
            this.tcAddDate.HeaderText = "添加时间";
            this.tcAddDate.Name = "tcAddDate";
            this.tcAddDate.ReadOnly = true;
            this.tcAddDate.Width = 230;
            // 
            // tcInvoice
            // 
            this.tcInvoice.DataPropertyName = "Invoice";
            this.tcInvoice.HeaderText = "发票";
            this.tcInvoice.Name = "tcInvoice";
            this.tcInvoice.ReadOnly = true;
            this.tcInvoice.Width = 80;
            // 
            // tcGoodsID
            // 
            this.tcGoodsID.DataPropertyName = "GoodsID";
            this.tcGoodsID.HeaderText = "GoodsID";
            this.tcGoodsID.Name = "tcGoodsID";
            this.tcGoodsID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tcGoodsID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tcGoodsID.Visible = false;
            // 
            // studentRealNumber
            // 
            this.studentRealNumber.DataPropertyName = "StudentNumber";
            this.studentRealNumber.HeaderText = "学生真实学号";
            this.studentRealNumber.Name = "studentRealNumber";
            this.studentRealNumber.Visible = false;
            // 
            // GoodsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (1370, 573);
            this.Controls.Add (this.groupBox2);
            this.Controls.Add (this.groupBox1);
            this.Controls.Add (this.panel1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding (5);
            this.Name = "GoodsList";
            this.Text = "学生物品列表";
            this.Load += new System.EventHandler (this.GoodsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGoodsList)).EndInit ( );
            this.panel2.ResumeLayout (false);
            this.panel3.ResumeLayout (false);
            this.groupBox2.ResumeLayout (false);
            this.groupBox1.ResumeLayout (false);
            this.groupBox1.PerformLayout ( );
            this.panel1.ResumeLayout (false);
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgGoodsList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private UserTextBox txtGoodsName;
        private System.Windows.Forms.ComboBox cmbDormRoom;
        private System.Windows.Forms.ComboBox cmbDorm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tcCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcGoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn studuentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcAddDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcGoodsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentRealNumber;

    }
}