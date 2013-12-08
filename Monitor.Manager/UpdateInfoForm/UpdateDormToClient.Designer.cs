namespace Monitor.Manager.UpdateInfoForm
{
	partial class UpdateDormToClient
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboxDorm = new System.Windows.Forms.ComboBox();
			this.comboxClient = new System.Windows.Forms.ComboBox();
			this.btnAddToDB = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgList = new System.Windows.Forms.DataGridView();
			this.tcCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.tcDormName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tcDormFlools = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tcDormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1370, 74);
			this.label1.TabIndex = 1;
			this.label1.Text = "更新信息到客户端";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboxDorm);
			this.groupBox1.Controls.Add(this.comboxClient);
			this.groupBox1.Controls.Add(this.btnAddToDB);
			this.groupBox1.Controls.Add(this.btnOk);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 74);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox1.Size = new System.Drawing.Size(1370, 89);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "条件选择区域";
			// 
			// comboxDorm
			// 
			this.comboxDorm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboxDorm.FormattingEnabled = true;
			this.comboxDorm.Location = new System.Drawing.Point(433, 33);
			this.comboxDorm.Margin = new System.Windows.Forms.Padding(5);
			this.comboxDorm.Name = "comboxDorm";
			this.comboxDorm.Size = new System.Drawing.Size(227, 27);
			this.comboxDorm.TabIndex = 4;
			// 
			// comboxClient
			// 
			this.comboxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboxClient.FormattingEnabled = true;
			this.comboxClient.Location = new System.Drawing.Point(115, 33);
			this.comboxClient.Margin = new System.Windows.Forms.Padding(5);
			this.comboxClient.Name = "comboxClient";
			this.comboxClient.Size = new System.Drawing.Size(227, 27);
			this.comboxClient.TabIndex = 4;
			// 
			// btnAddToDB
			// 
			this.btnAddToDB.Location = new System.Drawing.Point(886, 27);
			this.btnAddToDB.Margin = new System.Windows.Forms.Padding(5);
			this.btnAddToDB.Name = "btnAddToDB";
			this.btnAddToDB.Size = new System.Drawing.Size(286, 36);
			this.btnAddToDB.TabIndex = 2;
			this.btnAddToDB.Text = "更新当前数据到指定的客户端";
			this.btnAddToDB.UseVisualStyleBackColor = true;
			this.btnAddToDB.Visible = false;
			this.btnAddToDB.Click += new System.EventHandler(this.btnAddToDB_Click);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(721, 27);
			this.btnOk.Margin = new System.Windows.Forms.Padding(5);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(125, 36);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "查询数据";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 40);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "客户端";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(387, 36);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "公寓";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel3);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 163);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox2.Size = new System.Drawing.Size(1370, 464);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "信息列表";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgList);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(5, 27);
			this.panel3.Margin = new System.Windows.Forms.Padding(5);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1360, 432);
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
			dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcCheck,
            this.tcDormName,
            this.tcDormFlools,
            this.tcDormID});
			this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgList.Location = new System.Drawing.Point(0, 0);
			this.dgList.Margin = new System.Windows.Forms.Padding(5);
			this.dgList.MultiSelect = false;
			this.dgList.Name = "dgList";
			this.dgList.RowHeadersVisible = false;
			this.dgList.RowHeadersWidth = 32;
			this.dgList.RowTemplate.Height = 23;
			this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgList.Size = new System.Drawing.Size(1360, 432);
			this.dgList.TabIndex = 1;
			// 
			// tcCheck
			// 
			this.tcCheck.Frozen = true;
			this.tcCheck.HeaderText = "选择";
			this.tcCheck.Name = "tcCheck";
			this.tcCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.tcCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.tcCheck.Visible = false;
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
			this.tcDormFlools.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.tcDormFlools.DataPropertyName = "RoomNumber";
			this.tcDormFlools.HeaderText = "宿舍名称";
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
			// UpdateDormToClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 627);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "UpdateDormToClient";
			this.Text = "更新信息到客户端";
			this.Load += new System.EventHandler(this.UpdateDormToClient_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboxClient;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboxDorm;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnAddToDB;
		private System.Windows.Forms.DataGridView dgList;
		private System.Windows.Forms.DataGridViewCheckBoxColumn tcCheck;
		private System.Windows.Forms.DataGridViewTextBoxColumn tcDormName;
		private System.Windows.Forms.DataGridViewTextBoxColumn tcDormFlools;
		private System.Windows.Forms.DataGridViewTextBoxColumn tcDormID;
	}
}