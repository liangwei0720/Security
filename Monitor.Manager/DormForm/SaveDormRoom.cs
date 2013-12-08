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
    public partial class SaveDormRoom : Form
    {
        #region 变量
        DormRooms oRoom = new DormRooms ( );
        public Guid RoomID { get; set; }
        #endregion

        #region 方法
        public SaveDormRoom ( )
        {
            InitializeComponent ( );
        }

        private void LoadBase ( )
        {
            cmbDormList.ValueMember = "DormID";
            cmbDormList.DisplayMember = "DormNumber";
            cmbDormList.DataSource = DormManager.GetAllDormWithList ( );
        }

        private void LoadData ( )
        {
            if (RoomID == Guid.Empty)
            {
                return;
            }
            oRoom = DormRoomManager.GetDormRooms (RoomID);

            if (oRoom == null)
            {
                return;
            }

            this.cmbDormList.SelectedValue = oRoom.DormID;
            this.txtRoomName.TextValue = oRoom.RoomNumber;

            this.Text = this.labTitle.Text = "编辑宿舍信息";


        }
        #endregion

        private void btnCancel_Click ( object sender, EventArgs e )
        {
            this.Close ( );
        }

        private void btnSubmit_Click ( object sender, EventArgs e )
        {
            if (oRoom.RoomID == Guid.Empty)
            {
                oRoom.RoomID = Guid.NewGuid ( );
                oRoom.AddDate = DateTime.Now;
            }

            if (this.txtRoomName.TextValue.Length == 0)
            {
                CommonMethod.ShowWaringMessage ("请输入宿舍名称");
                this.txtRoomName.Focus ( );
                return;
            }
            else if (oRoom.RoomID == Guid.Empty)
            {
                DataTable dt = DormRoomManager.GetDormRoomsByCondtion (string.Format ("guDormID='{0}' AND nvcRoomNumber='{1}'", cmbDormList.SelectedValue, this.txtRoomName.TextValue));
                if (dt != null && dt.Rows.Count > 0)
                {
                    CommonMethod.ShowWaringMessage ("该公寓里已存在此名称的宿舍");
                    this.txtRoomName.Focus ( );
                    return;
                }
            }



            oRoom.DormID = (Guid)cmbDormList.SelectedValue;
            oRoom.RoomNumber = txtRoomName.TextValue;

            if (DormRoomManager.SaveDormRooms (oRoom))
            {
                if (RoomID == Guid.Empty)
                {
                    if (DialogResult.Yes == MessageBox.Show ("信息添加成功。是否继续添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                    {
                        oRoom = new DormRooms ( );
                        txtRoomName.TextValue = string.Empty;
                    }
                    else
                    {
                        this.Close ( );
                    }
                }
                else
                {
                    MessageBox.Show ("信息提交成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close ( );
                }
            }
            else
            {
                MessageBox.Show ("信息提交失败，请稍候再试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveDormRoom_Load ( object sender, EventArgs e )
        {
            LoadBase ( );

            LoadData ( );
        }
    }
}
