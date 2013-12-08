namespace Monitor.Manager.RepealForm
{
    partial class RepealCard
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
            this.SuspendLayout ( );
            // 
            // RepealCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (284, 262);
            this.Name = "RepealCard";
            this.Text = "卡片销户";
            this.ResumeLayout (false);

        }

        #endregion
    }
}