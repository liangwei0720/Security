using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Monitor.Component.Model;
using System.Data;
using NGUSoft.Framework.DataAccess;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;

namespace Monitor.Component.DAL
{
	public class GoodsDAL : DataExecute
	{
		#region 获取学生的物品信息
		/// <summary>
		/// 根据学生ID获取学生的物品信息
		/// </summary>
		/// <param name="guStudentID">学生ID</param>
		/// <returns></returns>
		public DataTable GetGoodsByStudnetID (Guid guStudentID)
		{
			string sql = @"	SELECT [guGoodsID],[nvcBrand],[nvcModel],[bInvoice],[vbinInvoiceInfo],[dtAddDate],[iStatus],[nvcRemark],[dtUseDate],[nvcLabelNumber],[nvcStudentNumber],[mPrice],[nvcGoodsName]
							FROM Goods 
							WHERE [guStudentID]=@guStudentID";

			SqlParameter[] para = new SqlParameter[] { 
								new SqlParameter("guStudentID",DbType.Guid,guStudentID)
			};

			return dm.ExecuteDataTable( sql , para );
		}

		/// <summary>
		/// 根据标签代码获取学生信息
		/// </summary>
		/// <param name="labelNumber"></param>
		/// <returns></returns>
		public DataTable GetGoodsByLabelNumber (string labelNumber)
		{
			string sql = @"	SELECT [guGoodsID],[nvcBrand],[nvcModel],[bInvoice],[vbinInvoiceInfo],[dtAddDate],[iStatus],[nvcRemark],[dtUseDate],[nvcLabelNumber],[nvcStudentNumber],[mPrice],[nvcGoodsName]
							FROM Goods 
							WHERE [nvcLabelNumber]=@nvcLabelNumber";

			SqlParameter[] para = new SqlParameter[] { 
								new SqlParameter("nvcLabelNumber",DbType.Guid,labelNumber)
			};

			return dm.ExecuteDataTable( sql , para );
		}
		/// <summary>
		/// 获取指定的物品信息
		/// </summary>
		/// <param name="guGoodsID">物品标识</param>
		/// <returns></returns>
		public DataTable GetGoods (Guid guGoodsID)
		{
			string sql = @"	SELECT [guGoodsID],[nvcBrand],[nvcModel],[bInvoice],[vbinInvoiceInfo],[dtAddDate],[iStatus],[nvcRemark],[dtUseDate],[nvcLabelNumber],[nvcStudentNumber],[mPrice],[nvcGoodsName]
							FROM Goods 
							WHERE [guGoodsID]=@guGoodsID";

			SqlParameter[] para = new SqlParameter[] { 
								new SqlParameter("guGoodsID",DbType.Guid,guGoodsID)
			};

			return dm.ExecuteDataTable( sql , para );
		}

		/// <summary>
		/// 获取指定的物品信息
		/// </summary>
		/// <param name="guGoodsID">物品标识</param>
		/// <returns></returns>
		public DataTable GetGoodsByCondition (string condition)
		{
			string sql = @"	SELECT [guGoodsID],[nvcBrand],[nvcModel],[bInvoice],[vbinInvoiceInfo],[dtAddDate],[iStatus],[nvcRemark],[dtUseDate],[nvcLabelNumber],[nvcStudentNumber],[mPrice],[nvcGoodsName]
							FROM Goods 
							WHERE " + condition;

			return dm.ExecuteDataTable( sql );
		}
		#endregion

