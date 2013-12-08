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

namespace Monitor.Manager
{
    public partial class fm_LabelList : Form
    {
        private List<Labels> oList = new List<Labels> ( );

        public fm_LabelList ( )
        {
            InitializeComponent ( );
        }

        #region 方法
        /// <summary>
        /// 加载数据
        /// </summary>
        private void LoadData ( )
        {
            oList = LabelManager.GetAllLabels ( );

            dg_List.AutoGenerateColumns = false;
            dg_List.DataSource = oList;
        }

        private void UpdateLabelStatus ( )
        {
            var Dic = EnumHelper.GetLabelStatus ( );
            int iDicKey;

            foreach (DataGridViewRow row in this.dg_List.Rows)
            {
                int.TryParse (row.Cells["tcStatus"].Value.ToString ( ), out iDicKey);
                row.Cells["tcStatusName"].Value = Dic[iDicKey];
            }
        }
        #endregion

        private void dg_List_CellDoubleClick ( object sender, DataGridViewCellEventArgs e )
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            ShowEditLableForm (dg_List.CurrentRow.Cells["txlabelNumber"].Value.ToString ( ));

            LoadData ( );
        }

        private void btnAdd_Click ( object sender, EventArgs e )
        {
            LabelForm.EditLabel oAddLabel = new LabelForm.EditLabel ( );

            oAddLabel.ShowDialog ( );

            this.LoadData ( );
        }

        private void btnEdit_Click ( object sender, EventArgs e )
        {
            if (CommonMethod.CheckDataGridViewSelectItems (this.dg_List, "chkLabelID"))
            {
                ShowEditLableForm ((string)this.dg_List.CurrentRow.Cells["txlabelNumber"].Value);

                this.LoadData ( );
            }
            else
            {
                MessageBox.Show ("请选择你要编辑的项", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowEditLableForm ( string labelID )
        {
            LabelForm.EditLabel oEditLable = new LabelForm.EditLabel ( );

            oEditLable.ShowInTaskbar = false;
            oEditLable.LabelID = labelID;

            oEditLable.ShowDialog ( );
        }

        private void fm_LabelList_Load ( object sender, EventArgs e )
        {
            LoadData ( );
        }

        private void btnDel_Click ( object sender, EventArgs e )
        {
            if (!CommonMethod.CheckDataGridViewSelectItems (this.dg_List, "chkLabelID"))
            {
                MessageBox.Show ("请选择要删除的项", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DialogResult.No == MessageBox.Show ("确定要删除所选的信息吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                return;
            }


            foreach (DataGridViewRow row in dg_List.Rows)
            {
                if (row.Cells["chkLabelID"].Value != null && (bool)row.Cells["chkLabelID"].Value)
                {
                    LabelManager.DeleteLabels (row.Cells["txlabelNumber"].Value.ToString ( ));
                }
            }

            MessageBox.Show ("所选信息已删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            this.LoadData ( );
        }

        private void btnSearch_Click ( object sender, EventArgs e )
        {
            dg_List.DataSource = oList.FindAll (info => (info.LabelNumber.Contains(txtSearch.TextValue) || info.LabelName.Contains (txtSearch.TextValue)));
        }

        private void dg_List_DataBindingComplete ( object sender, DataGridViewBindingCompleteEventArgs e )
        {
            UpdateLabelStatus ( );
        }
    }
}
