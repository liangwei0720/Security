using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Monitor.Manager
{
	/// <summary>
	/// 公共窗体的基类
	/// </summary>
	public class BaseForm : Form
	{
		/// <summary>
		/// 关闭其它的子窗体,并将当前的窗体显示出来
		/// </summary>
		/// <param name="form"></param>
		protected void CloseOtherActiveFormAndShowCurrentForm(Form form, Form CurrentForm)
		{
			if ( form.IsMdiContainer && form.MdiChildren.Length > 0 )
			{
				form.ActiveMdiChild.Close( );
			}
			
			CurrentForm.Show( );
			
		}

		/// <summary>
		/// 激活当前窗体
		/// </summary>
		/// <param name="form"></param>
		/// <param name="currentForm"></param>
		protected void ActiveCurrentForm(Form form, Form currentForm)
		{
			if ( form.MdiChildren.Contains(currentForm) )
			{
				currentForm.Activate( );
			}

			currentForm.Show( );
		}

		private void InitializeComponent( )
		{
			this.SuspendLayout();
			// 
			// BaseForm
			// 
			//this.ClientSize = new System.Drawing.Size(284, 262);
			this.Name = "BaseForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);

		}
	}
}
