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

namespace Monitor.Manager.StudentForm
{
    public partial class GoodsList : Form
    {
        #region 变量
        List<Goods> oList = new List<Goods> ( );

        List<Goods> oListSearchGoods = new List<Goods> ( );

        Guid oGoodsID = Guid.Empty;
        List<Dorm> oListDorm = new List<Dorm> ( );
        int currentIndex = 0;
        #endregion

        #region 方法
        public GoodsList ( )
        {
            InitializeComponent ( );

            dgGoodsList.AutoGenerateColumns = false;

            oListDorm = DormManager.GetAllDormWithList ( );
            oListDorm.Insert (0, new Dorm ( ) { DormID = Guid.Empty, DormNumber = "请选择" });

            cmbDorm.ValueMember = "DormID";
            cmbDorm.DisplayMember = "DormNumber";
            cmbDorm.DataSource = oListDorm;

        }

        private void cmbDorm_SelectedIndexChanged ( object sender, EventArgs e )
        {
            cmbDormRoom.DataSource = null;
            cmbDormRoom.Items.Clear ( );
            cmbDormRoom.Items.Add ("请选择");

            if ((Guid)cmbDorm.SelectedValue != Guid.Empty)
            {
                cmbDormRoom.ValueMember = "guRoomID";
                cmbDormRoom.DisplayMember = "nvcRoomNumber";
                DataTable table = DormRoomManager.GetDormRoomsByCondtion (string.Format (" guDormID='{0}'", cmbDorm.SelectedValue));
                //增加一个选择项
                DataRow dataRow = table.NewRow ( );
                dataRow["guRoomID"] = Guid.Empty;
                dataRow["nvcRoomNumber"] = "请选择";
                table.Rows.InsertAt (dataRow, 0);

                cmbDormRoom.DataSource = table;
            }

            cmbDormRoom.SelectedIndex = cmbDormRoom.FindString ("请选择");

            if (cmbDorm.SelectedValue != null && cmbDorm.SelectedValue.ToString ( ) != Guid.Empty.ToString ( ))
            {
                LoadSearchData ( );
            }

        }

        private void LoadSearchData ( )
        {
            this.dgGoodsList.DataSource = null;
            oListSearchGoods.Clear ( );
            Guid roomID;

            if (cmbDorm.SelectedValue == null || (Guid)cmbDorm.SelectedValue == Guid.Empty)
            {
                oListSearchGoods = new List<Goods> (oList);
                oListSearchGoods.ForEach (
                    info =>
                    {
                        currentIndex++;
                        info.GoodsIndex = currentIndex.ToString ( );
                        info.AllInfo = string.Format ("{0}[{1}{2}]", info.StudentNumber, info.StudentsName, GetDormAndRoomName (info.StudentNumber));
                    });



            }
            else if (cmbDormRoom.SelectedValue == null || (Guid)cmbDormRoom.SelectedValue == Guid.Empty)
            {
                foreach (var goods in oList)
                {
                    roomID = GetRoomID (goods.StudentNumber);

                    if (roomID == Guid.Empty)
                    {
                        continue;
                    }
                    foreach (var dormRoom in cmbDormRoom.Items)
                    {
                        if (roomID.ToString ( ).Equals (((DataRowView)dormRoom)["guRoomID"].ToString ( ), StringComparison.OrdinalIgnoreCase))
                        {
                            currentIndex++;
                            goods.GoodsIndex = currentIndex.ToString ( );
                            goods.AllInfo = string.Empty;

                            goods.AllInfo = string.Format ("{0}[{1}{2}]", goods.StudentNumber, goods.StudentsName, GetDormAndRoomName (goods.StudentNumber));

                            oListSearchGoods.Add (goods);
                            break;
                        }

                    }

                }

            }
            else
            {
                foreach (var goods in oList)
                {
                    roomID = GetRoomID (goods.StudentNumber);

                    if (roomID == Guid.Empty || roomID != (Guid)cmbDormRoom.SelectedValue)
                    {
                        continue;
                    }

                    currentIndex++;
                    goods.GoodsIndex = currentIndex.ToString ( );
                    goods.AllInfo = string.Empty;

                    goods.AllInfo = string.Format ("{0}[{1}{2}]", goods.StudentNumber, goods.StudentsName, GetDormAndRoomName (goods.StudentNumber));

                    oListSearchGoods.Add (goods);
                }
            }

            this.dgGoodsList.DataSource = oListSearchGoods;
            currentIndex = 0;
        }

