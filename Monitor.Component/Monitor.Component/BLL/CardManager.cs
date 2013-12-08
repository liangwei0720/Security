using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Monitor.Component.Model;
using System.Data;
using Monitor.Component.DAL;

namespace Monitor.Component.BLL
{
	class CardManager
	{
		/// <summary>
		/// 获取卡信息
		/// </summary>
		/// <param name="intCardNumber"></param>
		/// <returns></returns>
		public static Cards GetCards(int intCardNumber)
		{
			DataTable dt = CardsData.GetCards(intCardNumber);

			if ( dt.Rows.Count == 0 )
			{
				return null;
			}

			return ParseCards(dt.Rows[0]);

		}
		/// <summary>
		/// 删除一个卡信息
		/// </summary>
		/// <param name="strConnectionString"></param>
		/// <param name="intCardNumber"></param>
		public static int DeleteCards(int intCardNumber)
		{
			return CardsData.DeleteCards(intCardNumber);
		}

		/// <summary>
		/// 保存卡信息
		/// </summary>
		/// <param name="strConnectionString"></param>
		/// <param name="oCards"></param>
		public static int SaveCards(Cards oCards)
		{
			return CardsData.SaveCards(oCards);

		}

		/// <summary>
		/// 转换实体
		/// </summary>
		/// <param name="row"></param>
		/// <returns></returns>
		private static Cards ParseCards(DataRow row)
		{
			Cards oCards = new Cards( );

			oCards.CardNumber = row["iCardNumber"] is DBNull ? 0 : ( int )row["iCardNumber"];
			oCards.SchoolCode = row["nvcSchoolCode"] is DBNull ? "" : ( string )row["nvcSchoolCode"];
			oCards.CardStatus = row["iCardStatus"] is DBNull ? ( short )0 : ( short )row["iCardStatus"];
			oCards.Remark = row["nvcRemark"] is DBNull ? "" : ( string )row["nvcRemark"];
			oCards.AddDate = row["dtAddDate"] is DBNull ? DateTime.Now : ( DateTime )row["dtAddDate"];
			oCards.IsDeleted = row["bIsDeleted"] is DBNull ? false : ( bool )row["bIsDeleted"];

			return oCards;
		}
	}
}
