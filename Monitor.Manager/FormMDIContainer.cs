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
using Monitor.Manager.BaseSettingForm;
using Monitor.Manager.LabelForm;


namespace Monitor.Manager
{

    public partial class FormMDIContainer : Form
    {
        public bool LandSuccess { get; set; }
        public bool IsAdmin { get; set; }
        public FormMDIContainer ( )
        {
            InitializeComponent ( );
        }
        private void FormMDIContainer_Load ( object sender, EventArgs e )
        {
            Login ologin = new Login ( );
            if (DialogResult.OK != ologin.ShowDialog ( ))
            {
                this.Close ( );
                return;
            }
            CommonMethod.ShowWaringMessage (ologin.AdminName + " 您好。\n\n欢迎您" + this.Text);
            管理员管理ToolStripMenuItem.Visible = ologin.IsAdmin;




            if ((SchoolManager.GetSchools (Guid.Empty) ?? new Schools ( )).SchoolID == Guid.Empty)
            {
                MessageBox.Show ("请选配置学校的基本信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                设置学校信息ToolStripMenuItem_Click (null, null);

                return;
            }

            查看日志ToolStripMenuItem_Click (null, null);
        }
        private void ToolStripMenuItem_ShowAllLabels_Click ( object sender, EventArgs e )
        {
            fm_LabelList labeList = new fm_LabelList ( );
            labeList.MdiParent = this;

            labeList.WindowState = FormWindowState.Maximized;
            CloseOtherActiveFormAndShowCurrentForm (labeList);


            labeList.Show ( );
        }

        private void ToolStripMenuItem_AddLabel_Click ( object sender, EventArgs e )
        {
            LabelForm.EditLabel oAddLabel = new LabelForm.EditLabel ( );

            CloseOtherActiveFormAndShowCurrentForm (oAddLabel);

            oAddLabel.MdiParent = this;
            oAddLabel.Show ( );
        }

        /// <summary>
        /// 关闭其它的子窗体,并将当前的窗体显示出来
        /// </summary>
        /// <param name="form"></param>
        protected void CloseOtherActiveFormAndShowCurrentForm ( Form CurrentForm )
        {
            if (this.IsMdiContainer && this.MdiChildren.Length > 0 && this.ActiveMdiChild != null)
            {

                this.ActiveMdiChild.Close ( );
            }
        }

        /// <summary>
        /// 激活当前窗体
        /// </summary>
        /// <param name="form"></param>
        /// <param name="currentForm"></param>
        protected void ActiveCurrentForm ( Form currentForm )
        {
            if (this.MdiChildren.Contains (currentForm))
            {
                currentForm.Activate ( );
            }
        }

        private void ToolStripMenuItem_WorkStationsList_Click ( object sender, EventArgs e )
        {
            WorkStationForms.WorkStationsList oWorkStations = new WorkStationForms.WorkStationsList ( );

            oWorkStations.MdiParent = this;
            oWorkStations.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oWorkStations);

            oWorkStations.Show ( );
        }

        private void 添加工作站ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            WorkStationForms.SaveWorkStation oSaveWorkStation = new WorkStationForms.SaveWorkStation ( );

            CloseOtherActiveFormAndShowCurrentForm (oSaveWorkStation);

            oSaveWorkStation.MdiParent = this;
            oSaveWorkStation.StartPosition = FormStartPosition.CenterScreen;
            oSaveWorkStation.Show ( );
        }

        private void 设置学校信息ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            BaseSettingForm.SchoolSetting oSchoolSetting = new BaseSettingForm.SchoolSetting ( );

            CloseOtherActiveFormAndShowCurrentForm (oSchoolSetting);

