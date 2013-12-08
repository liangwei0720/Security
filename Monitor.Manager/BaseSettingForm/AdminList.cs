using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Monitor.Component.BLL;

namespace Monitor.Manager.BaseSettingForm
{
    public partial class AdminList : Form
    {
        public AdminList ( )
        {
            InitializeComponent ( );
        }

        private void btnAdd_Click ( object sender, EventArgs e )
        {
            AdminSave oAdminSave = new AdminSave ( );

            oAdminSave.ShowDialog ( );

            dgList.DataSource = AdminManage.GetAllAdmin ( );
        }

        private void AdminList_Load ( object sender, EventArgs e )
        {
            this.dgList.AutoGenerateColumns = false;
            dgList.DataSource = AdminManage.GetAllAdmin ( );
        }

        private void btnEdit_Click ( object sender, EventArgs e )
        {
            if (this.dgList.SelectedRows.Count == 0)
            {
                CommonMethod.ShowWaringMessage ("请选择要编辑的项");
                return;
            }
            AdminSave oAdminSave = new AdminSave ( ) { AdminID = (int)this.dgList.SelectedRows[0].Cells["tcAdminID"].Value };

            oAdminSave.ShowDialog ( );

            dgList.DataSource = AdminManage.GetAllAdmin ( );
        }

        private void btnDel_Click ( object sender, EventArgs e )
        {
            if (DialogResult.No == MessageBox.Show ("确定要删除选择的行吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                return;
            }
            if (this.dgList.SelectedRows.Count == 0)
            {
                CommonMethod.ShowWaringMessage ("请选择要删除的项");
                return;
            }

            string LandName = this.dgList.SelectedRows[0].Cells["tcLandName"].Value.ToString ( );

            if (string.Compare ("admin", LandName, true) == 0)
            {
                CommonMethod.ShowWaringMessage ("超级管理员不能删除");
                return;
            }

            AdminManage.DeleteAdmin ((int)this.dgList.SelectedRows[0].Cells["tcAdminID"].Value);
            dgList.DataSource = AdminManage.GetAllAdmin ( );
            CommonMethod.ShowWaringMessage ("信息已删除");
        }

        private void dgList_CellDoubleClick ( object sender, DataGridViewCellEventArgs e )
        {
            AdminSave oAdminSave = new AdminSave ( ) { AdminID = (int)this.dgList.SelectedRows[0].Cells["tcAdminID"].Value };

            oAdminSave.ShowDialog ( );

            dgList.DataSource = AdminManage.GetAllAdmin ( );
        }
    }
}
