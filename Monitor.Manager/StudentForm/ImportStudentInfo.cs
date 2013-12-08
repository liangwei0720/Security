using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Monitor.Component.Model;
using Monitor.Component.BLL;

namespace Monitor.Manager.StudentForm
{
    public partial class ImportStudentInfo : Form
    {
        public static string strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source ={0};Extended Properties=Excel 8.0";
        DataTable dtDormRooms = DormRoomManager.GetDormRoomsByCondtion("");

        public ImportStudentInfo()
        {
            InitializeComponent();

            if (dtDormRooms == null || dtDormRooms.Rows.Count == 0)
            {
                CommonMethod.ShowWaringMessage("基础数据【公寓信息】未设置，请先设置基础数据。");
            }
        }

        private void btnBrower_Click(object sender, EventArgs e)
        {
            if (dtDormRooms == null || dtDormRooms.Rows.Count == 0)
            {
                CommonMethod.ShowWaringMessage("基础数据【公寓信息】未设置，请先设置基础数据。");
                return;
            }

            if (DialogResult.OK != this.openFileDialog1.ShowDialog())
            {
                return;
            }

            this.textBox1.Text = this.openFileDialog1.FileName;

            try
            {
                string sql = "select * from [学生信息$]";

                using (OleDbDataAdapter myCommand = new OleDbDataAdapter(sql, string.Format(strCon, this.textBox1.Text)))
                {
                    DataSet ds = new DataSet();
                    myCommand.Fill(ds);

                    dgList.DataSource = ds.Tables[0];
                    int rows = ds.Tables[0].Rows.Count;

                    lblInfo.Text = "总计： " + ds.Tables[0].Rows.Count.ToString() + " 条信息";

                    btnImport.Visible = ds.Tables[0].Rows.Count > 0;
                }

            }
            catch
            {
                MessageBox.Show("你的数据模板不正确，无法完成数据的导入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (dtDormRooms == null || dtDormRooms.Rows.Count == 0)
            {
                CommonMethod.ShowWaringMessage("基础数据【公寓信息】未设置，请先设置基础数据。");
                return;
            }

            if (DialogResult.No == MessageBox.Show("确定要将当前信息导入数据库吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                return;
            }
            try
            {
                List<Dorm> olstDrom = DormManager.GetAllDormWithList();

                List<Students> oListStudents = new StudentManager().GetAllStudents("");

                Students oStudent;
                DataRow[] roomID;
                Guid studentID;
                Dorm findDorm;
                bool importSuccess = true;

                foreach (DataGridViewRow row in this.dgList.Rows)
                {
                    findDorm = olstDrom.Find(dorm => dorm.DormNumber == row.Cells["所在公寓"].Value.ToString());
                    if (findDorm == null)
                    {
                        MessageBox.Show("未找到公寓名称为：" + row.Cells["所在公寓"].Value.ToString() + " 的信息，请确认信息是否存在。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        importSuccess = false;
                        break;
                    }
                    studentID = Guid.NewGuid();
                    roomID = dtDormRooms.Select("nvcRoomNumber='" + row.Cells["所在宿舍"].Value.ToString() + "'");
                    if (roomID == null)
                    {
                        CommonMethod.ShowWaringMessage(string.Format("未找到学生 {0} 所在宿舍 {1}，请更改此信息，然后重新执行导入操作。", row.Cells["姓名"].Value, row.Cells["宿舍"].Value));
                        importSuccess = false;
                        break;
                    }
                    oStudent = oListStudents.Find(info => info.StudentNumber == row.Cells["学号"].Value.ToString().Trim());
                    if (oStudent != null)
                    {
                        if (DialogResult.No == MessageBox.Show(string.Format("已存在学号：{0} 的学生。\r\n\r\n如果要更新原信息请点击\"是\",放弃当前数据请点击\"否\"", row.Cells["学号"].Value), "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            continue;
                        }

                        studentID = oStudent.StudentID;
                    }

                    oStudent = new Students()
                    {
                        AddDate = DateTime.Now,
                        ClassName = row.Cells["班级"].Value.ToString(),
                        FacultyName = row.Cells["院系"].Value.ToString(),
                        Gender = row.Cells["性别"].Value.ToString() == "男" ? 1 : 2,
                        Mobile = row.Cells["联系方式"].Value.ToString(),
                        SchoolYear = Convert.ToInt16(row.Cells["学制"].Value),
                        Specialty = row.Cells["专业"].Value.ToString(),
                        StartSchoolYear = row.Cells["入学时间"].Value.ToString(),
                        StudentID = studentID,
                        StudentName = row.Cells["姓名"].Value.ToString(),
                        StudentNumber = row.Cells["学号"].Value.ToString(),
                        RoomID = new Guid(roomID[0]["guRoomID"].ToString())

                    };
                    new StudentManager().AddStudent(oStudent);
                }

                CommonMethod.ShowWaringMessage(importSuccess ? "数据导入成功" : "数据导入失败");
            }
            catch (Exception ex)
            {
                // CommonMethod.ShowWaringMessage ("数据导入失败，请重试。");
                throw ex;
            }
        }
    }
}
