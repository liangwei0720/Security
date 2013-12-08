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
    public partial class StudentList : Form
    {
        #region 变量
        private List<Students> oList = new StudentManager().GetAllStudents("");
        private int currentIndex = 0;

        private List<Dorm> olstDrom = DormManager.GetAllDormWithList();
        private List<DormRooms> olstDromRoom = DormRoomManager.GetAllDormRooms();

        private DormRooms oDormRoom;
        private Dorm oDorm;
        List<Server> olstServer;
        #endregion

        #region 方法
        public StudentList()
        {
            InitializeComponent();

            olstDrom.Insert(0, new Dorm() { DormID = Guid.Empty, DormNumber = "请选择" });

            cmbDorm.ValueMember = "DormID";
            cmbDorm.DisplayMember = "DormNumber";
            cmbDorm.DataSource = olstDrom;
        }

        private void LoadData()
        {
            List<Students> oListSearch = new List<Students>(oList);

            if (cmbDorm.SelectedValue != null && (Guid)cmbDorm.SelectedValue != Guid.Empty)
            {
                oListSearch = new List<Students>();

                if (cmbDormRoom.SelectedValue != null && (Guid)cmbDormRoom.SelectedValue != Guid.Empty)
                {
                    oListSearch = oList.FindAll(info => info.RoomID.ToString().Equals(cmbDormRoom.SelectedValue.ToString(), StringComparison.OrdinalIgnoreCase));
                }
                else
                {
                    List<DormRooms> olstRoom = olstDromRoom.FindAll(info => info.DormID.ToString().Equals(cmbDorm.SelectedValue.ToString(), StringComparison.OrdinalIgnoreCase));
                    Students currentStudent;
                    foreach (DormRooms room in olstRoom)
                    {
                        currentStudent = oList.Find(info => info.RoomID.ToString().Equals(room.DormID.ToString(), StringComparison.OrdinalIgnoreCase));
                        if (currentStudent != null)
                            oListSearch.Add(currentStudent);
                    }
                }
            }


            foreach (var student in oListSearch)
            {
                student.DormAndRoom = student.StudentName;
                currentIndex++;
                student.StudentIndex = currentIndex;
                oDormRoom = olstDromRoom.Find(info => info.RoomID.ToString().Equals(student.RoomID.ToString(), StringComparison.OrdinalIgnoreCase));
                if (oDormRoom != null)
                {
                    oDorm = olstDrom.Find(infoDorm => infoDorm.DormID.ToString().Equals(oDormRoom.DormID.ToString(), StringComparison.OrdinalIgnoreCase));

                    if (oDorm != null)
                    {
                        student.DormAndRoom = string.Format("{0}[{1}-{2}]", student.StudentName, oDorm.DormNumber, oDormRoom.RoomNumber);
                    }
                }
            }

            dgStudentsList.DataSource = oList;

            currentIndex = 0;
        }

        private bool CheckSelectedItems
        {
            get
            {
                bool blSelected = false;
                foreach (DataGridViewRow row in dgStudentsList.Rows)
                {
                    if (row.Cells["tcCheck"].Value != null && (bool)row.Cells["tcCheck"].Value)
                    {
                        blSelected = true;
                        break;
                    }
                }
                return blSelected;
            }
        }

        private void ShowSaveStudentForm(string strStudentNumber)
        {
            SaveStudent oSaveStudent = new SaveStudent() { StudentNumber = strStudentNumber };

            oSaveStudent.ShowDialog();
        }
        #endregion


        #region 事件
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Students> oFindList = new List<Students>(oList);


            if (txtStudentName.TextValue.Length > 0 && txtStudentNumber.TextValue.Length > 0)
            {
                oFindList = oList.FindAll(info => (info.StudentName.Contains(txtStudentName.TextValue) || info.StudentNumber.Contains(txtStudentNumber.TextValue)));
            }
            else if (txtStudentNumber.TextValue.Length > 0)
            {
                oFindList = oList.FindAll(info => info.StudentNumber.Contains(txtStudentNumber.TextValue));
            }
            else if (txtStudentName.TextValue.Length > 0)
            {
                oFindList = oList.FindAll(info => info.StudentName.Contains(txtStudentName.TextValue));
            }
            foreach (var student in oFindList)
            {
                student.DormAndRoom = student.StudentName;
                currentIndex++;
                student.StudentIndex = currentIndex;
                oDormRoom = olstDromRoom.Find(info => info.RoomID.ToString().Equals(student.RoomID.ToString(), StringComparison.OrdinalIgnoreCase));
                if (oDormRoom != null)
                {
                    oDorm = olstDrom.Find(infoDorm => infoDorm.DormID.ToString().Equals(oDormRoom.DormID.ToString(), StringComparison.OrdinalIgnoreCase));

                    if (oDorm != null)
                    {
                        student.DormAndRoom = string.Format("{0}[{1}-{2}]", student.StudentName, oDorm.DormNumber, oDormRoom.RoomNumber);
                    }
                }
            }
            currentIndex = 0;

            dgStudentsList.DataSource = oFindList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowSaveStudentForm(null);

            this.LoadData();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            dgStudentsList.AutoGenerateColumns = false;
            LoadData();
        }

        private void dgStudentsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            ShowSaveStudentForm(dgStudentsList.CurrentRow.Cells["tcNumber"].Value.ToString());

            this.LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!CheckSelectedItems)
            {
                MessageBox.Show("请选择要编辑的项", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string strStudentID = null;

            foreach (DataGridViewRow row in dgStudentsList.Rows)
            {
                if (row.Cells["tcCheck"].Value != null)
                {
                    strStudentID = row.Cells["tcNumber"].Value.ToString();
                    break;
                }
            }

            ShowSaveStudentForm(strStudentID);

            this.LoadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!CheckSelectedItems)
            {
                MessageBox.Show("请选择要删除的项", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DialogResult.No == MessageBox.Show("确定要删除所选的信息吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                return;
            }
            if (olstServer == null)
            {
                olstServer = ServerManager.GetAllServer();
            }
            Guid strStudentID;
            DormRooms currentRoom;
            Server currentServer;
            foreach (DataGridViewRow row in dgStudentsList.Rows)
            {
                if (row.Cells["tcCheck"].Value != null)
                {
                    strStudentID = new Guid(row.Cells["tcStudentID"].Value.ToString());
                    currentRoom = olstDromRoom.Find(room => room.RoomID.ToString().Equals(oList.Find(info => info.StudentID.ToString().Equals(strStudentID.ToString(), StringComparison.OrdinalIgnoreCase))));
                    currentServer = olstServer.Find(server => server.GuDormID.ToString().Equals(currentRoom.DormID.ToString(), StringComparison.OrdinalIgnoreCase));

                    if (currentServer != null)
                    {
                        new StudentManager().DeleteStudents(strStudentID, currentServer.Connection);
                        continue;
                    }

                    new StudentManager().DeleteStudents(strStudentID);
                }
            }

            MessageBox.Show("所选信息已删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.LoadData();

        }
        #endregion

        private void cmbDorm_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDormRoom.DataSource = null;
            cmbDormRoom.Items.Clear();
            cmbDormRoom.Items.Add("请选择");

            if ((Guid)cmbDorm.SelectedValue != Guid.Empty)
            {
                cmbDormRoom.ValueMember = "guRoomID";
                cmbDormRoom.DisplayMember = "nvcRoomNumber";
                DataTable table = DormRoomManager.GetDormRoomsByCondtion(string.Format(" guDormID='{0}'", cmbDorm.SelectedValue));
                //增加一个选择项
                DataRow dataRow = table.NewRow();
                dataRow["guRoomID"] = Guid.Empty;
                dataRow["nvcRoomNumber"] = "请选择";
                table.Rows.InsertAt(dataRow, 0);

                cmbDormRoom.DataSource = table;
            }

            cmbDormRoom.SelectedIndex = cmbDormRoom.FindString("请选择");

            if (cmbDorm.SelectedValue != null && cmbDorm.SelectedValue.ToString() != Guid.Empty.ToString())
            {
                LoadData();
            }
        }

        private void cmbDormRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
