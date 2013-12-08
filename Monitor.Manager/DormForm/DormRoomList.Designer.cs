namespace Monitor.Manager.DormForm
{
    partial class DormRoomList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle ( );
            this.btnDel = new System.Windows.Forms.Button ( );
            this.panel3 = new System.Windows.Forms.Panel ( );
            this.dgRoomsList = new System.Windows.Forms.DataGridView ( );
            this.panel2 = new System.Windows.Forms.Panel ( );
            this.btnAdd = new System.Windows.Forms.Button ( );
            this.btnEdit = new System.Windows.Forms.Button ( );
            this.groupBox2 = new System.Windows.Forms.GroupBox ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.cmbDorm = new System.Windows.Forms.ComboBox ( );
            this.txtRoomName = new Monitor.Manager.UserTextBox ( );
            this.btnSearch = new System.Windows.Forms.Button ( );
            this.label3 = new System.Windows.Forms.Label ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.label1 = new System.Windows.Forms.Label ( );
            this.panel1 = new System.Windows.Forms.Panel ( );
            this.tcCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn ( );
            this.tcDormName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcDormID = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.panel3.SuspendLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomsList)).BeginInit ( );
            this.panel2.SuspendLayout ( );
            this.groupBox2.SuspendLayout ( );
            this.groupBox1.SuspendLayout ( );
            this.panel1.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point (348, 4);
            this.btnDel.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size (125, 48);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler (this.btnDel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add (this.dgRoomsList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point (5, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size (1360, 451);
            this.panel3.TabIndex = 7;
            // 
            // dgRoomsList
            // 
            this.dgRoomsList.AllowUserToAddRows = false;
            this.dgRoomsList.AllowUserToDeleteRows = false;
            this.dgRoomsList.AllowUserToOrderColumns = true;
            this.dgRoomsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRoomsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgRoomsList.ColumnHeadersHeight = 32;
            this.dgRoomsList.Columns.AddRange (new System.Windows.Forms.DataGridViewColumn[] {
            this.tcCheck,
            this.tcDormName,
            this.tcRoomName,
            this.tcDormID,
            this.tcRoomID});
            this.dgRoomsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRoomsList.Location = new System.Drawing.Point (0, 0);
            this.dgRoomsList.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.dgRoomsList.MultiSelect = false;
            this.dgRoomsList.Name = "dgRoomsList";
            this.dgRoomsList.RowHeadersVisible = false;
            this.dgRoomsList.RowHeadersWidth = 32;
            this.dgRoomsList.RowTemplate.Height = 23;
            this.dgRoomsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRoomsList.Size = new System.Drawing.Size (1360, 451);
            this.dgRoomsList.TabIndex = 0;
            this.dgRoomsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler (this.dgRoomsList_CellDoubleClick);
            this.dgRoomsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler (this.dgRoomsList_DataBindingComplete);
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
            this.panel2.Size = new System.Drawing.Size (1360, 53);
            this.panel2.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point (15, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size (125, 48);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler (this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point (177, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size (125, 48);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler (this.btnEdit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add (this.panel3);
            this.groupBox2.Controls.Add (this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point (0, 96);
            this.groupBox2.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size (1370, 536);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "宿舍信息列表";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add (this.cmbDorm);
            this.groupBox1.Controls.Add (this.txtRoomName);
            this.groupBox1.Controls.Add (this.btnSearch);
            this.groupBox1.Controls.Add (this.label3);
            this.groupBox1.Controls.Add (this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point (0, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size (1370, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检索区域";
            // 
            // cmbDorm
            // 
            this.cmbDorm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDorm.FormattingEnabled = true;
            this.cmbDorm.Items.AddRange (new object[] {
            "全部"});
            this.cmbDorm.Location = new System.Drawing.Point (92, 24);
            this.cmbDorm.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.cmbDorm.Name = "cmbDorm";
            this.cmbDorm.Size = new System.Drawing.Size (199, 27);
            this.cmbDorm.TabIndex = 1;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point (448, 20);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size (502, 35);
            this.txtRoomName.TabIndex = 2;
            this.txtRoomName.TextValue = "";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point (1011, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size (125, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler (this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point (35, 28);
            this.label3.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (47, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "公寓";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (338, 28);
            this.label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "宿舍名称";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point (0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (1370, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "宿舍信息列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add (this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point (0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size (1370, 40);
            this.panel1.TabIndex = 3;
            // 
            // tcCheck
            // 
            this.tcCheck.HeaderText = "选择";
            this.tcCheck.Name = "tcCheck";
            this.tcCheck.Width = 60;
            // 
            // tcDormName
            // 
            this.tcDormName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcDormName.DataPropertyName = "DormID";
            this.tcDormName.HeaderText = "所属公寓";
            this.tcDormName.Name = "tcDormName";
            this.tcDormName.ReadOnly = true;
            // 
            // tcRoomName
            // 
            this.tcRoomName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcRoomName.DataPropertyName = "nvcRoomNumber";
            this.tcRoomName.HeaderText = "宿舍名称";
            this.tcRoomName.Name = "tcRoomName";
            this.tcRoomName.ReadOnly = true;
            // 
            // tcDormID
            // 
            this.tcDormID.DataPropertyName = "guDormID";
            this.tcDormID.HeaderText = "guDormID";
            this.tcDormID.Name = "tcDormID";
            this.tcDormID.Visible = false;
            // 
            // tcRoomID
            // 
            this.tcRoomID.DataPropertyName = "guRoomID";
            this.tcRoomID.HeaderText = "guRoomID";
            this.tcRoomID.Name = "tcRoomID";
            this.tcRoomID.Visible = false;
            // 
            // DormRoomList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (1370, 632);
            this.Controls.Add (this.groupBox2);
            this.Controls.Add (this.groupBox1);
            this.Controls.Add (this.panel1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.Name = "DormRoomList";
            this.Text = "宿舍列表";
            this.Load += new System.EventHandler (this.DormRoomList_Load);
            this.panel3.ResumeLayout (false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomsList)).EndInit ( );
            this.panel2.ResumeLayout (false);
            this.groupBox2.ResumeLayout (false);
            this.groupBox1.ResumeLayout (false);
            this.groupBox1.PerformLayout ( );
            this.panel1.ResumeLayout (false);
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgRoomsList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDorm;
        private UserTextBox txtRoomName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tcCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDormName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDormID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcRoomID;

    }
}