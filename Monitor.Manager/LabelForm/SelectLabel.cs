using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Monitor.Component.BLL;
using Monitor.Component.Model;
using Monitor.Manager.StudentForm;
using Monitor.Component;

namespace Monitor.Manager.LabelForm
{
	public partial class SelectLabel : Form
	{
		List<Labels> oList = new List<Labels>( );

		public SelectLabel ( )
		{
			InitializeComponent( );
			dgList.AutoGenerateColumns = false;
		}

		private void btnSearch_Click (object sender , EventArgs e)
		{
			oList = LabelManager.GetLabelsByCondition( " iStatus=" + ( int )StaticValue.LabelStatus.正常 );
			this.dgList.DataSource = oList;
		}

		private void dgList_CellDoubleClick (object sender , DataGridViewCellEventArgs e)
		{
			try
			{
				//如果当前有选中行，则返回选中行
				if ( this.dgList.SelectedRows.Count > 0 )
				{
					SaveGoods.LabelInfo = oList.Find( info => info.LabelNumber == this.dgList.SelectedRows[0].Cells["tcLabelNumber"].Value.ToString( ) );
					this.Close( );
				}
			}
			catch ( Exception ex )
			{
				MessageBox.Show( ex.Message );
			}
		}

		private void btnCancel_Click (object sender , EventArgs e)
		{
			this.Close( );
		}

		private void btnOK_Click (object sender , EventArgs e)
		{
			try
			{
				if ( this.dgList.SelectedRows.Count > 0 )
				{
					//返回选中行的学生信息
					SaveGoods.LabelInfo = oList.Find( info => info.LabelNumber == this.dgList.SelectedRows[0].Cells["tcLabelNumber"].Value.ToString( ) );

					this.Close( );
				}
				else
				{
					MessageBox.Show( this , "请至少选中一条标签信息。" , "警告" , MessageBoxButtons.OK , MessageBoxIcon.Warning );
				}
			}
			catch ( Exception ex )
			{
				MessageBox.Show( ex.Message );
			}
		}
	}
}
