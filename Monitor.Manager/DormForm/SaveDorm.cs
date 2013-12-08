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

namespace Monitor.Manager.DormForm
{
    public partial class SaveDorm : Form
    {
        #region 变量
        private Dorm oDorm = new Dorm ( );
        /// <summary>
        /// 公寓标识
        /// </summary>
        public Guid DormID
        {
            get;
            set;
        }
        /// <summary>
        /// 当前学校的标识
        /// </summary>
        public Guid SchoolID
        {
            get { return (SchoolManager.GetSchools (Guid.Empty) ?? new Schools ( )).SchoolID; }
        }
        #endregion

        #region 方法
        public SaveDorm ( )
        {
            InitializeComponent ( );
        }

        private void ClearControlValue ( )
        {
            txtDormName.TextValue = "";
            txtFlools.TextValue = "";
            txtRemark.TextValue = "";

            txtDormName.Focus ( );
        }

        private void LoadData ( )
        {
            if (DormID != Guid.Empty)
            {
                oDorm = DormManager.GetDorm (DormID);

                if (oDorm == null)
                {
                    MessageBox.Show ("信息未找到", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close ( );
                }

                this.labTitle.Text = this.Text = "编辑公寓信息";

                this.txtDormName.TextValue = oDorm.DormNumber;
                this.txtFlools.TextValue = oDorm.Flools.ToString ( );

                this.txtRemark.TextValue = oDorm.Remark;
            }
        }
        #endregion

        #region 事件
        private void btnSubmit_Click ( object sender, EventArgs e )
        {
            if (txtDormName.TextValue.Length == 0)
            {
                MessageBox.Show ("请输入公寓名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDormName.Focus ( );
                return;
            }

            int iFlools;
            if (txtFlools.TextValue.Length == 0)
            {
                MessageBox.Show ("请输入楼层数.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFlools.Focus ( );
                return;
            }
            int.TryParse (txtFlools.TextValue, out iFlools);

            if (iFlools < 1)
            {
                MessageBox.Show ("楼层数只能输入大于0的数字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFlools.Focus ( );
                return;
            }

            if (DormID == Guid.Empty)
            {
                oDorm.DormID = Guid.NewGuid ( );
                oDorm.AddDate = DateTime.Now;
                oDorm.SchoolID = SchoolID;
            }

            oDorm.DormNumber = txtDormName.TextValue;
            oDorm.Flools = (short)iFlools;
            oDorm.Remark = txtRemark.TextValue;

            if (DormManager.SaveDorm (oDorm))
            {
                if (DormID == Guid.Empty)
                {
                    if (DialogResult.Yes == MessageBox.Show ("添加信息成功，是否继续添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
                    {
                        ClearControlValue ( );
                    }
                    else
                    {
                        this.Close ( );
                    }
                }
                else
                {
                    MessageBox.Show ("编辑信息成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close ( );
                }
            }
            else
            {
                MessageBox.Show ("信息提交失败，请稍侯再试。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnCancel_Click ( object sender, EventArgs e )
        {
            this.Close ( );
        }

        private void SaveDorm_Load ( object sender, EventArgs e )
        {
            LoadData ( );
        }
        #endregion





    }
}