        private void LoadData ( )
        {
            this.dgGoodsList.AutoGenerateColumns = false;

            oList = new GoodsManager ( ).GetGoodsByCondition ("iStatus<" + short.MaxValue.ToString ( ));
            oListSearchGoods = new List<Goods> (oList);

            oListSearchGoods.ForEach (info =>
                {
                    currentIndex++;
                    info.GoodsIndex = currentIndex.ToString ( );
                    info.AllInfo = string.Format ("{0}[{1}{2}]", info.StudentNumber, info.StudentsName, GetDormAndRoomName (info.StudentNumber));
                });
            this.dgGoodsList.DataSource = oListSearchGoods;

            currentIndex = 0;
        }

        private Guid GetRoomID ( string studentNumber )
        {
            Students ostudents = new StudentManager ( ).GetStudent (studentNumber);
            if (ostudents == null)
            {
                return Guid.Empty;
            }

            return ostudents.RoomID;
        }

        private string GetDormAndRoomName ( string studentNumber )
        {
            Students ostudents = new StudentManager ( ).GetStudent (studentNumber);
            if (ostudents == null)
            {
                return string.Empty;
            }

            var dormRoom = (DormRoomManager.GetDormRooms (ostudents.RoomID) ?? new DormRooms { RoomNumber = string.Empty });

            return string.Format ("-{1}-{0}", dormRoom.RoomNumber, (oListDorm.Find (info => info.DormID == dormRoom.DormID) ?? new Dorm { DormNumber = string.Empty }).DormNumber);
        }

        /// <summary>
        /// 判断是不是有选择
        /// </summary>
        /// <returns></returns>
        private bool HasCheckBoxSelect ( )
        {
            bool blChecked = false;

            foreach (DataGridViewRow row in dgGoodsList.Rows)
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
            SaveGoods oSaveGoods = new SaveGoods ( );

            oSaveGoods.ShowDialog ( );

            this.LoadSearchData ( );
        }

        private void GoodsList_Load ( object sender, EventArgs e )
        {
            LoadData ( );
        }
        private void ShowSaveStudentForm ( Guid guGoodsID )
        {
            SaveGoods oSaveGoods = new SaveGoods ( ) { GoodsID = guGoodsID };

            oSaveGoods.ShowDialog ( );
        }
        #endregion

        private void btnEdit_Click ( object sender, EventArgs e )
        {
            if (!HasCheckBoxSelect ( ))
            {
                MessageBox.Show ("请选择要编辑的项", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Guid oGoodsID = Guid.Empty;

            foreach (DataGridViewRow row in dgGoodsList.Rows)
            {
                if (row.Cells["tcCheck"].Value != null)
                {
                    oGoodsID = (Guid)row.Cells["tcGoodsID"].Value;
                    break;
                }
            }

            ShowSaveStudentForm (oGoodsID);

            this.LoadSearchData ( );


        }

        private void btnDel_Click ( object sender, EventArgs e )
        {
            if (!HasCheckBoxSelect ( ))
            {
                MessageBox.Show ("请选择要删除的项", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dgGoodsList.Rows)
            {
                if (row.Cells["tcCheck"].Value != null)
                {
                    oGoodsID = (Guid)row.Cells["tcGoodsID"].Value;

                    new GoodsManager ( ).DeletedGoods (oGoodsID);
                }
            }

            MessageBox.Show ("所选择的信息已全部删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.LoadSearchData ( );
        }

        private void dgGoodsList_CellDoubleClick ( object sender, DataGridViewCellEventArgs e )
        {
            if (e.RowIndex < 0)
            {
                return;
            }


            oGoodsID = (Guid)this.dgGoodsList.CurrentRow.Cells["tcGoodsID"].Value;

            ShowSaveStudentForm (oGoodsID);

            this.LoadSearchData ( );
        }

        private void btnSearch_Click ( object sender, EventArgs e )
        {
            if (this.txtGoodsName.TextValue.Length > 0)
            {
                this.dgGoodsList.DataSource = oList.FindAll (info => info.GoodsName.Contains (this.txtGoodsName.TextValue));
            }
            else
            {
                this.LoadData ( );
            }
        }

        private void cmbDormRoom_SelectedIndexChanged ( object sender, EventArgs e )
        {
            LoadSearchData ( );
        }
    }
}
