using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Monitor.Component.Model;
using NGUSoft.Framework.DataAccess;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;

namespace Monitor.Component.DAL
{
    public class StudentsDAL : DataExecute
    {
        /// <summary>
        /// 获取学生信息
        /// </summary>
        /// <param name="GuidStudentID"></param>
        /// <returns></returns>
        public Students GetStudents ( Guid GuidStudentID )
        {

            string strStoreProcedure = "GetStudents";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);
            DataSet odsData;
            DataTable odtTable;
            Students oStudents = null;

            osdDataBase.AddInParameter (odbCommand, "@guStudentID", System.Data.DbType.Guid, GuidStudentID);

            odsData = osdDataBase.ExecuteDataSet (odbCommand);
            odtTable = odsData.Tables[0];
            if (odtTable.Rows.Count == 1)
            {
                oStudents = new Students ( );
                oStudents.StudentID = odtTable.Rows[0]["guStudentID"] is DBNull ? Guid.Empty : (Guid)odtTable.Rows[0]["guStudentID"];
                oStudents.RoomID = odtTable.Rows[0]["guRoomID"] is DBNull ? Guid.Empty : (Guid)odtTable.Rows[0]["guRoomID"];
                oStudents.StudentNumber = odtTable.Rows[0]["nvcStudentNumber"] is DBNull ? "" : (string)odtTable.Rows[0]["nvcStudentNumber"];
                oStudents.StudentName = odtTable.Rows[0]["nvcStudentName"] is DBNull ? "" : (string)odtTable.Rows[0]["nvcStudentName"];
                oStudents.Image = odtTable.Rows[0]["vbinImage"] is DBNull ? null : (byte[])odtTable.Rows[0]["vbinImage"];
                oStudents.Mobile = odtTable.Rows[0]["nvcMobile"] is DBNull ? "" : (string)odtTable.Rows[0]["nvcMobile"];
                oStudents.Remark = odtTable.Rows[0]["nvcRemark"] is DBNull ? "" : (string)odtTable.Rows[0]["nvcRemark"];
                oStudents.AddDate = odtTable.Rows[0]["dtAddDate"] is DBNull ? DateTime.Now : (DateTime)odtTable.Rows[0]["dtAddDate"];
                oStudents.CardNumber = odtTable.Rows[0]["iCardNumber"] is DBNull ? 0 : (int)odtTable.Rows[0]["iCardNumber"];
                oStudents.CardPwd = odtTable.Rows[0]["nvcCardPwd"] is DBNull ? "" : (string)odtTable.Rows[0]["nvcCardPwd"];
                oStudents.ClassName = odtTable.Rows[0]["nvcClassName"] is DBNull ? "" : (string)odtTable.Rows[0]["nvcClassName"];
                oStudents.SchoolYear = odtTable.Rows[0]["iSchoolYear"] is DBNull ? 0 : (int)odtTable.Rows[0]["iSchoolYear"];
                oStudents.Specialty = odtTable.Rows[0]["nvcSpecialty"] is DBNull ? "" : (string)odtTable.Rows[0]["nvcSpecialty"];
                oStudents.FacultyName = odtTable.Rows[0]["nvcFacultyName"] is DBNull ? "" : (string)odtTable.Rows[0]["nvcFacultyName"];
                oStudents.StartSchoolYear = odtTable.Rows[0]["nvcStartSchoolYear"] is DBNull ? "" : (string)odtTable.Rows[0]["nvcStartSchoolYear"];
                oStudents.Gender = odtTable.Rows[0]["iGender"] is DBNull ? 0 : (int)odtTable.Rows[0]["iGender"];
            }
            return oStudents;

        }
        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="GuidStudentID"></param>
        public int DeleteStudents ( Guid GuidStudentID )
        {
            string strStoreProcedure = "DeleteStudents";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@guStudentID", System.Data.DbType.Guid, GuidStudentID);

            return osdDataBase.ExecuteNonQuery (odbCommand);
        }

        public int DeleteStudents(Students oStudents, string clientIPConnection)
        {
            string strStoreProcedure = "DeleteStudents";
            SqlDatabase osdDataBase = new SqlDatabase(clientIPConnection);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand(strStoreProcedure);

            osdDataBase.AddInParameter(odbCommand, "@guStudentID", System.Data.DbType.Guid, oStudents.StudentID);

            return osdDataBase.ExecuteNonQuery(odbCommand);
        }

