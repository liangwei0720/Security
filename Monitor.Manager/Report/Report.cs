using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using Monitor.Component.BLL;

namespace Monitor.Manager.Report
{
    public partial class Report : Form
    {
        private string strCondition = string.Empty;

        public enum ReportType
        {
            Goods = 1,
            NormalInOutRecord = 2,
            AbnormalInOutRecord = 3
        }

        public ReportType CreateReport { get; set; }

        public Report ( )
        {
            InitializeComponent ( );
            CreateReport = ReportType.Goods;
        }

        private void Report_Load ( object sender, EventArgs e )
        {
            LoadData ( );
        }

        private void LoadData ( )
        {
            bool blSearch = txtCondition.TextValue.Length > 0;
            strCondition = string.Empty;

            switch (CreateReport)
            {
                case ReportType.Goods:
                    if (blSearch)
                    {
                        strCondition = string.Format ("(学号='{0}' or 姓名='{1}')", txtCondition.TextValue);
                    }
                    CreateStudentsOfGoods ( );
                    lableTitle.Text = "学生物品报表预览";
                    break;
                case ReportType.NormalInOutRecord:
                    lableTitle.Text = "学生正常出入报表预览";
                    if (blSearch)
                    {
                        strCondition = string.Format ("(nvcStudentNumber='{0}' OR nvcStudentName='{1}') AND CurrentStatus<2", txtCondition.TextValue);
                    }
                    else
                    {
                        strCondition = "CurrentStatus<2";
                    }
                    CreateNormalInOutRecord (string.Empty);
                    break;
                default:
                    lableTitle.Text = "学生非正常出入报表预览";
                    if (blSearch)
                    {
                        strCondition = string.Format ("(nvcStudentNumber='{0}' OR nvcStudentName='{1}') AND CurrentStatus IN (2,3,6)", txtCondition.TextValue);
                    }
                    else
                    {
						strCondition = "CurrentStatus IN (2,3,6)";
                    }
                    CreateNormalInOutRecord ("学生非正常出入列表");
                    break;
            }
        }

        private void CreateStudentsOfGoods ( )
        {
            ReportContent oStudentInOut = new ReportContent ( );
            oStudentInOut.SetDataSource (LabelManager.GetStudentLabelsWithRepealLabel (strCondition));
            this.crystalReportViewer1.ReportSource = oStudentInOut;
        }

        private void CreateNormalInOutRecord ( string headText )
        {
            ReportInOut oInOut = new ReportInOut ( );
            TextObject HeadObject = oInOut.Section1.ReportObjects["txtHeader"] as TextObject;


            if (HeadObject != null && !string.IsNullOrEmpty (headText))
            {
                HeadObject.Text = headText;
            }


            oInOut.SetDataSource (InOutInfoManager.GetInOurByCondition (strCondition));
			
            this.crystalReportViewer1.ReportSource = oInOut;			

        }

        private void button_Click ( object sender, EventArgs e )
        {

            LoadData ( );
        }
    }
}
