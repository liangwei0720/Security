using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monitor.Manager
{
    public partial class UserTextBox : UserControl
    {
        public UserTextBox ( )
        {

            InitializeComponent ( );

            this.textBox1.Font = new System.Drawing.Font ("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
           
        }

        protected override void OnLoad ( EventArgs e )
        { 
            if ((int)this.PasswordChar != 0)
            {
                this.textBox1.PasswordChar = '*';
            }
            base.OnLoad (e);
        }

        private void textBox1_MouseEnter ( object sender, EventArgs e )
        {

        }

        void textBox1_LostFocus ( object sender, System.EventArgs e )
        {
            this.textBox1.BackColor = Color.White;
        }

        private void textBox1_Enter ( object sender, EventArgs e )
        {
            this.textBox1.BackColor = Color.Yellow;
        }

        public string TextValue
        {
            get
            {
                return this.textBox1.Text.Trim ( );
            }
            set
            {
                this.textBox1.Text = value;
            }
        }

        public bool IsMultiLine
        {
            set
            {
                this.textBox1.Multiline = value;
            }
        }

        public char PasswordChar
        {
            get;
            set;
        }
    }
}
