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

namespace Monitor.Manager.LabelForm
{
    public partial class EditLabel : BaseForm
    {
        #region 属性定义
        /// <summary>
        /// 标签ID
        /// </summary>
        public string LabelID { get; set; }
        private Labels oLabel;
        /// <summary>
        /// 学校编码
        /// </summary>
        public Guid SchoolID
        {
            get
            {
                return (SchoolManager.GetSchools (Guid.Empty) ?? new Schools ( )).SchoolID;
            }
        }

        private bool blExistsLabelNumber { get; set; }
        private string strLabelNumber=string.Empty;
        #endregion
        public EditLabel ( )
        {
            InitializeComponent ( );
        }

        private void btnSubmit_Click ( object sender, EventArgs e )
        {
            if (txtLabelNumber.TextValue.Length == 0)
            {
                CommonMethod.ShowWaringMessage ("请输入标签编号");
                this.txtLabelNumber.Focus ( );
                return;
            }

            if (!string.IsNullOrEmpty (strLabelNumber))
            {
                MessageBox.Show ("你输入的编号在数据库中已存在，无法提交。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtLabelNumber.Focus ( );

                return;
            }

            if (cmbLabelStatus.SelectedValue == null)
            {
                MessageBox.Show ("请选择标签的状态", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            bool blAddInfo = string.IsNullOrEmpty (LabelID);

            if (blAddInfo)
            {
                oLabel = new Labels ( );
                oLabel.AddDate = DateTime.Now;
            }
            oLabel.LabelName = txtLabelName.TextValue;
            oLabel.LabelNumber = txtLabelNumber.TextValue;
            oLabel.Power = txtLabelPower.TextValue;
            oLabel.Remark = txtLableRemark.TextValue;

            short status;
            short.TryParse (cmbLabelStatus.SelectedValue.ToString ( ), out status);
            oLabel.Status = status;

            oLabel.SchoolID = this.SchoolID;

            if (LabelManager.SaveLabels (oLabel))
            {
                MessageBox.Show ("信息提交成功", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close ( );
            }
            else
            {
                MessageBox.Show ("信息提交失败", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region 相关方法
        /// <summary>
        /// 加载基本数据
        /// </summary>
        private void LoadBase ( )
        {
            Type oLabelStatus = typeof (Monitor.Component.StaticValue.LabelStatus);

            string[] labelStatusText = Enum.GetNames (oLabelStatus);
            int[] labelStatusValue = (int[])Enum.GetValues (oLabelStatus);

            var Dic = new Dictionary<int, string> ( );

            for (int i = 0; i < labelStatusText.Length; i++)
            {
                Dic.Add (labelStatusValue[i], labelStatusText[i]);
            }
            BindingSource oBindingSource = new BindingSource ( );
            oBindingSource.DataSource = Dic;

            cmbLabelStatus.DisplayMember = "value";
            cmbLabelStatus.ValueMember = "key";
            try
            {
                cmbLabelStatus.DataSource = oBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }
        /// <summary>
        /// 加载基本数据
        /// </summary>
        private void LoadData ( )
        {
            if (string.IsNullOrEmpty (this.LabelID))
            {
                return;
            }

            oLabel = LabelManager.GetLabels (this.LabelID);

            if (oLabel == null)
            {
                MessageBox.Show ("未能找到相关的信息", "信息未找到", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close ( );

                return;
            }

            txtLabelName.TextValue = oLabel.LabelName;
            txtLabelNumber.TextValue = oLabel.LabelNumber;
            txtLabelPower.TextValue = oLabel.Power;
            txtLableRemark.TextValue = oLabel.Remark;
            cmbLabelStatus.SelectedValue = (int)oLabel.Status;
        }
        #endregion

        private void btnCancel_Click ( object sender, EventArgs e )
        {
            this.Close ( );
        }

        private void EditLabel_Load ( object sender, EventArgs e )
        {
            txtLabelNumber.Enabled = string.IsNullOrEmpty (LabelID);

            LoadBase ( );

            LoadData ( );

            if (!string.IsNullOrEmpty (LabelID))
            {
                this.lblTitle.Text = this.Text = "编辑标签信息";
            }
        }

        private void txtLabelNumber_Leave ( object sender, EventArgs e )
        {
            if (!strLabelNumber.Equals (this.txtLabelNumber.TextValue))
            {
                Labels oLab = LabelManager.GetLabels (this.txtLabelNumber.TextValue);

                if (oLab != null)
                {
                    MessageBox.Show ("数据库中已存在此编号的标签，请确认你输入的标签编号是否正确。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtLabelNumber.Focus ( );
                    strLabelNumber = this.txtLabelNumber.TextValue;                  
                }
                else
                {
                    strLabelNumber = string.Empty;
                }
            }
        }
    }
}
