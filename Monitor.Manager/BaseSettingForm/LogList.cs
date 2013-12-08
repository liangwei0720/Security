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
    public partial class LogList : Form
    {
        string condition = string.Empty;
        private List<Component.Model.Server> oListServer = ServerManager.GetAllServer ( );

        public LogList ( )
        {
            InitializeComponent ( );
        }

        private void LoadData ( )
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ErrorLogManager.GetErrorLog (condition);
        }

        private void btnDel_Click ( object sender, EventArgs e )
        {
            if (!CommonMethod.CheckDataGridViewSelectItems (this.dataGridView1, "tcCheck"))
            {
                CommonMethod.ShowWaringMessage ("请选择要删除的项");
                return;
            }

            if (DialogResult.No == MessageBox.Show ("确定要删除所有选择的项吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                return;
            }

            var rows = from row in dataGridView1.Rows.Cast<DataGridViewRow> ( )
                       where row.Cells["tcCheck"].Value != null && (bool)row.Cells["tcCheck"].Value
                       select new { Guid = row.Cells["tcGuID"].Value };

            foreach (var r in rows)
            {
                ErrorLogManager.DeleteErrorLog ((Guid)r.Guid);
            }
            LoadData ( );

            CommonMethod.ShowWaringMessage ("所选信息已删除");

        }

        private void btnSearch_Click ( object sender, EventArgs e )
        {
            condition = string.Format (" ErrorTime BETWEEN '{0}' AND '{1}'", dateTimeBegin.Text, dateTimeEnd.Text);
            LoadData ( );
        }

        private void btnGetErrorInfo_Click ( object sender, EventArgs e )
        {
            if (DialogResult.No == MessageBox.Show ("在获取数据过程中，界面可能会出现无响应的情况，请耐心等待。\r\n具体无响应的时间和客户端的数据量及网络有很大关系。\r\n\r\n确定要执行获取操作吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                return;
            }

            List<ErrorLog> oListSubLog;

            foreach (Component.Model.Server oServer in oListServer)
            {
                oListSubLog = new List<ErrorLog> ( );
                oListSubLog = ErrorLogManager.GetErrorLog ("", oServer.Connection);
                oListSubLog.ForEach (info => { info.GUID = new Guid ( ); info.DormID = oServer.GuDormID; });

                foreach (ErrorLog oLog in oListSubLog)
                {
                    ErrorLogManager.SaveErrorLog (oLog);
                    ErrorLogManager.DeleteErrorLog (oLog.ID, oServer.Connection);
                }

            }

            CommonMethod.ShowWaringMessage ("获取客户端日志成功");

            LoadData ( );
        }

        private void LogList_Load ( object sender, EventArgs e )
        {
            dateTimeBegin.Text = DateTime.Now.AddDays (-1).ToString ("yyyy-MM-dd HH:mm");
            LoadData ( );

        }
    }
}
