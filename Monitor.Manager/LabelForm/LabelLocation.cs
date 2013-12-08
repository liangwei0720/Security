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
using Monitor.Component;

namespace Monitor.Manager.LabelForm
{
    public partial class LabelLocation : Form
    {
        public LabelLocation ( )
        {
            InitializeComponent ( );
            this.dateTimeBegin.Text = DateTime.Now.AddDays (-1).ToString ("yyyy-MM-dd HH:mm");
        }

        private void btnSearch_Click ( object sender, EventArgs e )
        {
            if (this.txtLabelNumber.TextValue.Length == 0 && txtStudentNumber.TextValue.Length == 0)
            {
                CommonMethod.ShowWaringMessage ("请输入要定位的标签或学号");
                return;
            }
            string labMAC = string.Empty;
            List<Labels> oListLabels = null;
            Server oServer = null;
            Guid guDormID = Guid.Empty;

            if (this.txtLabelNumber.TextValue.Length > 0)
            {
                oListLabels = LabelManager.GetLabelsByCondition (string.Format ("nvcLabelNumber='{0}'", txtLabelNumber.TextValue.Replace ("'", "")));

                if (oListLabels == null || oListLabels.Count == 0)
                {
                    CommonMethod.ShowWaringMessage ("不存在此编号的标签");
                    return;
                }

                guDormID = oListLabels[0].DormID;
                //服务器和客户端机器是一台，所以暂时注释掉

                if (oListLabels[0].Status == (int)StaticValue.LabelStatus.正常)
                {
                    CommonMethod.ShowWaringMessage ("此编号的标签还未分配，无法查询其位置信息");
                    return;
                }


                labMAC = this.txtLabelNumber.TextValue;

            }
            else
            {
                var goods = new GoodsManager ( ).GetGoodsByCondition (" nvcStudentNumber = '" + txtStudentNumber.TextValue.Replace ("'", "") + "'");

                if (goods == null || goods.Count == 0)
                {
                    CommonMethod.ShowWaringMessage ("未找到该学生相应的物品信息");
                    return;
                }

                labMAC = goods[0].LabelNumber;

                var label = LabelManager.GetLabels (labMAC);

                if (label == null)
                {
                    CommonMethod.ShowWaringMessage ("未找到该学生相应物品所分配的标签信息");
                    return;
                }

                guDormID = label.DormID;
            }
            oServer = ServerManager.GetAllServer ( ).Find (info => info.GuDormID == guDormID);

            if (oServer == null || string.IsNullOrEmpty (oServer.Connection))
            {
                CommonMethod.ShowWaringMessage ("无法确定要获取的客户端对象的信息，有可能未设置服务器的相关信息。");
                return;
            }

            string condition = string.Format ("LabelMac='{0}' AND ReceiveTime BETWEEN '{1}' AND '{2}'", labMAC, dateTimeBegin.Value, dateTimeEnd.Value);

            DataTable table = T_MonitorHistoryManager.GetT_MonitorHistoryForLocation (condition, oServer.Connection);

            if (table.Rows.Count == 0)
            {
                CommonMethod.ShowWaringMessage ("暂无相关信息");
                return;
            }

            oListLabels = LabelManager.GetAllLabels ( );
            List<WorkStations> olstWorkStation = WorkStationsManager.GetAllWorkStations ( );
            Labels oLabel;
            WorkStations oStations;
            foreach (DataRow row in table.Rows)
            {
                //oLabel = LabelManager.GetLabels( row["LabelMac"].ToString( ) );
                oLabel = oListLabels.Find (info1 => info1.LabelNumber.Equals (row["LabelMac"].ToString ( ), StringComparison.OrdinalIgnoreCase));
                //oStations = WorkStationsManager.GetWorkStations (row["APMac"].ToString ( ));
                oStations = olstWorkStation.Find (infoStation => infoStation.StationID.Equals (row["APMac"].ToString ( ), StringComparison.OrdinalIgnoreCase));
                if (oStations != null)
                {
                    //int status=( int )row["status"];
                    //var statusName = ( Monitor.Component.StaticValue.CurrentStatus )status;

                    row["LabelMac"] = string.Format ("{0} 位置：{1} 信号强度：{2} 报警：{3}  损坏：{4} 低电压：{5}",
                        row["LabelMac"],
                        oStations.StationPostion,
                        row["SignalStrong"],
                        row["IsWarning"],
                        row["IsDestroy"],
                        row["IsLess"]);// +"  状态：" + statusName.ToString( );

                }
                else
                {
                    row["LabelMac"] = row["LabelMac"] + " 无法定位";
                }
            }

            dg_List.AutoGenerateColumns = false;
            dg_List.DataSource = table;

            oListLabels = null;
            olstWorkStation = null;
        }
    }
}
