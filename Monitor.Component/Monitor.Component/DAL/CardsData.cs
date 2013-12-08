using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Monitor.Component.Model;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;

namespace Monitor.Component.DAL
{
	public class CardsData : DataExecute
	{
		/// <summary>
		/// 获取卡信息
		/// </summary>
		/// <param name="intCardNumber"></param>
		/// <returns></returns>
		public static DataTable GetCards(int intCardNumber)
		{
			string strStoreProcedure = "GetCards";
			SqlDatabase osdDataBase = new SqlDatabase(SqlConnectionString);
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand(strStoreProcedure);

			osdDataBase.AddInParameter(odbCommand, "@iCardNumber", System.Data.DbType.Int32, intCardNumber);

			return osdDataBase.ExecuteDataSet(odbCommand).Tables[0];

		}
		/// <summary>
		/// 删除一个卡信息
		/// </summary>
		/// <param name="strConnectionString"></param>
		/// <param name="intCardNumber"></param>
		public static int DeleteCards(int intCardNumber)
		{
			string strStoreProcedure = "DeleteCards";
			SqlDatabase osdDataBase = new SqlDatabase(SqlConnectionString);
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand(strStoreProcedure);

			osdDataBase.AddInParameter(odbCommand, "@iCardNumber", System.Data.DbType.Int32, intCardNumber);

			return osdDataBase.ExecuteNonQuery(odbCommand);
		}

		/// <summary>
		/// 保存卡信息
		/// </summary>
		/// <param name="strConnectionString"></param>
		/// <param name="oCards"></param>
		public static int SaveCards(Cards oCards)
		{
			string strStoreProcedure = "SaveCards";
			SqlDatabase osdDataBase = new SqlDatabase(SqlConnectionString);
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand(strStoreProcedure);

			osdDataBase.AddInParameter(odbCommand, "@iCardNumber", System.Data.DbType.Int32, oCards.CardNumber);
			osdDataBase.AddInParameter(odbCommand, "@nvcSchoolCode", System.Data.DbType.String, oCards.SchoolCode);
			osdDataBase.AddInParameter(odbCommand, "@iCardStatus", System.Data.DbType.Int16, oCards.CardStatus);
			osdDataBase.AddInParameter(odbCommand, "@nvcRemark", System.Data.DbType.String, oCards.Remark);
			osdDataBase.AddInParameter(odbCommand, "@dtAddDate", System.Data.DbType.DateTime, oCards.AddDate);
			osdDataBase.AddInParameter(odbCommand, "@bIsDeleted", System.Data.DbType.Boolean, oCards.IsDeleted);

			return osdDataBase.ExecuteNonQuery(odbCommand);

		}

	}
}