        /// <summary>
        /// 保存学生信息
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="oStudents"></param>
        public int SaveStudents ( Students oStudents )
        {
            string strStoreProcedure = "SaveStudents";
            SqlDatabase osdDataBase = new SqlDatabase (SqlConnectionString);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@guStudentID", System.Data.DbType.Guid, oStudents.StudentID);
            osdDataBase.AddInParameter (odbCommand, "@guRoomID", System.Data.DbType.Guid, oStudents.RoomID);
            osdDataBase.AddInParameter (odbCommand, "@nvcStudentNumber", System.Data.DbType.String, oStudents.StudentNumber);
            osdDataBase.AddInParameter (odbCommand, "@nvcStudentName", System.Data.DbType.String, oStudents.StudentName);
            osdDataBase.AddInParameter (odbCommand, "@vbinImage", System.Data.DbType.Binary, oStudents.Image);
            osdDataBase.AddInParameter (odbCommand, "@nvcMobile", System.Data.DbType.String, oStudents.Mobile);
            osdDataBase.AddInParameter (odbCommand, "@nvcRemark", System.Data.DbType.String, oStudents.Remark);
            osdDataBase.AddInParameter (odbCommand, "@dtAddDate", System.Data.DbType.DateTime, oStudents.AddDate);
            //osdDataBase.AddInParameter (odbCommand, "@iCardNumber", System.Data.DbType.Int32, oStudents.CardNumber==0 ? null:oStudents.CardNumber);
            osdDataBase.AddInParameter (odbCommand, "@nvcCardPwd", System.Data.DbType.String, oStudents.CardPwd);
            osdDataBase.AddInParameter (odbCommand, "@nvcClassName", System.Data.DbType.String, oStudents.ClassName);
            osdDataBase.AddInParameter (odbCommand, "@iSchoolYear", System.Data.DbType.Int32, oStudents.SchoolYear);
            osdDataBase.AddInParameter (odbCommand, "@nvcSpecialty", System.Data.DbType.String, oStudents.Specialty);
            osdDataBase.AddInParameter (odbCommand, "@nvcFacultyName", System.Data.DbType.String, oStudents.FacultyName);
            osdDataBase.AddInParameter (odbCommand, "@nvcStartSchoolYear", System.Data.DbType.String, oStudents.StartSchoolYear);
            osdDataBase.AddInParameter (odbCommand, "@iGender", System.Data.DbType.Int32, oStudents.Gender);

            return osdDataBase.ExecuteNonQuery (odbCommand);


        }


        /// <summary>
        /// 保存学生信息
        /// </summary>
        /// <param name="strConnectionString"></param>
        /// <param name="oStudents"></param>
        public int SaveStudents ( Students oStudents, string clientIPConnection )
        {
            string strStoreProcedure = "SaveStudents";
            SqlDatabase osdDataBase = new SqlDatabase (clientIPConnection);
            DbCommand odbCommand = osdDataBase.GetStoredProcCommand (strStoreProcedure);

            osdDataBase.AddInParameter (odbCommand, "@guStudentID", System.Data.DbType.Guid, oStudents.StudentID);
            osdDataBase.AddInParameter (odbCommand, "@guRoomID", System.Data.DbType.Guid, oStudents.RoomID);
            osdDataBase.AddInParameter (odbCommand, "@nvcStudentNumber", System.Data.DbType.String, oStudents.StudentNumber);
            osdDataBase.AddInParameter (odbCommand, "@nvcStudentName", System.Data.DbType.String, oStudents.StudentName);
            osdDataBase.AddInParameter (odbCommand, "@vbinImage", System.Data.DbType.Binary, oStudents.Image);
            osdDataBase.AddInParameter (odbCommand, "@nvcMobile", System.Data.DbType.String, oStudents.Mobile);
            osdDataBase.AddInParameter (odbCommand, "@nvcRemark", System.Data.DbType.String, oStudents.Remark);
            osdDataBase.AddInParameter (odbCommand, "@dtAddDate", System.Data.DbType.DateTime, oStudents.AddDate);
            osdDataBase.AddInParameter (odbCommand, "@iCardNumber", System.Data.DbType.Int32, oStudents.CardNumber);
            osdDataBase.AddInParameter (odbCommand, "@nvcCardPwd", System.Data.DbType.String, oStudents.CardPwd);
            osdDataBase.AddInParameter (odbCommand, "@nvcClassName", System.Data.DbType.String, oStudents.ClassName);
            osdDataBase.AddInParameter (odbCommand, "@iSchoolYear", System.Data.DbType.Int32, oStudents.SchoolYear);
            osdDataBase.AddInParameter (odbCommand, "@nvcSpecialty", System.Data.DbType.String, oStudents.Specialty);
            osdDataBase.AddInParameter (odbCommand, "@nvcFacultyName", System.Data.DbType.String, oStudents.FacultyName);
            osdDataBase.AddInParameter (odbCommand, "@nvcStartSchoolYear", System.Data.DbType.String, oStudents.StartSchoolYear);
            osdDataBase.AddInParameter (odbCommand, "@iGender", System.Data.DbType.Int32, oStudents.Gender);

            return osdDataBase.ExecuteNonQuery (odbCommand);


        }