		#region 保存学生的物品
		/// <summary>
		/// 保存学生的物品
		/// </summary>
		/// <param name="oGoods">物品实体</param>
		/// <returns></returns>
		public bool AddGoods (Goods oGoods)
		{
			string strStoreProcedure = "SaveGoods";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			osdDataBase.AddInParameter( odbCommand , "@guGoodsID" , System.Data.DbType.Guid , oGoods.GoodsID );
			osdDataBase.AddInParameter( odbCommand , "@nvcBrand" , System.Data.DbType.String , oGoods.Brand );
			osdDataBase.AddInParameter( odbCommand , "@nvcGoodsName" , System.Data.DbType.String , oGoods.GoodsName );
			osdDataBase.AddInParameter( odbCommand , "@nvcModel" , System.Data.DbType.String , oGoods.Model );
			osdDataBase.AddInParameter( odbCommand , "@bInvoice" , System.Data.DbType.Boolean , oGoods.Invoice );
			osdDataBase.AddInParameter( odbCommand , "@vbinInvoiceInfo" , System.Data.DbType.Binary , oGoods.InvoiceInfo );
			osdDataBase.AddInParameter( odbCommand , "@dtAddDate" , System.Data.DbType.DateTime , oGoods.AddDate );
			osdDataBase.AddInParameter( odbCommand , "@iStatus" , System.Data.DbType.Int16 , oGoods.Status );
			osdDataBase.AddInParameter( odbCommand , "@nvcRemark" , System.Data.DbType.String , oGoods.Remark );
			osdDataBase.AddInParameter( odbCommand , "@dtUseDate" , System.Data.DbType.DateTime , oGoods.UseDate );
			osdDataBase.AddInParameter( odbCommand , "@nvcLabelNumber" , System.Data.DbType.String , oGoods.LabelNumber );
			osdDataBase.AddInParameter( odbCommand , "@mPrice" , System.Data.DbType.Currency , oGoods.Price );
			osdDataBase.AddInParameter( odbCommand , "@nvcStudentNumber" , System.Data.DbType.String , oGoods.StudentNumber );

			return osdDataBase.ExecuteNonQuery( odbCommand ) > 0;

		}
		#endregion

		#region 更新物品的状态
		/// <summary>
		/// 更新物品的状态
		/// </summary>
		/// <param name="goodsID"></param>
		/// <returns></returns>
		public bool UpdateGoodsStatus (Guid goodsID , int status)
		{
			string sql = @"	UPDATE  Goods
                            SET [iStatus]=@iStatus
							WHERE [guGoodsID]=@guGoodsID";

			SqlParameter[] para = new SqlParameter[] {
                                new SqlParameter("iStatus",DbType.Int16,status),
								new SqlParameter("guGoodsID",DbType.Guid,goodsID)
			};

			return dm.ExecuteNonQuery( sql , para ) > 0;
		}


		/// 更新物品的状态
		/// </summary>
		/// <param name="goodsID"></param>
		/// <returns></returns>
		public bool DeletedGoods (Guid goodsID)
		{
			string sql = @"	DELETE  Goods                           
							WHERE [guGoodsID]=@guGoodsID";

			SqlParameter[] para = new SqlParameter[] {                            
								new SqlParameter("guGoodsID",DbType.Guid,goodsID)
			};

			return dm.ExecuteNonQuery( sql , para ) > 0;
		}


