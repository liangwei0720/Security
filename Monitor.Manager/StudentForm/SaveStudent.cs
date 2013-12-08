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
using System.IO;
using System.Drawing.Imaging;
using System.Threading;

namespace Monitor.Manager.StudentForm
{
    public partial class SaveStudent : Form
    {
        #region 变量
        private Students oStudents = new Students ( );

        /// <summary>
        /// 学号
        /// </summary>
        public string StudentNumber
        {
            get;
            set;
        }

        private string strStudentNumber = string.Empty;
        #endregion

        #region 方法
        public SaveStudent ( )
        {
            InitializeComponent ( );
            //rbtnFemale.
        }
        /// <summary>
        /// 加载实体数据
        /// </summary>
        private void LoadData ( )
        {
            if (string.IsNullOrEmpty (StudentNumber))
            {
                return;
            }

            oStudents = new StudentManager ( ).GetStudent (StudentNumber);

            if (oStudents == null)
            {
                MessageBox.Show ("信息不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close ( );
            }

            SetContronValue ( );
        }

        /// <summary>
        /// 为控件赋值
        /// </summary>
        private void SetContronValue ( )
        {
            txtClassName.TextValue = oStudents.ClassName;
            txtFaculty.TextValue = oStudents.FacultyName;
            txtMobile.TextValue = oStudents.Mobile;
            txtName.TextValue = oStudents.StudentName;
            txtNumber.TextValue = oStudents.StudentNumber;
            txtSchoolYear.TextValue = oStudents.SchoolYear.ToString ( );
            txtSpecialty.TextValue = oStudents.Specialty;
            dtpStartDate.Value = DateTime.Parse (oStudents.StartSchoolYear);

            cmbDorm.SelectedValue = (DormRoomManager.GetDormRooms (oStudents.RoomID) ?? new DormRooms ( )).DormID;

            cmbDormRoom.SelectedValue = oStudents.RoomID;


            rbtnMale.Checked = (oStudents.Gender == 1);
            rbtnFemale.Checked = oStudents.Gender == 2;

            if (oStudents.Image != null && oStudents.Image.Length > 0)
            {
                SetImageToPicture (oStudents.Image);
            }

            this.Text = this.lblTitle.Text = "编辑学生信息";

        }

        /// <summary>
        /// 加载基本数据
        /// </summary>
        private void LoadBase ( )
        {

            List<Dorm> oList = DormManager.GetAllDormWithList ( );
            oList.Insert (0, new Dorm ( ) { DormID = Guid.Empty, DormNumber = "请选择" });

            cmbDorm.ValueMember = "DormID";
            cmbDorm.DisplayMember = "DormNumber";
            cmbDorm.DataSource = oList;

            //cmbDormRoom.DataSource = DormRoomManager.GetDormRoomsByCondtion ("guDoomID=" + cmbDorm.SelectedValue.ToString ( ));
        }
        /// <summary>
        /// 获取用户上传的图片信息
        /// </summary>
        /// <returns></returns>
        private byte[] GetImage ( )
        {
            if (this.textBox1.Text.Trim ( ).Length == 0)
            {
                return null;
            }
            try
            {
                FileInfo fi = new FileInfo (this.textBox1.Text);
                long imgLength = fi.Length;

                //将图片转为2进制保存
                MemoryStream stream = new MemoryStream ( );
                Image.FromFile (this.textBox1.Text).Save (stream, ImageFormat.Bmp);
                byte[] byteImage = new byte[imgLength];
                byteImage = stream.ToArray ( );

                return byteImage;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// 为图片控件赋值
        /// </summary>
        /// <param name="byteImage"></param>
        private void SetImageToPicture ( byte[] byteImage )
        {
            try
            {
                MemoryStream stream = new MemoryStream ( );
                stream.Write (byteImage, 0, byteImage.Length);
                this.pictureLogo.Image = Image.FromStream (stream);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 清空当前页面上所有TextBox的Text属性
        /// </summary>
        private void ClearControlValue ( )
        {
            foreach (Control control in this.Controls)
            {
                if ((control as TextBox) != null)
                {
                    control.Text = string.Empty;
                }
                else if ((control as UserTextBox) != null)
                {
                    UserTextBox utb = (UserTextBox)control;
                    utb.TextValue = string.Empty;
                }
            }
        }
        #endregion

        #region 事件
        private void SaveStudent_Load ( object sender, EventArgs e )
        {

            LoadBase ( );
            LoadData ( );
        }


        private void btnCancle_Click ( object sender, EventArgs e )
        {
            this.Close ( );
        }

        private void cmbDorm_SelectedIndexChanged ( object sender, EventArgs e )
        {
            if ((Guid)cmbDorm.SelectedValue != Guid.Empty)
            {
                cmbDormRoom.ValueMember = "guRoomID";
                cmbDormRoom.DisplayMember = "nvcRoomNumber";
                cmbDormRoom.DataSource = DormRoomManager.GetDormRoomsByCondtion (string.Format (" guDormID='{0}'", cmbDorm.SelectedValue));
            }
            else
            {
                cmbDormRoom.Items.Clear ( );
            }
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            if (this.openFileDialog1.ShowDialog ( ) == DialogResult.OK)
            {
                this.textBox1.Text = this.openFileDialog1.FileName;
                this.pictureLogo.ImageLocation = this.textBox1.Text;
            }
        }

        private void btnSubmit_Click ( object sender, EventArgs e )
        {
            if (!string.IsNullOrEmpty (strStudentNumber))
            {
                CommonMethod.ShowWaringMessage ("数据库中已存在此学号的学生。");
                this.txtNumber.Focus ( );
                return;
            }

            if (this.txtName.TextValue.Length == 0)
            {
                CommonMethod.ShowWaringMessage ("请输入学生的姓名。");
                this.txtName.Focus ( );
                return;
            }

            if (this.txtNumber.TextValue.Length == 0)
            {
                CommonMethod.ShowWaringMessage ("请输入学生的学号。");
                this.txtNumber.Focus ( );
                return;
            }
            if (this.txtClassName.TextValue.Length == 0)
            {
                CommonMethod.ShowWaringMessage ("请输入学生所在班级。");
                this.txtClassName.Focus ( );
                return;
            }
            if (this.txtSpecialty.TextValue.Length == 0)
            {
                CommonMethod.ShowWaringMessage ("请输入学生所学专业。");
                this.txtSpecialty.Focus ( );
                return;
            }
            if (this.txtSchoolYear.TextValue.Length == 0)
            {
                CommonMethod.ShowWaringMessage ("请输入学生学制。");
                this.txtSchoolYear.Focus ( );
                return;
            }
            if ((Guid)cmbDorm.SelectedValue == Guid.Empty)
            {
                CommonMethod.ShowWaringMessage ("请选择学生所在公寓");
                cmbDorm.Focus ( );
                return;
            }

            if (cmbDormRoom.SelectedValue == null || (Guid)cmbDormRoom.SelectedValue == Guid.Empty)
            {
                CommonMethod.ShowWaringMessage ("请选择学生所在宿舍");
                cmbDormRoom.Focus ( );
                return;
            }

            oStudents.ClassName = txtClassName.TextValue;
            oStudents.FacultyName = txtFaculty.TextValue;
            oStudents.Gender = rbtnMale.Checked ? 1 : 2;
            if (this.textBox1.Text.Trim ( ).Length > 0)
            {
                oStudents.Image = GetImage ( );
            }
            oStudents.Mobile = txtMobile.TextValue;
            oStudents.Remark = string.Empty;
            oStudents.RoomID = (Guid)cmbDormRoom.SelectedValue;

            int iSchoolYear;
            int.TryParse (txtSchoolYear.TextValue, out iSchoolYear);
            oStudents.SchoolYear = iSchoolYear;
            oStudents.Specialty = txtSpecialty.TextValue;
            oStudents.StartSchoolYear = dtpStartDate.Value.ToString ("yyyy-MM-dd");


            if (oStudents.StudentID == Guid.Empty)
            {
                oStudents.StudentID = Guid.NewGuid ( );
                oStudents.AddDate = DateTime.Now;
            }
            oStudents.StudentName = txtName.TextValue;
            oStudents.StudentNumber = txtNumber.TextValue;

            if (new StudentManager ( ).AddStudent (oStudents))
            {
                if (string.IsNullOrEmpty (StudentNumber))
                {
                    if (DialogResult.Yes == MessageBox.Show ("信息提交成功", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                    {
                        oStudents = new Students ( );
                        ClearControlValue ( );
                        txtName.Focus ( );
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
                MessageBox.Show ("信息提交失败，请稍候再试", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNumber_Leave ( object sender, EventArgs e )
        {
            if (!strStudentNumber.Equals (this.txtNumber.TextValue))
            {
                Students os = new StudentManager ( ).GetStudent (this.txtNumber.TextValue);

                if (os != null)
                {
                    CommonMethod.ShowWaringMessage ("数据库中已存在此学号的学生。");
                    strStudentNumber = this.txtNumber.TextValue;
                    this.txtNumber.Focus ( );
                }
                else
                {
                    strStudentNumber = string.Empty;
                }

            }
        }
        #endregion




    }
}
