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

namespace Monitor.Manager.DormForm
{
    public partial class DormRoomList : Form
    {
        #region 变量
        List<Dorm> oListDorm = new List<Dorm> ( );
        DataTable oDataTableRooms = new DataTable ( );
        #endregion
        #region 方法
        public DormRoomList ( )
        {
            InitializeComponent ( );
        }

        private void LoadBase ( )
        {
            oListDorm = DormManager.GetAllDormWithList ( );

            cmbDorm.ValueMember = "DormID";
            cmbDorm.DisplayMember = "DormNumber";
            oListDorm.Insert (0, new Dorm ( ) { DormID = Guid.Empty, DormNumber = "全部" });

            cmbDorm.DataSource = oListDorm;
            //cmbDorm.Items.Insert (-1, "全部");//??

        }

        private void LoadData ( )
        {
            string strCondition = string.Empty;

            if (cmbDorm.SelectedValue != null && (Guid)cmbDorm.SelectedValue != Guid.Empty)
            {
                strCondition = " guDormID='" + cmbDorm.SelectedValue + "'";
            }

            if (txtRoomName.TextValue.Length > 0)
            {
                strCondition = string.Format ("{0}{1}", strCondition.Length > 0 ? strCondition + " AND " : string.Empty, "nvcRoomNumber='" + txtRoomName.TextValue.Replace ("'", "") + "'");
            }
            oDataTableRooms = DormRoomManager.GetDormRoomsByCondtion (strCondition);

            dgRoomsList.DataSource = oDataTableRooms;

        }

        /// <summary>
        /// 替换公寓名称
        /// </summary>
        private void SetGridViewDormName ( )
        {
            foreach (DataGridViewRow row in this.dgRoomsList.Rows)
            {
                if (row.Cells["tcDormID"].Value != null)
                {
                    row.Cells["tcDormName"].Value = (oListDorm.Find (info => (info.DormID == new Guid (row.Cells["tcDormID"].Value.ToString ( )))) ?? new Dorm ( )).DormNumber;
                }
            }
        }
        /// <summary>
        /// 判断是不是有选择
        /// </summary>
        /// <returns></returns>
        private bool HasCheckBoxSelect ( )
        {
            bool blChecked = false;

            foreach (DataGridViewRow row in dgRoomsList.Rows)
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

        private void DormRoomList_Load ( object sender, EventArgs e )
        {
            this.dgRoomsList.AutoGenerateColumns = false;

            LoadBase ( );

            LoadData ( );
        }

        private void btnSearch_Click ( object sender, EventArgs e )
        {
            this.LoadData ( );
            //string strCondition = string.Empty;

            //if (cmbDorm.SelectedValue != null && (Guid)cmbDorm.SelectedValue != Guid.Empty)
            //{
            //    strCondition = " guDormID='" + cmbDorm.SelectedValue + "'";
            //}

            //if (txtRoomName.TextValue.Length > 0)
            //{
            //    strCondition = string.Format ("{0}{1}", strCondition.Length > 0 ? strCondition + " AND " : string.Empty, "nvcRoomNumber='" + txtRoomName.TextValue.Replace ("'", "") + "'");
            //}

            //dgRoomsList.DataSource = oDataTableRooms.Select (strCondition);
            //SetGridViewDormName ( );
        }

        private void btnAdd_Click ( object sender, EventArgs e )
        {
            SaveDormRoom oSaveDormRoom = new SaveDormRoom ( );

            oSaveDormRoom.ShowDialog ( );

            this.LoadData ( );
        }

        private void btnEdit_Click ( object sender, EventArgs e )
        {
            if (!CommonMethod.CheckDataGridViewSelectItems (this.dgRoomsList, "tcCheck"))
            {
                CommonMethod.ShowWaringMessage ("请选择要编辑的项");
                return;
            }
            SaveDormRoom oSaveDormRoom = new SaveDormRoom ( ) { RoomID = (Guid)this.dgRoomsList.SelectedRows[0].Cells["tcRoomID"].Value };

            oSaveDormRoom.ShowDialog ( );

            this.LoadData ( );
        }

        private void btnDel_Click ( object sender, EventArgs e )
        {
            if (!CommonMethod.CheckDataGridViewSelectItems (this.dgRoomsList, "tcCheck"))
            {
                CommonMethod.ShowWaringMessage ("请选择要删除的项");
                return;
            }
            if (DialogResult.No == MessageBox.Show ("确定要删除所有选项吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                return;
            }

            foreach (DataGridViewRow row in this.dgRoomsList.Rows)
            {
                if (row.Cells["tcCheck"].Value != null && (bool)row.Cells["tcCheck"].Value)
                {
                    DormRoomManager.DeleteDormRooms ((Guid)row.Cells["tcRoomID"].Value);
                }
            }

            CommonMethod.ShowWaringMessage ("所选信息已删除");

            this.LoadData ( );
        }

        private void dgRoomsList_CellDoubleClick ( object sender, DataGridViewCellEventArgs e )
        {
            SaveDormRoom oSaveDormRoom = new SaveDormRoom ( ) { RoomID = new Guid (this.dgRoomsList.CurrentRow.Cells["tcRoomID"].Value.ToString ( )) };

            oSaveDormRoom.ShowDialog ( );
            this.LoadData ( );
        }

        private void dgRoomsList_DataBindingComplete ( object sender, DataGridViewBindingCompleteEventArgs e )
        {
            SetGridViewDormName ( );
        }

    }
}