		/// <summary>
		/// 保存学生的物品
		/// </summary>
		/// <param name="oGoods">物品实体</param>
		/// <returns></returns>
		public bool AddGoodsToClient (Goods oGoods , Students oStudents , Labels oLabels , string strSqlConnection)
		{
			string strSqlText = @"--标签信息
							IF EXISTS (SELECT 1 FROM Labels WHERE [nvcLabelNumber]=@nvcLabelNumber)  
								BEGIN  
									UPDATE Labels  
									SET   
									[nvcLabelName] = @nvcLabelName,  
									[iStatus] = @iLabelStatus,  
									[nvcPower] = @nvcPower,  
									[dtAddDate] = @dtLabelAddDate,  
									[nvcRemark] = @nvcLabelRemark,  
									[guSchoolID] = @guSchoolID,  
									[bIsDeleted] = @bIsDeleted  
									WHERE [nvcLabelNumber]=@nvcLabelNumber  
								END  
								ELSE  
								BEGIN  
									INSERT INTO Labels([nvcLabelNumber],[nvcLabelName],[iStatus],[nvcPower],[dtAddDate],[nvcRemark],[guSchoolID],[bIsDeleted])  
									VALUES(@nvcLabelNumber,@nvcLabelName,@iLabelStatus,@nvcPower,@dtLabelAddDate,@nvcLabelRemark,@guSchoolID,@bIsDeleted)  
								END ; 
								IF @@ERROR <>0 return;
								--学生信息
								If @iCardNumber <1  
								 SET @iCardNumber =null;   
  
								IF EXISTS (SELECT 1 FROM Students WHERE [guStudentID]=@guStudentID)  
								BEGIN  
								 UPDATE Students  
								 SET   
								  [guRoomID] = @guRoomID,  
								  [nvcStudentNumber] = @nvcStudentNumber,  
								  [nvcStudentName] = @nvcStudentName,  
								  [vbinImage] = @vbinImage,  
								  [nvcMobile] = @nvcMobile,  
								  [nvcRemark] = @nvcStudentRemark,  
								  [dtAddDate] = @dtStudentAddDate,  
								  [iCardNumber] = @iCardNumber,  
								  [nvcCardPwd] = @nvcCardPwd,  
								  [nvcClassName] = @nvcClassName,  
								  [iSchoolYear] = @iSchoolYear,  
								  [nvcSpecialty] = @nvcSpecialty,  
								  [nvcFacultyName] = @nvcFacultyName,  
								  [nvcStartSchoolYear] = @nvcStartSchoolYear,  
								  [iGender] = @iGender  
								 WHERE [guStudentID]=@guStudentID  
								END  
								ELSE  
								BEGIN  
								  INSERT INTO Students([guStudentID],[guRoomID],[nvcStudentNumber],[nvcStudentName],[vbinImage],[nvcMobile],[nvcRemark],[dtAddDate],[iCardNumber],[nvcCardPwd],[nvcClassName],[iSchoolYear],[nvcSpecialty],[nvcFacultyName],[nvcStartSchoolYear],[iGender])  
								 VALUES(@guStudentID,@guRoomID,@nvcStudentNumber,@nvcStudentName,@vbinImage,@nvcMobile,@nvcStudentRemark,@dtStudentAddDate,@iCardNumber,@nvcCardPwd,@nvcClassName,@iSchoolYear,@nvcSpecialty,@nvcFacultyName,@nvcStartSchoolYear,@iGender)  
								END;
							IF @@ERROR <> 0
								return;
							--物品信息
								IF EXISTS (SELECT 1 FROM Goods WHERE [guGoodsID]=@guGoodsID)  
									BEGIN  
									 UPDATE Goods  
									 SET   
									  [nvcBrand] = @nvcBrand,  
									  [nvcGoodsName] = @nvcGoodsName,  
									  [nvcModel] = @nvcModel,  
									  [bInvoice] = @bInvoice,  
									  [vbinInvoiceInfo] = @vbinInvoiceInfo,  
									  [dtAddDate] = @dtGoodsAddDate,  
									  [iStatus] = @iGoodsStatus,  
									  [nvcRemark] = @nvcGoodsRemark,  
									  [dtUseDate] = @dtUseDate,  
									  [nvcLabelNumber] = @nvcLabelNumber,  
									  [mPrice] = @mPrice,  
									  [nvcStudentNumber] = @nvcStudentNumber  
									 WHERE [guGoodsID]=@guGoodsID  
									END  
									ELSE  
									BEGIN  
									  INSERT INTO Goods([guGoodsID],[nvcBrand],[nvcGoodsName],[nvcModel],[bInvoice],[vbinInvoiceInfo],[dtAddDate],[iStatus],[nvcRemark],[dtUseDate],[nvcLabelNumber],[mPrice],[nvcStudentNumber])  
									 VALUES(@guGoodsID,@nvcBrand,@nvcGoodsName,@nvcModel,@bInvoice,@vbinInvoiceInfo,@dtGoodsAddDate,@iGoodsStatus,@nvcGoodsRemark,@dtUseDate,@nvcLabelNumber,@mPrice,@nvcStudentNumber)  
									END ;";
			SqlDatabase osdDataBase = new SqlDatabase( strSqlConnection );
			DbCommand odbCommand = osdDataBase.GetSqlStringCommand( strSqlText );

			//标签信息
			osdDataBase.AddInParameter( odbCommand , "@nvcLabelNumber" , System.Data.DbType.String , oLabels.LabelNumber );
			osdDataBase.AddInParameter( odbCommand , "@nvcLabelName" , System.Data.DbType.String , oLabels.LabelName );
			osdDataBase.AddInParameter( odbCommand , "@iLabelStatus" , System.Data.DbType.Int16 , oLabels.Status );
			osdDataBase.AddInParameter( odbCommand , "@nvcPower" , System.Data.DbType.String , oLabels.Power );
			osdDataBase.AddInParameter( odbCommand , "@dtLabelAddDate" , System.Data.DbType.DateTime , oLabels.AddDate );
			osdDataBase.AddInParameter( odbCommand , "@nvcLabelRemark" , System.Data.DbType.String , oLabels.Remark );
			osdDataBase.AddInParameter( odbCommand , "@guSchoolID" , System.Data.DbType.Guid , oLabels.SchoolID );
			osdDataBase.AddInParameter( odbCommand , "@bIsDeleted" , System.Data.DbType.Int16 , 0 );

			//学生信息
			osdDataBase.AddInParameter( odbCommand , "@guStudentID" , System.Data.DbType.Guid , oStudents.StudentID );
			osdDataBase.AddInParameter( odbCommand , "@guRoomID" , System.Data.DbType.Guid , oStudents.RoomID );
			osdDataBase.AddInParameter( odbCommand , "@nvcStudentNumber" , System.Data.DbType.String , oStudents.StudentNumber );
			osdDataBase.AddInParameter( odbCommand , "@nvcStudentName" , System.Data.DbType.String , oStudents.StudentName );
			osdDataBase.AddInParameter( odbCommand , "@vbinImage" , System.Data.DbType.Binary , oStudents.Image );
			osdDataBase.AddInParameter( odbCommand , "@nvcMobile" , System.Data.DbType.String , oStudents.Mobile );
			osdDataBase.AddInParameter( odbCommand , "@nvcStudentRemark" , System.Data.DbType.String , oStudents.Remark );
			osdDataBase.AddInParameter( odbCommand , "@dtStudentAddDate" , System.Data.DbType.DateTime , oStudents.AddDate );
			osdDataBase.AddInParameter( odbCommand , "@iCardNumber" , System.Data.DbType.Int32 , oStudents.CardNumber );
			osdDataBase.AddInParameter( odbCommand , "@nvcCardPwd" , System.Data.DbType.String , oStudents.CardPwd );
			osdDataBase.AddInParameter( odbCommand , "@nvcClassName" , System.Data.DbType.String , oStudents.ClassName );
			osdDataBase.AddInParameter( odbCommand , "@iSchoolYear" , System.Data.DbType.Int32 , oStudents.SchoolYear );
			osdDataBase.AddInParameter( odbCommand , "@nvcSpecialty" , System.Data.DbType.String , oStudents.Specialty );
			osdDataBase.AddInParameter( odbCommand , "@nvcFacultyName" , System.Data.DbType.String , oStudents.FacultyName );
			osdDataBase.AddInParameter( odbCommand , "@nvcStartSchoolYear" , System.Data.DbType.String , oStudents.StartSchoolYear );
			osdDataBase.AddInParameter( odbCommand , "@iGender" , System.Data.DbType.Int32 , oStudents.Gender );

			//物品信息
			osdDataBase.AddInParameter( odbCommand , "@guGoodsID" , System.Data.DbType.Guid , oGoods.GoodsID );
			osdDataBase.AddInParameter( odbCommand , "@nvcBrand" , System.Data.DbType.String , oGoods.Brand );
			osdDataBase.AddInParameter( odbCommand , "@nvcGoodsName" , System.Data.DbType.String , oGoods.GoodsName );
			osdDataBase.AddInParameter( odbCommand , "@nvcModel" , System.Data.DbType.String , oGoods.Model );
			osdDataBase.AddInParameter( odbCommand , "@bInvoice" , System.Data.DbType.Boolean , oGoods.Invoice );
			osdDataBase.AddInParameter( odbCommand , "@vbinInvoiceInfo" , System.Data.DbType.Binary , oGoods.InvoiceInfo );
			osdDataBase.AddInParameter( odbCommand , "@dtGoodsAddDate" , System.Data.DbType.DateTime , oGoods.AddDate );
			osdDataBase.AddInParameter( odbCommand , "@iGoodsStatus" , System.Data.DbType.Int16 , oGoods.Status );
			osdDataBase.AddInParameter( odbCommand , "@nvcGoodsRemark" , System.Data.DbType.String , oGoods.Remark );
			osdDataBase.AddInParameter( odbCommand , "@dtUseDate" , System.Data.DbType.DateTime , oGoods.UseDate );
			//osdDataBase.AddInParameter( odbCommand , "@nvcLabelNumber" , System.Data.DbType.String , oGoods.LabelNumber );
			osdDataBase.AddInParameter( odbCommand , "@mPrice" , System.Data.DbType.Currency , oGoods.Price );
			//osdDataBase.AddInParameter( odbCommand , "@nvcStudentNumber" , System.Data.DbType.String , oGoods.StudentNumber );

			return osdDataBase.ExecuteNonQuery( odbCommand ) > 0;

		}
		#endregion
	}
}
