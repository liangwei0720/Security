namespace Monitor.Manager.BaseSettingForm
{
	partial class FacultiesList
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
			this.dgFaculties = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgFaculties)).BeginInit();
			this.SuspendLayout();
			// 
			// dgFaculties
			// 
			this.dgFaculties.AllowUserToAddRows = false;
			this.dgFaculties.AllowUserToDeleteRows = false;
			this.dgFaculties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgFaculties.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgFaculties.Location = new System.Drawing.Point(0, 0);
			this.dgFaculties.Name = "dgFaculties";
			this.dgFaculties.RowTemplate.Height = 23;
			this.dgFaculties.Size = new System.Drawing.Size(284, 262);
			this.dgFaculties.TabIndex = 0;
			// 
			// FacultiesList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.dgFaculties);
			this.Name = "FacultiesList";
			this.Text = "FacultiesList";
			this.Load += new System.EventHandler(this.FacultiesList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgFaculties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgFaculties;
	}
}