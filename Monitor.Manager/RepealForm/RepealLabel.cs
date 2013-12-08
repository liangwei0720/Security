using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Monitor.Component.BLL;

namespace Monitor.Manager.RepealForm
{
    public partial class RepealLabel : Form
    {
        public RepealLabel ( )
        {
            InitializeComponent ( );
            //this.dataGridView1.hi
        }
        /// <summary>
        /// 社频卡销户
        /// </summary>
        /// <param name="strLabelNumber">视频卡号</param>
        /// <param name="strStudentNumber">学号</param>
        /// <returns></returns>
        private bool RepealLabels ( string strLabelNumber, string strStudentNumber, Guid guGoodsID )
        {
            return LabelManager.RepealLabels (strLabelNumber, strStudentNumber, guGoodsID);
        }

        private void btnSearch_Click ( object sender, EventArgs e )
        {
            this.dataGridView1.AutoGenerateColumns = false;
            string strCondition = string.Empty;

            if (this.txtStudentNumber.TextValue.Length > 0)
            {
                strCondition = " 学号='" + txtStudentNumber.TextValue + "'";
            }

            if (this.txtClassName.TextValue.Length > 0)
            {
                strCondition = string.Format ("{0}{1}", string.IsNullOrEmpty (strCondition) ? "" : (strCondition + " AND "), "班级 ='" + txtClassName.TextValue + "'");
            }

            dataGridView1.DataSource = LabelManager.GetStudentLabelsWithRepealLabel (strCondition);


            btnRepeal.Visible = this.dataGridView1.Rows.Count > 0;

            if (dataGridView1.Rows.Count == 0)
            {
                CommonMethod.ShowWaringMessage ("未找到相关信息");
            }

        }

        private void btnRepeal_Click ( object sender, EventArgs e )
        {
            bool blHasSelected = CommonMethod.CheckDataGridViewSelectItems (this.dataGridView1, "tcCheck");

            if (blHasSelected)
            {
                if (DialogResult.No == MessageBox.Show ("确定销户所有选择的项吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    return;
                }
            }
            else if (DialogResult.No == MessageBox.Show ("确定要销户所有的数据吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                return;
            }
            if (blHasSelected)
            {
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    if (row.Cells["tcCheck"].Value != null && (bool)row.Cells["tcCheck"].Value)
                    {
                        this.RepealLabels (row.Cells["标签号"].Value.ToString ( ), row.Cells["学号"].Value.ToString ( ), (Guid)row.Cells["物品编号"].Value);
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    this.RepealLabels (row.Cells["标签号"].Value.ToString ( ), row.Cells["学号"].Value.ToString ( ), (Guid)row.Cells["物品编号"].Value);
                }
            }
            CommonMethod.ShowWaringMessage ("销户已完成。");

            btnSearch_Click (null, null);
        }

        private void dataGridView1_CellContentClick ( object sender, DataGridViewCellEventArgs e )
        {

        }
    }
}
