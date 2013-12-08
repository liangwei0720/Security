namespace Monitor.Manager.BaseSettingForm
{
    partial class AdminList
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
            this.groupBox2 = new System.Windows.Forms.GroupBox ( );
            this.panel3 = new System.Windows.Forms.Panel ( );
            this.dgList = new System.Windows.Forms.DataGridView ( );
            this.panel2 = new System.Windows.Forms.Panel ( );
            this.btnAdd = new System.Windows.Forms.Button ( );
            this.btnDel = new System.Windows.Forms.Button ( );
            this.btnEdit = new System.Windows.Forms.Button ( );
            this.tcCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn ( );
            this.tcAdminID = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcLandName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcPwd = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.groupBox2.SuspendLayout ( );
            this.panel3.SuspendLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit ( );
            this.panel2.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point (0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (1370, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "管理员信息列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add (this.panel3);
            this.groupBox2.Controls.Add (this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point (0, 51);
            this.groupBox2.Margin = new System.Windows.Forms.Padding (5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding (5);
            this.groupBox2.Size = new System.Drawing.Size (1370, 541);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "管理员列表";
            // 
            // panel3
            // 
            this.panel3.Controls.Add (this.dgList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point (5, 85);
            this.panel3.Margin = new System.Windows.Forms.Padding (5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size (1360, 451);
            this.panel3.TabIndex = 7;
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.AllowUserToOrderColumns = true;
            this.dgList.AllowUserToResizeColumns = false;
            this.dgList.AllowUserToResizeRows = false;
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
            this.tcCheck,
            this.tcAdminID,
            this.tcLandName,
            this.tcPwd});
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.Location = new System.Drawing.Point (0, 0);
            this.dgList.Margin = new System.Windows.Forms.Padding (5);
            this.dgList.MultiSelect = false;
            this.dgList.Name = "dgList";
            this.dgList.RowHeadersVisible = false;
            this.dgList.RowTemplate.Height = 23;
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size (1360, 451);
            this.dgList.TabIndex = 0;
            this.dgList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler (this.dgList_CellDoubleClick);
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
            this.panel2.Size = new System.Drawing.Size (1360, 58);
            this.panel2.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point (15, 5);
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
            this.btnDel.Location = new System.Drawing.Point (348, 5);
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
            this.btnEdit.Location = new System.Drawing.Point (177, 5);
            this.btnEdit.Margin = new System.Windows.Forms.Padding (5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size (125, 48);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler (this.btnEdit_Click);
            // 
            // tcCheck
            // 
            this.tcCheck.HeaderText = "选择";
            this.tcCheck.Name = "tcCheck";
            this.tcCheck.ReadOnly = true;
            this.tcCheck.Visible = false;
            this.tcCheck.Width = 70;
            // 
            // tcAdminID
            // 
            this.tcAdminID.DataPropertyName = "AdminID";
            this.tcAdminID.HeaderText = "标识";
            this.tcAdminID.Name = "tcAdminID";
            this.tcAdminID.ReadOnly = true;
            // 
            // tcLandName
            // 
            this.tcLandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcLandName.DataPropertyName = "LoginName";
            this.tcLandName.HeaderText = "登录名";
            this.tcLandName.Name = "tcLandName";
            this.tcLandName.ReadOnly = true;
            // 
            // tcPwd
            // 
            this.tcPwd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcPwd.DataPropertyName = "PWD";
            this.tcPwd.HeaderText = "密码";
            this.tcPwd.Name = "tcPwd";
            this.tcPwd.ReadOnly = true;
            // 
            // AdminList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (1370, 592);
            this.Controls.Add (this.groupBox2);
            this.Controls.Add (this.label1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding (5);
            this.Name = "AdminList";
            this.Text = "管理员列表";
            this.Load += new System.EventHandler (this.AdminList_Load);
            this.groupBox2.ResumeLayout (false);
            this.panel3.ResumeLayout (false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit ( );
            this.panel2.ResumeLayout (false);
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tcCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcAdminID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcLandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcPwd;


    }
}