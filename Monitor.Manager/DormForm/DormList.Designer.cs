namespace Monitor.Manager.DormForm
{
    partial class DormList
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
            this.dgList = new System.Windows.Forms.DataGridView ( );
            this.panel2 = new System.Windows.Forms.Panel ( );
            this.btnAdd = new System.Windows.Forms.Button ( );
            this.btnDel = new System.Windows.Forms.Button ( );
            this.btnEdit = new System.Windows.Forms.Button ( );
            this.panel3 = new System.Windows.Forms.Panel ( );
            this.groupBox2 = new System.Windows.Forms.GroupBox ( );
            this.groupBox1 = new System.Windows.Forms.GroupBox ( );
            this.btnSearch = new System.Windows.Forms.Button ( );
            this.label2 = new System.Windows.Forms.Label ( );
            this.panel1 = new System.Windows.Forms.Panel ( );
            this.tcCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn ( );
            this.tcDormName = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcDormFlools = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.tcDormID = new System.Windows.Forms.DataGridViewTextBoxColumn ( );
            this.txtSearch = new Monitor.Manager.UserTextBox ( );
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit ( );
            this.panel2.SuspendLayout ( );
            this.panel3.SuspendLayout ( );
            this.groupBox2.SuspendLayout ( );
            this.groupBox1.SuspendLayout ( );
            this.panel1.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font ("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point (0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (1370, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "公寓信息列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tcDormName,
            this.tcDormFlools,
            this.tcDormID});
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.Location = new System.Drawing.Point (0, 0);
            this.dgList.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.dgList.MultiSelect = false;
            this.dgList.Name = "dgList";
            this.dgList.RowHeadersVisible = false;
            this.dgList.RowHeadersWidth = 32;
            this.dgList.RowTemplate.Height = 23;
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size (1360, 211);
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
            this.panel2.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size (1360, 57);
            this.panel2.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point (15, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
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
            this.btnDel.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
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
            this.btnEdit.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size (125, 48);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler (this.btnEdit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add (this.dgList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point (5, 84);
            this.panel3.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size (1360, 211);
            this.panel3.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add (this.panel3);
            this.groupBox2.Controls.Add (this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point (0, 115);
            this.groupBox2.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size (1370, 300);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "公寓信息列表";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add (this.txtSearch);
            this.groupBox1.Controls.Add (this.btnSearch);
            this.groupBox1.Controls.Add (this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point (0, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size (1370, 67);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检索区域";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point (676, 23);
            this.btnSearch.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size (125, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler (this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (36, 31);
            this.label2.Margin = new System.Windows.Forms.Padding (5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (85, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "检索条件";
            // 
            // panel1
            // 
            this.panel1.Controls.Add (this.label1);
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
            this.tcCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tcCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tcCheck.Width = 70;
            // 
            // tcDormName
            // 
            this.tcDormName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tcDormName.DataPropertyName = "DormNumber";
            this.tcDormName.HeaderText = "公寓名称";
            this.tcDormName.Name = "tcDormName";
            this.tcDormName.ReadOnly = true;
            // 
            // tcDormFlools
            // 
            this.tcDormFlools.DataPropertyName = "Flools";
            this.tcDormFlools.HeaderText = "总层数";
            this.tcDormFlools.Name = "tcDormFlools";
            this.tcDormFlools.ReadOnly = true;
            // 
            // tcDormID
            // 
            this.tcDormID.DataPropertyName = "DormID";
            this.tcDormID.HeaderText = "公寓ID";
            this.tcDormID.Name = "tcDormID";
            this.tcDormID.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point (134, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding (5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size (477, 35);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextValue = "";
            // 
            // DormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (1370, 415);
            this.Controls.Add (this.groupBox2);
            this.Controls.Add (this.groupBox1);
            this.Controls.Add (this.panel1);
            this.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding (5, 5, 5, 5);
            this.Name = "DormList";
            this.Text = "公寓列表";
            this.Load += new System.EventHandler (this.DormList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit ( );
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
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private UserTextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tcCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDormName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDormFlools;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDormID;


    }
}