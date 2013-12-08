using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Monitor.Component.Model;
using Monitor.Component.BLL;

namespace Monitor.Manager
{
	public partial class Login : Form
	{
		public bool IsAdmin { get; set; }
		public string AdminName { get; set; }
		public Login ( )
		{
			InitializeComponent( );
			
		}

		private void btnCancel_Click (object sender , EventArgs e)
		{
			Application.ExitThread( );
		}

		private void btnSubmit_Click (object sender , EventArgs e)
		{
			if ( this.txtLoginName.TextValue.Length == 0 )
			{
				CommonMethod.ShowWaringMessage( "请输入登录名" );
				this.txtLoginName.Focus( );

				return;
			}

			if ( this.txtLoginPwd.TextValue.Length == 0 )
			{
				CommonMethod.ShowWaringMessage( "请输入登录密码" );
				this.txtLoginPwd.Focus( );

				return;
			}

			Admin oAdmin = AdminManage.GetAdmin( this.txtLoginName.TextValue , this.txtLoginPwd.TextValue );
			if ( oAdmin == null )
			{
				CommonMethod.ShowWaringMessage( "你输入的用户或密码不正确" );
				return;
			}

			this.IsAdmin = string.Compare( "Admin" , oAdmin.LoginName , true ) == 0;
			this.AdminName = this.txtLoginName.TextValue;
			this.DialogResult = DialogResult.OK;

			this.Close( );

		}
	}
}
