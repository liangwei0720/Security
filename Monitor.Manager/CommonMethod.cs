using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Monitor.Component;
using System.Data.SqlClient;

namespace Monitor.Manager
{

    public class CommonMethod
    {
        /// <summary>
        /// 检测当前的GridDataView是否有选种的项
        /// </summary>
        /// <param name="oGridView">DataGridView</param>
        /// <param name="strCheckCellName">选择框的名称</param>
        /// <returns></returns>
        public static bool CheckDataGridViewSelectItems ( DataGridView oGridView, string strCheckCellName )
        {
            bool blHasChecked = false;
            //var currentRow=
            foreach (DataGridViewRow currentRow in oGridView.Rows)
            {
                if (currentRow.Cells[strCheckCellName].Value != null && (bool)currentRow.Cells[strCheckCellName].Value)
                {
                    blHasChecked = true;
                    break;
                }
            }

            return blHasChecked;
        }

        /// <summary>
        /// 提示信息
        /// </summary>
        /// <param name="title"></param>
        public static void ShowWaringMessage ( string title )
        {
            MessageBox.Show (title, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 获取工作站类型
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, string> GetWorkStationType ( )
        {
            var dic = new Dictionary<int, string> ( );
            dic.Add (0, "主站");
            dic.Add (1, "子站");

            return dic;
        }
    }

    public class EnumHelper
    {
        public static Dictionary<int, string> GetLabelStatus ( )
        {
            var type = typeof(StaticValue.LabelStatus);

            string[] typeText = Enum.GetNames (type);
            int[] typeValue = (int[])Enum.GetValues (type);

            var dic = new Dictionary<int, string> ( );
            for (int i = 0; i < typeText.Length; i++)
            {
                dic.Add (typeValue[i], typeText[i]);
            }

            return dic;
        }
    }

    public class OperationClient
    {
        public bool TestConnectionClient ( string clientIP )
        {
            try
            {
                using (SqlConnection oConnection = new SqlConnection (clientIP))
                {
                    oConnection.Open ( );
                    oConnection.Close ( );
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
