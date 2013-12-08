using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Monitor.Manager.StudentForm;
using Monitor.Component.BLL;
using Monitor.Component.Model;
using System.Collections;

namespace Monitor.Manager.DormForm
{
    public partial class ImportDorm : Form
    {
        public ImportDorm()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string dormName = string.Empty;
            string previousDormName = string.Empty;
            string roomNumber = string.Empty;
            short iFlool = 1;
            Guid dormID;
            bool improtSuccess = true;
            Hashtable ohashTable = new Hashtable();
            int importCount = 0;
            foreach (DataGridViewRow row in this.dgList.Rows)
            {

                dormName = row.Cells[0].Value.ToString();
                short.TryParse(row.Cells[2].Value.ToString(), out iFlool);

                if (!ohashTable.Contains(dormName))
                {
                    dormID = Guid.NewGuid();
                    ohashTable.Add(previousDormName, dormID);
                    if (!DormManager.SaveDorm(new Component.Model.Dorm { DormID = dormID, AddDate = DateTime.Now, Flools = iFlool, DormNumber = dormName }))
                    {
                        improtSuccess = false;
                        MessageBox.Show(string.Format("导入公寓信息失败，导入失败。当前导入的公寓名称：{0}{1}需要导入：｛2｝条，实际成功导入：{3}条", dormName, Environment.NewLine, this.dgList.Rows.Count, importCount));
                        break;
                    }
                }
                else
                {
                    dormID = (Guid)ohashTable[dormName];
                }


                roomNumber = row.Cells[1].Value.ToString();

                if (!DormRoomManager.SaveDormRooms(new Component.Model.DormRooms { AddDate = DateTime.Now, DormID = dormID, RoomID = Guid.NewGuid(), RoomNumber = roomNumber }))
                {
                    improtSuccess = false;
                    MessageBox.Show(string.Format("执行到以下信息时出错，你可以将当前信息以前的信息去除再次导入。{0} 公寓：{1} 宿舍：{2}{0}需要导入：｛3｝条，实际成功导入：{4}条", Environment.NewLine, dormName, roomNumber, this.dgList.Rows.Count, importCount));
                    break;
                }
                importCount++;
            }

            if (improtSuccess)
            {
                MessageBox.Show(string.Format("信息导入成功", Environment.NewLine, dormName, roomNumber));

            }
        }

        private void btnBrower_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK != this.openFileDialog1.ShowDialog())
            {
                return;
            }

            this.textBox1.Text = this.openFileDialog1.FileName;
            try
            {
                string sql = "select * from [公寓宿舍$]";

                using (OleDbDataAdapter myCommand = new OleDbDataAdapter(sql, string.Format(ImportStudentInfo.strCon, this.textBox1.Text)))
                {
                    DataSet ds = new DataSet();
                    myCommand.Fill(ds);

                    dgList.DataSource = ds.Tables[0];
                    int rows = ds.Tables[0].Rows.Count;

                    lblInfo.Text = "总计： " + ds.Tables[0].Rows.Count.ToString() + " 条信息";

                    btnImport.Visible = ds.Tables[0].Rows.Count > 0;
                }

            }
            catch (Exception ex)
            {
                btnImport.Visible = false;
                MessageBox.Show("出错了.原因:" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
