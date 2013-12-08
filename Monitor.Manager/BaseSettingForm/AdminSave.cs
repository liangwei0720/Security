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

namespace Monitor.Manager.BaseSettingForm
{
    public partial class AdminSave : Form
    {
        public int AdminID;
        Admin oAdmin = null;
        public AdminSave ( )
        {
            InitializeComponent ( );
        }

        private void AdminSave_Load ( object sender, EventArgs e )
        {
            if (AdminID > 0)
            {
                oAdmin = AdminManage.GetAdmin (AdminID);

                txtLandName.TextValue = oAdmin.LoginName;
                txtLandName.Enabled = false;
                txtPWD.TextValue = oAdmin.PWD;
            }
        }

        private void btnAdd_Click ( object sender, EventArgs e )
        {
            if (txtLandName.TextValue.Length == 0)
            {
                CommonMethod.ShowWaringMessage ("登录名不能为空");
                txtLandName.Focus ( );
                return;
            }

            if (txtPWD.TextValue.Length == 0)
            {
                CommonMethod.ShowWaringMessage ("密码");
                txtPWD.Focus ( );
                return;
            }
            if (AdminID > 0 && oAdmin != null)
            {
                if (txtPWD.TextValue.Length == 0)
                {
                    CommonMethod.ShowWaringMessage ("信息未作修改，无需提交");
                    return;
                }
                oAdmin.PWD = this.txtPWD.TextValue;
            }
            else
            {
                List<Admin> oList = AdminManage.GetAllAdmin ( );

                if (oList.Find (info => info.LoginName == txtLandName.TextValue) != null)
                {
                    CommonMethod.ShowWaringMessage ("已存在此登录名的用户，请更换登录名");
                    this.txtLandName.Focus ( );
                    return;
                }
                oAdmin = new Admin ( ) { LoginName = txtLandName.TextValue, PWD = txtPWD.TextValue };
            }
            AdminManage.SaveAdmin (oAdmin);
            CommonMethod.ShowWaringMessage ("信息提交成功");
            this.Close ( );
        }

        private void btnCancel_Click ( object sender, EventArgs e )
        {
            this.Close ( );
        }
    }
}
