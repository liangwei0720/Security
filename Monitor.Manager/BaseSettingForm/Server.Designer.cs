namespace Monitor.Manager.BaseSettingForm
{
    partial class Server
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle ( );
            this.label1 = new System.Windows.Forms.Label ( );
            this.panel1 = new System.Windows.Forms.Panel ( );
            this.panel2 = new System.Windows.Forms.Panel ( );
            this.btnAdd = new System.Windows.Forms.Button ( );
            this.btnDel = new System.Windows.Forms.Button ( );
            this.btnEdit = new System.Windows.Forms.Button ( );
            this.panel3 = new System.Windows.Forms.Panel ( );
            this.dataGridView1 = new System.Windows.Forms.DataGridView ( );
            this.groupBox2 = new System.Windows.Forms.GroupBox ( );
            this.tcCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn ( );
            this.tcDorm = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcServerName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcIP = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcLastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcSuccess = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcStatus = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcServerID = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcDormID = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.panel1.SuspendLayout ( );
            this.panel2.SuspendLayout ( );
            this.panel3.SuspendLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit ( );
            this.groupBox2.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point (0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (1370, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add (this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point (0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size (1370, 49);
            this.panel1.TabIndex = 3;
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
            this.panel2.Size = new System.Drawing.Size (1360, 48);
            this.panel2.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point (15, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size (125, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler (this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point (348, 4);
            this.btnDel.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size (125, 40);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler (this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point (177, 4);
            this.btnEdit.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size (125, 40);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler (this.btnEdit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add (this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point (5, 75);
            this.panel3.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size (1360, 484);
            this.panel3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.Columns.AddRange (new System.Windows.Forms.DataGridViewColumn[] {
            this.tcCheck,
            this.tcDorm,
            this.tcServerName,
            this.tcIP,
            this.tcLastUpdate,
            this.tcSuccess,
            this.tcStatus,
            this.tcServerID,
            this.tcDormID});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point (0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size (1360, 484);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler (this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler (this.dataGridView1_DataBindingComplete);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add (this.panel3);
            this.groupBox2.Controls.Add (this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point (0, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size (1370, 564);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "服务器信息列表";
            // 
            // tcCheck
            // 
            this.tcCheck.HeaderText = "选择";
            this.tcCheck.Name = "tcCheck";
            this.tcCheck.Width = 60;
            // 
            // tcDorm
            // 
            this.tcDorm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcDorm.HeaderText = "所在公寓";
            this.tcDorm.Name = "tcDorm";
            this.tcDorm.ReadOnly = true;
            // 
            // tcServerName
            // 
            this.tcServerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcServerName.DataPropertyName = "ServerName";
            this.tcServerName.HeaderText = "名称";
            this.tcServerName.Name = "tcServerName";
            this.tcServerName.ReadOnly = true;
            // 
            // tcIP
            // 
            this.tcIP.DataPropertyName = "IP";
            this.tcIP.HeaderText = "IP";
            this.tcIP.Name = "tcIP";
            this.tcIP.ReadOnly = true;
            // 
            // tcLastUpdate
            // 
            this.tcLastUpdate.DataPropertyName = "LastUpdate";
            this.tcLastUpdate.HeaderText = "最后更新时间";
            this.tcLastUpdate.Name = "tcLastUpdate";
            this.tcLastUpdate.ReadOnly = true;
            this.tcLastUpdate.Width = 160;
            // 
            // tcSuccess
            // 
            this.tcSuccess.DataPropertyName = "IsSuccess";
            this.tcSuccess.HeaderText = "状态";
            this.tcSuccess.Name = "tcSuccess";
            this.tcSuccess.ReadOnly = true;
            this.tcSuccess.Visible = false;
            // 
            // tcStatus
            // 
            this.tcStatus.HeaderText = "状态";
            this.tcStatus.Name = "tcStatus";
            this.tcStatus.ReadOnly = true;
            // 
            // tcServerID
            // 
            this.tcServerID.DataPropertyName = "ServerID";
            this.tcServerID.HeaderText = "ServerID";
            this.tcServerID.Name = "tcServerID";
            this.tcServerID.Visible = false;
            // 
            // tcDormID
            // 
            this.tcDormID.DataPropertyName = "guDormID";
            this.tcDormID.HeaderText = "tcDormID";
            this.tcDormID.Name = "tcDormID";
            this.tcDormID.Visible = false;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (1370, 613);
            this.Controls.Add (this.groupBox2);
            this.Controls.Add (this.panel1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.Name = "Server";
            this.Text = "服务器列表";
            this.Load += new System.EventHandler (this.Server_Load);
            this.panel1.ResumeLayout (false);
            this.panel2.ResumeLayout (false);
            this.panel3.ResumeLayout (false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit ( );
            this.groupBox2.ResumeLayout (false);
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tcCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDorm;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcLastUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcSuccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcServerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDormID;


    }
}