            oSchoolSetting.MdiParent = this;
            oSchoolSetting.StartPosition = FormStartPosition.CenterScreen;
            oSchoolSetting.Show ( );
        }

        private void 查看标签信息ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            fm_LabelList labeList = new fm_LabelList ( );
            labeList.MdiParent = this;

            labeList.WindowState = FormWindowState.Maximized;
            CloseOtherActiveFormAndShowCurrentForm (labeList);


            labeList.Show ( );
        }

        private void 工作站管理ToolStripMenuItem1_Click ( object sender, EventArgs e )
        {
            WorkStationForms.WorkStationsList oWorkStations = new WorkStationForms.WorkStationsList ( );

            oWorkStations.MdiParent = this;
            oWorkStations.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oWorkStations);

            oWorkStations.Show ( );
        }



        private void 公寓管理ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            DormForm.DormList oDormList = new DormForm.DormList ( );

            oDormList.MdiParent = this;
            oDormList.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oDormList);

            oDormList.Show ( );
        }

        private void 查看学生信息ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            StudentForm.StudentList oStudentList = new StudentForm.StudentList ( );

            oStudentList.MdiParent = this;
            oStudentList.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oStudentList);

            oStudentList.Show ( );
        }

        private void 学生物品信息ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            StudentForm.GoodsList oGoodsList = new StudentForm.GoodsList ( );

            oGoodsList.MdiParent = this;
            oGoodsList.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oGoodsList);

            oGoodsList.Show ( );
        }

        private void 宿舍管理ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            DormForm.DormRoomList oDormRoomList = new DormForm.DormRoomList ( );

            oDormRoomList.MdiParent = this;
            oDormRoomList.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oDormRoomList);

            oDormRoomList.Show ( );
        }

        private void 导入学生信息ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            ImportStudentInfo oImportInfo = new ImportStudentInfo ( );

            oImportInfo.MdiParent = this;
            oImportInfo.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oImportInfo);

            oImportInfo.Show ( );
        }

        private void 服务器管理ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            BaseSettingForm.Server oServer = new BaseSettingForm.Server ( );

            oServer.MdiParent = this;
            oServer.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oServer);

            oServer.Show ( );
        }

        private void 轮播信息管理ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            BaseSettingForm.ScrollImage oScrollImage = new BaseSettingForm.ScrollImage ( );

            oScrollImage.MdiParent = this;
            oScrollImage.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oScrollImage);

            oScrollImage.Show ( );
        }

        private void 射频卡销户ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            RepealForm.RepealLabel oRepealLabel = new RepealForm.RepealLabel ( );

            oRepealLabel.MdiParent = this;
            oRepealLabel.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oRepealLabel);

            oRepealLabel.Show ( );
        }

        private void 出入卡销户ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            RepealForm.RepealCard oRepealCard = new RepealForm.RepealCard ( );

            oRepealCard.MdiParent = this;
            oRepealCard.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oRepealCard);

            oRepealCard.Show ( );
        }

        private void toolStripButton1_Click ( object sender, EventArgs e )
        {
            设置学校信息ToolStripMenuItem_Click (null, null);
        }

        private void toolStripButton2_Click ( object sender, EventArgs e )
        {
            查看标签信息ToolStripMenuItem_Click (null, null);
        }

        private void toolStripButton3_Click ( object sender, EventArgs e )
        {
            工作站管理ToolStripMenuItem1_Click (null, null);
        }

        private void toolStripButton4_Click ( object sender, EventArgs e )
        {
            公寓管理ToolStripMenuItem_Click (null, null);
        }

        private void toolStripButton5_Click ( object sender, EventArgs e )
        {
            宿舍管理ToolStripMenuItem_Click (null, null);
        }

        private void toolStripButton6_Click ( object sender, EventArgs e )
        {
            查看学生信息ToolStripMenuItem_Click (null, null);
        }

        private void toolStripButton7_Click ( object sender, EventArgs e )
        {
            学生物品信息ToolStripMenuItem_Click (null, null);
        }

        private void toolStripButton8_Click ( object sender, EventArgs e )
        {
            导入学生信息ToolStripMenuItem_Click (null, null);
        }

        private void toolStripButton9_Click ( object sender, EventArgs e )
        {
            射频卡销户ToolStripMenuItem_Click (null, null);
        }

        private void 学生物品统计ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Report.Report oReport = new Report.Report ( ) { CreateReport = Report.Report.ReportType.Goods };

            oReport.MdiParent = this;
            oReport.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oReport);
            oReport.Show ( );
        }

        private void toolStripServer_Click ( object sender, EventArgs e )
        {
            服务器管理ToolStripMenuItem_Click (null, null);
        }

        private void toolStripScroll_Click ( object sender, EventArgs e )
        {
            轮播信息管理ToolStripMenuItem_Click (null, null);
        }

        private void toolStripButtonInOut_Click ( object sender, EventArgs e )
        {
            正常出入统计ToolStripMenuItem_Click (sender, e);
        }

        private void toolStripReporGoods_Click ( object sender, EventArgs e )
        {
            学生物品统计ToolStripMenuItem_Click (sender, e);
        }

        private void 正常出入统计ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Report.Report oReport = new Report.Report ( ) { CreateReport = Report.Report.ReportType.NormalInOutRecord };

            oReport.MdiParent = this;
            oReport.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oReport);
            oReport.Show ( );
        }

        private void 非正常出入统计ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Report.Report oReport = new Report.Report ( ) { CreateReport = Report.Report.ReportType.AbnormalInOutRecord };

            oReport.MdiParent = this;
            oReport.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oReport);
            oReport.Show ( );
        }

        private void 管理员列表ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            AdminList oAdminList = new AdminList ( );

            oAdminList.MdiParent = this;
            oAdminList.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oAdminList);
            oAdminList.Show ( );

        }

        private void 更新学生信息到客户端ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            UpdateInfoForm.UpdateInfoToClient oClient = new UpdateInfoForm.UpdateInfoToClient ( );

            oClient.MdiParent = this;
            oClient.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oClient);
            oClient.Show ( );
        }

        private void 从客户端获取出入信息ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            UpdateInfoForm.GetInfoFromClient oFromClient = new UpdateInfoForm.GetInfoFromClient ( );

            oFromClient.MdiParent = this;
            oFromClient.WindowState = FormWindowState.Maximized;

            CloseOtherActiveFormAndShowCurrentForm (oFromClient);

            oFromClient.Show ( );
        }

        private void 查看日志ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            LogList oLogList = new LogList ( );
            oLogList.MdiParent = this;

            oLogList.WindowState = FormWindowState.Maximized;
            CloseOtherActiveFormAndShowCurrentForm (oLogList);


            oLogList.Show ( );
        }

        private void 查看定位信息ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            LabelLocation oLocation = new LabelLocation ( );
            oLocation.MdiParent = this;

            oLocation.WindowState = FormWindowState.Maximized;
            CloseOtherActiveFormAndShowCurrentForm (oLocation);


            oLocation.Show ( );
        }

        private void 关于ToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            MessageBox.Show (string.Format ("寓安通高校公寓贵重物品防盗搜寻系统是有郑州恩久科技有限公司开发{0}{0}开发人员：陆 峰{0}\t 梁 伟", Environment.NewLine), "说明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

		private void 公寓管理员列表ToolStripMenuItem_Click (object sender , EventArgs e)
		{
			DormForm.DormAdminList adminList = new DormForm.DormAdminList( );
			adminList.MdiParent = this;

			adminList.WindowState = FormWindowState.Maximized;
			CloseOtherActiveFormAndShowCurrentForm( adminList );

			adminList.Show( );
		}

		private void 更新公寓信息到客户端ToolStripMenuItem_Click (object sender , EventArgs e)
		{
			UpdateInfoForm.UpdateDormToClient updateDormToClient = new UpdateInfoForm.UpdateDormToClient( );
			updateDormToClient.MdiParent = this;

			updateDormToClient.WindowState = FormWindowState.Maximized;
			CloseOtherActiveFormAndShowCurrentForm( updateDormToClient );

			updateDormToClient.Show( );
		}

        private void 导入公寓信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DormForm.ImportDorm importDorm = new DormForm.ImportDorm();
            importDorm.MdiParent = this;
            importDorm.WindowState = FormWindowState.Maximized;
            CloseOtherActiveFormAndShowCurrentForm(importDorm);

            importDorm.Show();
        }


    }
}
