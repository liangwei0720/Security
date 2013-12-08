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

namespace Monitor.Manager.WorkStationForms
{
    public partial class SaveWorkStation : Form
    {
        #region 变量定义
        private WorkStations oWorkStation;

        public string StationID
        {
            get;
            set;
        }

        private string strStationID = string.Empty;
        #endregion

        public SaveWorkStation ( )
        {
            InitializeComponent ( );
        }
        #region 事件
        private void btnSubmit_Click ( object sender, EventArgs e )
        {
            if (!string.IsNullOrEmpty (strStationID))
            {
                CommonMethod.ShowWaringMessage ("数据库中已存在此编号的工作站，无法提交。");
                this.txtStationNumber.Focus ( );

                return;
            }

            if (txtStationNumber.TextValue.Length == 0)
            {
                MessageBox.Show ("请输入工作站编号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtStationNumber.Focus ( );
                return;
            }

            if (oWorkStation == null)
            {
                oWorkStation = new WorkStations ( );
                oWorkStation.AddDate = DateTime.Now;
            }
            oWorkStation.StationID = txtStationNumber.TextValue;
            oWorkStation.DormID = new Guid (cmbDorm.SelectedValue.ToString ( ));
            oWorkStation.StationPostion = txtPosition.TextValue;
            oWorkStation.StationType = cmbWorkStationType.Text;
            //short iStatus;
            //short.TryParse (cmbStatus.Text, out iStatus);
            //oWorkStation.Status = iStatus;

            if (WorkStationsManager.SaveWorkStations (oWorkStation))
            {
                DialogResult oResult;

                if (string.IsNullOrEmpty (StationID))
                {
                    oResult = MessageBox.Show ("信息提交成功,是否继续添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (oResult == DialogResult.No)
                    {
                        this.Close ( );
                        return;
                    }

                    this.txtStationNumber.TextValue = this.txtPosition.TextValue = string.Empty;
                }
                else
                {
                    MessageBox.Show ("信息提交成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close ( );
                }

            }
            else
            {
                MessageBox.Show ("信息提交失败，请稍侯再试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancle_Click ( object sender, EventArgs e )
        {
            this.Close ( );
        }
        #endregion


        #region 方法
        /// <summary>
        /// 加载基本数据
        /// </summary>
        private void LoadData ( )
        {
            if (string.IsNullOrEmpty (StationID))
            {
                return;
            }
            oWorkStation = WorkStationsManager.GetWorkStations (StationID);

            if (oWorkStation == null)
            {
                CommonMethod.ShowWaringMessage ("该信息不存在");
                return;
            }
            this.Text = lblTitle.Text = "编辑工作站信息";

            this.txtPosition.TextValue = oWorkStation.StationPostion;
            this.txtStationNumber.TextValue = oWorkStation.StationID.ToString ( );
            this.cmbDorm.SelectedValue = oWorkStation.DormID;
            //this.cmbStatus.SelectedValue = oWorkStation.Status;
            this.cmbWorkStationType.SelectedValue = oWorkStation.StationType;
            this.txtStationNumber.Enabled = false;

        }

        private void LoadBase ( )
        {
            cmbDorm.DataSource = DormManager.GetAllDormWithList ( );
            cmbDorm.ValueMember = "DormID";
            cmbDorm.DisplayMember = "DormNumber";

            var bindSouce = new BindingSource ( );
            bindSouce.DataSource = CommonMethod.GetWorkStationType ( );

            cmbWorkStationType.DataSource = bindSouce;
            cmbWorkStationType.ValueMember = "Value";
            cmbWorkStationType.DisplayMember = "Value";
        }


        #endregion

        private void SaveWorkStation_Load ( object sender, EventArgs e )
        {
            LoadBase ( );

            LoadData ( );
        }

        private void txtStationNumber_Leave ( object sender, EventArgs e )
        {
            if (!strStationID.Equals (this.txtStationNumber.TextValue))
            {
                oWorkStation = WorkStationsManager.GetWorkStations (this.txtStationNumber.TextValue);

                if (oWorkStation != null)
                {
                    CommonMethod.ShowWaringMessage ("数据库中已存在此编号的工作站。");
                    strStationID = this.txtStationNumber.TextValue;
                    this.txtStationNumber.Focus ( );
                }
                else
                {
                    strStationID = string.Empty;
                }
            }
        }
    }
}
