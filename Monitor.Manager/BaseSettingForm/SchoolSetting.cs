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

namespace Monitor.Manager.BaseSettingForm
{
    public partial class SchoolSetting : Form
    {
        #region 变量
        private Schools oSchool = new Schools ( );
        #endregion
        public SchoolSetting ( )
        {
            InitializeComponent ( );
        }

        private void btnSubmit_Click ( object sender, EventArgs e )
        {
            if (txtName.TextValue.Length == 0)
            {
                CommonMethod.ShowWaringMessage ("请输入学校名称");
                this.txtName.Focus ( );
                return;
            }
            if (txtCode.TextValue.Length == 0)
            {
                CommonMethod.ShowWaringMessage ("请输入学校编码");
                this.txtCode.Focus ( );
                return;

            }

            if (oSchool == null)
            {
                oSchool = new Schools ( );
                oSchool.AddDate = DateTime.Now;
                oSchool.SchoolID = Guid.NewGuid ( );
            }

            oSchool.SchoolSummary = rtbIntro.TextValue;
            oSchool.SchoolCode = txtCode.TextValue;
            oSchool.SchoolName = txtName.TextValue;

            if (SchoolManager.SaveSchools (oSchool))
            {
                MessageBox.Show ("信息保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close ( );
            }
            else
            {
                MessageBox.Show ("信息保存失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData ( )
        {
            oSchool = SchoolManager.GetSchools (Guid.Empty);

            if (oSchool != null)
            {
                txtCode.TextValue = oSchool.SchoolCode;
                txtName.TextValue = oSchool.SchoolName;
                rtbIntro.TextValue = oSchool.SchoolSummary;
            }
        }

        private void btnCancel_Click ( object sender, EventArgs e )
        {
            this.Close ( );
        }

        private void SchoolSetting_Load ( object sender, EventArgs e )
        {
            LoadData ( );
            rtbIntro.IsMultiLine = true;
        }
    }
}
