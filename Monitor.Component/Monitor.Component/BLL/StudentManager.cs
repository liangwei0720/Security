using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Monitor.Component.Model;
using System.Data.SqlClient;
using System.Data;
using Monitor.Component.DAL;

namespace Monitor.Component.BLL
{
    public class StudentManager
    {
        #region 添加学生信息
        /// <summary>
        /// 添加学生信息
        /// </summary>
        /// <param name="oStudent">学生实体对象</param>
        /// <returns></returns>
        public bool AddStudent(Students oStudent)
        {
            return new StudentsDAL().SaveStudents(oStudent) > 0;
        }

        public bool AddStudent(Students oStudents, string clientIPConnection)
        {
            return new StudentsDAL().SaveStudents(oStudents, clientIPConnection) > 0;
        }
        #endregion

        #region 根据条件获以学生信息
        /// <summary>
        /// 根据条件获以学生信息
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<Students> GetAllStudents(string condition)
        {
            if (string.IsNullOrEmpty(condition))
            {
                condition = "1=1";
            }

            List<Students> oList = new List<Students>();

            DataTable dt = new StudentsDAL().GetAllStudent(condition);

            foreach (DataRow row in dt.Rows)
            {
                oList.Add(ParseModel(row));
            }

            return oList;

        }
        #endregion

        #region 获取学生信息
        /// <summary>
        /// 获取学生信息
        /// </summary>
        /// <param name="guStudentID"></param>
        /// <returns></returns>
        public DataTable GetStudent(Guid guStudentID)
        {
            return new StudentsDAL().GetStudent(guStudentID);
        }

        /// <summary>
        /// 获取学生信息
        /// </summary>
        /// <param name="guStudentID"></param>
        /// <returns></returns>
        public Students GetStudent(string studentNumber)
        {
            DataTable odtTable = new StudentsDAL().GetStudent(studentNumber);

            if (odtTable.Rows.Count == 0)
            {
                return null;
            }

            return ParseModel(odtTable.Rows[0]);
        }

        private Students ParseModel(DataRow row)
        {
            Students oStudents = new Students();
            oStudents.StudentID = row["guStudentID"] is DBNull ? Guid.Empty : (Guid)row["guStudentID"];
            oStudents.RoomID = row["guRoomID"] is DBNull ? Guid.Empty : (Guid)row["guRoomID"];
            oStudents.StudentNumber = row["nvcStudentNumber"] is DBNull ? "" : (string)row["nvcStudentNumber"];
            oStudents.StudentName = row["nvcStudentName"] is DBNull ? "" : (string)row["nvcStudentName"];
            oStudents.Image = row["vbinImage"] is DBNull ? null : (byte[])row["vbinImage"];
            oStudents.Mobile = row["nvcMobile"] is DBNull ? "" : (string)row["nvcMobile"];
            oStudents.Remark = row["nvcRemark"] is DBNull ? "" : (string)row["nvcRemark"];
            oStudents.AddDate = row["dtAddDate"] is DBNull ? DateTime.Now : (DateTime)row["dtAddDate"];
            oStudents.CardNumber = row["iCardNumber"] is DBNull ? 0 : (int)row["iCardNumber"];
            oStudents.CardPwd = row["nvcCardPwd"] is DBNull ? "" : (string)row["nvcCardPwd"];
            oStudents.ClassName = row["nvcClassName"] is DBNull ? "" : (string)row["nvcClassName"];
            oStudents.SchoolYear = row["iSchoolYear"] is DBNull ? 0 : (int)row["iSchoolYear"];
            oStudents.Specialty = row["nvcSpecialty"] is DBNull ? "" : (string)row["nvcSpecialty"];
            oStudents.FacultyName = row["nvcFacultyName"] is DBNull ? "" : (string)row["nvcFacultyName"];
            oStudents.StartSchoolYear = row["nvcStartSchoolYear"] is DBNull ? "" : (string)row["nvcStartSchoolYear"];
            oStudents.Gender = row["iGender"] is DBNull ? 0 : (int)row["iGender"];

            return oStudents;

        }
        #endregion

        #region 获取当前学校的所有院系
        /// <summary>
        /// 获取当前学校的所有院系信息
        /// </summary>
        /// <param name="guSchoolID">学校标识</param>
        /// <returns></returns>
        public DataTable GetAllFaculty(Guid guSchoolID)
        {
            return new StudentsDAL().GetAllFaculty(guSchoolID);
        }
        #endregion

        #region 获取当前院系下所有班级信息
        /// <summary>
        /// 获取当前院系下所有班级信息
        /// </summary>
        /// <param name="guFacultyID">院系标识</param>
        /// <returns></returns>
        public DataTable GetAllCalssesByFacultyID(Guid guFacultyID)
        {
            return new StudentsDAL().GetAllCalssesByFacultyID(guFacultyID);
        }
        #endregion

        #region 获取当前学生所有物品信息
        /// <summary>
        /// 根据学生ID获取该生的所有物品信息
        /// </summary>
        /// <param name="guStudentID"></param>
        /// <returns></returns>
        public DataTable GetAllGoodsByStudentID(Guid guStudentID)
        {
            return new GoodsDAL().GetGoodsByStudnetID(guStudentID);

        }
        #endregion

        #region 根据标签获取学生的物品
        /// <summary>
        /// 根据标签获取学生的物品
        /// </summary>
        /// <param name="LabelNumber"></param>
        /// <returns></returns>
        public DataTable GetGoodsByLabelID(string LabelNumber)
        {
            return new GoodsDAL().GetGoodsByLabelNumber(LabelNumber);
        }
        #endregion

        #region 删除学生信息
        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public bool DeleteStudents(Guid studentID)
        {
            return new StudentsDAL().DeleteStudents(studentID) > 0;
        }

        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public bool DeleteStudents(Guid studentID, string clientConnection)
        {

            return new StudentsDAL().DeleteStudents(studentID) > 0;
        }
        #endregion
    }
}
