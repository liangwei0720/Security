using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Monitor.Component.BLL;

namespace Monitor.Manager.BaseSettingForm
{
    public partial class SaveServer : Form
    {
        private Monitor.Component.Model.Server oServer = new Monitor.Component.Model.Server ( );
        public int ServerID { get; set; }
        public SaveServer ( )
        {
            InitializeComponent ( );
        }

        private void LoadBase ( )
        {
            cmbDormList.DataSource = DormManager.GetAllDormWithList ( );
            cmbDormList.DisplayMember = "DormNumber";
            cmbDormList.ValueMember = "DormID";
        }
        private void LoadData ( )
        {
            if (ServerID == 0)
            {
                return;
            }

            oServer = ServerManager.GetServer (ServerID);

            if (oServer == null)
            {
                MessageBox.Show ("未找到指定的信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtServerName.TextValue = oServer.ServerName;
            txtServerIP.TextValue = oServer.IP;
            cmbDormList.SelectedValue = oServer.GuDormID;
            txtConnection.TextValue = oServer.Connection;

            this.Text = this.lblTitle.Text = "编辑服务器信息";

        }

        private void btnCancel_Click ( object sender, EventArgs e )
        {
            this.Close ( );
        }

        private void SaveServer_Load ( object sender, EventArgs e )
        {
            LoadBase ( );

            LoadData ( );
        }

        private void btnSubmit_Click ( object sender, EventArgs e )
        {
            if (this.txtServerName.TextValue.Length == 0)
            {
                MessageBox.Show ("请输入服务器名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtServerName.Focus ( );
                return;
            }

            if (this.txtServerIP.TextValue.Length == 0)
            {
                MessageBox.Show ("请输入服务器的IP地址", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtServerIP.Focus ( );
                return;
            }

            IPAddress oIPAddress;
            if (!System.Net.IPAddress.TryParse (this.txtServerIP.TextValue, out oIPAddress))
            {
                MessageBox.Show ("你输入的IP地址不正确，请重新输入。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtServerIP.Focus ( );
                return;
            }

            if (string.IsNullOrEmpty (txtConnection.TextValue))
            {
                CommonMethod.ShowWaringMessage ("请输入客例信息。形如：Data Source=IP;Initial Catalog=DBName;User ID=LoginName;Password=LoginPWD;");
                this.txtConnection.Focus ( );
                return;
            }

            if (ServerID == 0)
            {
                oServer.LastUpdate = DateTime.Now;
                oServer.IsSuccess = true;
            }

            oServer.IP = this.txtServerIP.TextValue;
            oServer.ServerName = this.txtServerName.TextValue;
            oServer.GuDormID = (Guid)cmbDormList.SelectedValue;
            oServer.Connection = this.txtConnection.TextValue;



            ServerManager.SaveServer (oServer);

            if (ServerID == 0 && oServer.ServerID > 0)
            {
                if (DialogResult.Yes == MessageBox.Show ("信息提交成功。是否继续添加信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    this.txtServerIP.TextValue = this.txtServerName.TextValue = string.Empty;
                    this.txtServerName.Focus ( );
                }
                else
                {
                    this.Close ( );
                }
            }
            else
            {
                MessageBox.Show ("信息提交成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close ( );
            }

        }
    }
}
