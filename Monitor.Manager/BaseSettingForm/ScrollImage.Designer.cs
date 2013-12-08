namespace Monitor.Manager.BaseSettingForm
{
    partial class ScrollImage
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
            this.groupBox2 = new System.Windows.Forms.GroupBox ( );
            this.panel3 = new System.Windows.Forms.Panel ( );
            this.dgList = new System.Windows.Forms.DataGridView ( );
            this.tcCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn ( );
            this.tcImageName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcImage = new System.Windows.Forms.DataGridViewImageColumn ( );
            this.tcUpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcID = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.panel2 = new System.Windows.Forms.Panel ( );
            this.btnAdd = new System.Windows.Forms.Button ( );
            this.btnDel = new System.Windows.Forms.Button ( );
            this.btnEdit = new System.Windows.Forms.Button ( );
            this.panel1 = new System.Windows.Forms.Panel ( );
            this.label1 = new System.Windows.Forms.Label ( );
            this.btnUpdateToClient = new System.Windows.Forms.Button ( );
            this.groupBox2.SuspendLayout ( );
            this.panel3.SuspendLayout ( );
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit ( );
            this.panel2.SuspendLayout ( );
            this.panel1.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add (this.panel3);
            this.groupBox2.Controls.Add (this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point (0, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding (5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding (5);
            this.groupBox2.Size = new System.Drawing.Size (1303, 559);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "轮播信息列表";
            // 
            // panel3
            // 
            this.panel3.Controls.Add (this.dgList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point (5, 84);
            this.panel3.Margin = new System.Windows.Forms.Padding (5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size (1293, 470);
            this.panel3.TabIndex = 7;
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.AllowUserToOrderColumns = true;
            this.dgList.ColumnHeadersHeight = 32;
            this.dgList.Columns.AddRange (new System.Windows.Forms.DataGridViewColumn[] {
            this.tcCheck,
            this.tcImageName,
            this.tcImage,
            this.tcUpdateTime,
            this.tcID});
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.Location = new System.Drawing.Point (0, 0);
            this.dgList.Margin = new System.Windows.Forms.Padding (5);
            this.dgList.Name = "dgList";
            this.dgList.RowHeadersVisible = false;
            this.dgList.RowTemplate.Height = 23;
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size (1293, 470);
            this.dgList.TabIndex = 0;
            this.dgList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler (this.dgList_CellDoubleClick);
            // 
            // tcCheck
            // 
            this.tcCheck.HeaderText = "选择";
            this.tcCheck.Name = "tcCheck";
            this.tcCheck.Width = 60;
            // 
            // tcImageName
            // 
            this.tcImageName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcImageName.DataPropertyName = "ImageName";
            this.tcImageName.HeaderText = "图片名称";
            this.tcImageName.Name = "tcImageName";
            this.tcImageName.ReadOnly = true;
            // 
            // tcImage
            // 
            this.tcImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcImage.DataPropertyName = "ImageData";
            this.tcImage.HeaderText = "图片";
            this.tcImage.Name = "tcImage";
            this.tcImage.ReadOnly = true;
            // 
            // tcUpdateTime
            // 
            this.tcUpdateTime.DataPropertyName = "UpdateTime";
            this.tcUpdateTime.HeaderText = "更新时间";
            this.tcUpdateTime.Name = "tcUpdateTime";
            this.tcUpdateTime.ReadOnly = true;
            this.tcUpdateTime.Width = 160;
            // 
            // tcID
            // 
            this.tcID.DataPropertyName = "ID";
            this.tcID.HeaderText = "ID";
            this.tcID.Name = "tcID";
            this.tcID.ReadOnly = true;
            this.tcID.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add (this.btnAdd);
            this.panel2.Controls.Add (this.btnUpdateToClient);
            this.panel2.Controls.Add (this.btnDel);
            this.panel2.Controls.Add (this.btnEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point (5, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding (5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size (1293, 57);
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add (this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point (0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding (5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size (1303, 44);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point (0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (1303, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "轮播区信息管理";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateToClient
            // 
            this.btnUpdateToClient.Location = new System.Drawing.Point (532, 5);
            this.btnUpdateToClient.Margin = new System.Windows.Forms.Padding (5);
            this.btnUpdateToClient.Name = "btnUpdateToClient";
            this.btnUpdateToClient.Size = new System.Drawing.Size (254, 48);
            this.btnUpdateToClient.TabIndex = 5;
            this.btnUpdateToClient.Text = "将当前信息更新到客户端";
            this.btnUpdateToClient.UseVisualStyleBackColor = true;
            this.btnUpdateToClient.Click += new System.EventHandler (this.btnUpdateToClient_Click);
            // 
            // ScrollImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (1303, 603);
            this.Controls.Add (this.groupBox2);
            this.Controls.Add (this.panel1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding (5);
            this.Name = "ScrollImage";
            this.Text = "轮播区信息管理";
            this.Load += new System.EventHandler (this.ScrollImage_Load);
            this.groupBox2.ResumeLayout (false);
            this.panel3.ResumeLayout (false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit ( );
            this.panel2.ResumeLayout (false);
            this.panel1.ResumeLayout (false);
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tcCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcImageName;
        private System.Windows.Forms.DataGridViewImageColumn tcImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcUpdateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcID;
        private System.Windows.Forms.Button btnUpdateToClient;
    }
}