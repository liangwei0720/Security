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

namespace Monitor.Manager.StudentForm
{
    public partial class SelectStudent : Form
    {
        List<Students> oList = new List<Students> ( );
        public SelectStudent ( )
        {
            InitializeComponent ( );
        }

        private void btnSearch_Click ( object sender, EventArgs e )
        {
            string strCondition = string.Empty;

            if (txtStudentNumber.TextValue.Length > 0)
            {
                strCondition = " nvcStudentNumber='" + txtStudentNumber.TextValue.Replace ("'", "") + "'";
            }
            if (txtName.TextValue.Length > 0)
            {
                strCondition = string.Format ("{0}{1}", strCondition == string.Empty ? string.Empty : strCondition + " AND ", " nvcStudentName ='" + txtName.TextValue.Replace ("'", "") + "'");
            }
            oList = new StudentManager ( ).GetAllStudents (strCondition);

            dgList.DataSource = oList;
        }

        private void btnCancel_Click ( object sender, EventArgs e )
        {
            this.Close ( );
        }

        private void btnOK_Click ( object sender, EventArgs e )
        {
            try
            {
                if (this.dgList.SelectedRows.Count > 0)
                {
                    //返回选中行的学生信息
                    SaveGoods.StudentInfo = oList.Find (info => info.StudentNumber == this.dgList.SelectedRows[0].Cells["tcStudentNumber"].Value.ToString ( ));
                   
                    this.Close ( );
                }
                else
                {
                    MessageBox.Show (this, "请至少选中一条学生信息。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }

        private void dgList_DoubleClick ( object sender, EventArgs e )
        {
            try
            {
                //如果当前有选中行，则返回选中行
                if (this.dgList.SelectedRows.Count > 0)
                {
                    SaveGoods.StudentInfo = oList.Find (info => info.StudentNumber == this.dgList.SelectedRows[0].Cells["tcStudentNumber"].Value.ToString ( ));
                    this.Close ( );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }

        private void SelectStudent_Load ( object sender, EventArgs e )
        {
            this.dgList.AutoGenerateColumns = false;
        }
    }
}
