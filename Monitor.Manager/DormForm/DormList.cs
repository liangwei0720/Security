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
    public partial class DormList : Form
    {
        #region 变量
        private List<Dorm> dtResource = new List<Dorm> ( );
        #endregion

        #region 方法
        public DormList ( )
        {
            InitializeComponent ( );
        }
        /// <summary>
        /// 加载基本信息
        /// </summary>
        private void LoadData ( )
        {
            dtResource = DormManager.GetAllDormWithList ( );

            dgList.AutoGenerateColumns = false;
            dgList.DataSource = dtResource;
        }

        /// <summary>
        /// 显示编辑
        /// </summary>
        /// <param name="dormID"></param>
        private void ShowSaveDormForm ( Guid dormID )
        {
            SaveDorm oSaveDorm = new SaveDorm ( ) { DormID = dormID };

            oSaveDorm.ShowDialog ( );
        }

        /// <summary>
        /// 判断是不是有选择
        /// </summary>
        /// <returns></returns>
        private bool HasCheckBoxSelect ( )
        {
            bool blChecked = false;

            foreach (DataGridViewRow row in this.dgList.Rows)
            {
                if (row.Cells["tcCheck"].Value != null)
                {
                    blChecked = true;
                    break;
                }
            }

            return blChecked;
        }
        #endregion

        #region 事件
        private void btnAdd_Click ( object sender, EventArgs e )
        {
            SaveDorm oSaveDor = new SaveDorm ( );

            oSaveDor.ShowDialog ( );

            this.LoadData ( );
        }

        private void DormList_Load ( object sender, EventArgs e )
        {
            LoadData ( );
        }

        private void btnSearch_Click ( object sender, EventArgs e )
        {

            if (txtSearch.TextValue.Length == 0)
            {
                this.LoadData ( );
                return;
            }

            dgList.DataSource = dtResource.FindAll (info => info.DormNumber.Contains (txtSearch.TextValue));

        }

        #endregion

        private void dgList_CellDoubleClick ( object sender, DataGridViewCellEventArgs e )
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            ShowSaveDormForm ((Guid)dgList.CurrentRow.Cells["tcDormID"].Value);

            this.LoadData ( );
        }

        private void btnEdit_Click ( object sender, EventArgs e )
        {
            if (CommonMethod.CheckDataGridViewSelectItems (this.dgList, "tcCheck"))
            {

                ShowSaveDormForm ((Guid)this.dgList.SelectedRows[0].Cells["tcDormID"].Value);

                //Guid guDormID = Guid.Empty;

                //foreach (DataGridViewRow row in this.dgList.Rows)
                //{
                //    if (row.Cells["tcCheck"].Value != null)
                //    {
                //        guDormID = (Guid)row.Cells["tcDormID"].Value;
                //        break;
                //    }
                //}
                //ShowSaveDormForm (guDormID);

                this.LoadData ( );
            }
            else
            {
                MessageBox.Show ("请选择要编辑的项", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDel_Click ( object sender, EventArgs e )
        {
            if (!CommonMethod.CheckDataGridViewSelectItems (this.dgList, "tcCheck"))
            {
                CommonMethod.ShowWaringMessage ("请选择要删除的项");
                return;
            }

            if (DialogResult.Yes == MessageBox.Show ("确定要删除所有选择的项吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                foreach (DataGridViewRow row in this.dgList.SelectedRows)
                {
                    DormManager.DeleteDorm ((Guid)row.Cells["tcDormID"].Value);
                }

                CommonMethod.ShowWaringMessage ("所选信息已全部删除");

                this.LoadData ( );
            }
        }
    }
}