        #region 获取学生信息
        /// <summary>
        /// 获取学生信息
        /// </summary>
        /// <param name="guStudentID"></param>
        /// <returns></returns>
        public DataTable GetStudent ( Guid guStudentID )
        {
            string sql = @"SELECT [guStudentID],[guRoomID],[nvcStudentNumber],[nvcStudentName],[vbinImage],[nvcMobile],[nvcRemark],[dtAddDate],[iCardNumber],[nvcCardPwd],[nvcClassName],[iSchoolYear],[nvcSpecialty],[nvcFacultyName],[nvcStartSchoolYear],[iGender]
							FROM Students 
							WHERE [guStudentID]=@guStudentID";

            SqlParameter[] para = new SqlParameter[] { 
									new SqlParameter("guStudentID",DbType.Guid,guStudentID)
			};

            return dm.ExecuteDataTable (sql, para);
        }


        /// <summary>
        /// 获取学生信息
        /// </summary>
        /// <param name="strStudentNumber"></param>
        /// <returns></returns>
        public DataTable GetStudent ( string strStudentNumber )
        {
            string sql = @"SELECT [guStudentID],[guRoomID],[nvcStudentNumber],[nvcStudentName],[vbinImage],[nvcMobile],[nvcRemark],[dtAddDate],[iCardNumber],[nvcCardPwd],[nvcClassName],[iSchoolYear],[nvcSpecialty],[nvcFacultyName],[nvcStartSchoolYear],[iGender]
                            FROM Students 
							WHERE [nvcStudentNumber]=@nvcStudentNumber";

            SqlParameter[] para = new SqlParameter[] { 
									new SqlParameter("nvcStudentNumber",DbType.String,strStudentNumber)
			};

            return dm.ExecuteDataTable (sql, para);
        }

        /// <summary>
        /// 根据条件获取学生信息
        /// </summary>
        /// <param name="strStudentNumber"></param>
        /// <returns></returns>
        public DataTable GetAllStudent ( string condition )
        {
            string sql = @"SELECT [guStudentID],[guRoomID],[nvcStudentNumber],[nvcStudentName],[vbinImage],[nvcMobile],[nvcRemark],[dtAddDate],[iCardNumber],[nvcCardPwd],[nvcClassName],[iSchoolYear],[nvcSpecialty],[nvcFacultyName],[nvcStartSchoolYear],[iGender]
                            FROM Students 
							WHERE " + condition;

            return dm.ExecuteDataTable (sql);
        }
        #endregion

        #region 获取当前学校的所有院系
        /// <summary>
        /// 获取当前学校的所有院系信息
        /// </summary>
        /// <param name="guSchoolID">学校标识</param>
        /// <returns></returns>
        public DataTable GetAllFaculty ( Guid guSchoolID )
        {
            string sql = @"SELECT [guFacultyID],[nvcFacultyName],[bIsDeleted],[dtAddDate],[nvcRemark],[guSchoolID]
						FROM Faculties 
						WHERE [guSchoolID]=@guSchoolID";

            SqlParameter[] para = new SqlParameter[] { 
									new SqlParameter("guSchoolID",DbType.Guid,guSchoolID)
			};

            return dm.ExecuteDataTable (sql, para);
        }
        #endregion

        #region 获取当前院系下所有班级信息
        /// <summary>
        /// 获取当前院系下所有班级信息
        /// </summary>
        /// <param name="guFacultyID">院系标识</param>
        /// <returns></returns>
        public DataTable GetAllCalssesByFacultyID ( Guid guFacultyID )
        {
            string sql = @"SELECT [guClassID],[nvcClassName],[bIsDeleted],[dtAddDate],[nvcRemark],[guFacultyID]
							FROM Classes 
							WHERE [guFacultyID]=@guFacultyID";

            SqlParameter[] para = new SqlParameter[] { 
									new SqlParameter("guFacultyID",DbType.Guid,guFacultyID)
			};

            return dm.ExecuteDataTable (sql, para);
        }
        #endregion
    }
}
