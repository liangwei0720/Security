using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;
using Monitor.Component.Model;

namespace Monitor.Component.DAL
{
	public class ServerData : DataExecute
	{
		public static Server GetServer (int intServerID)
		{
			string strStoreProcedure = "GetServer";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );
			DataSet odsData;
			DataTable odtTable;
			Server oServer = null;

			osdDataBase.AddInParameter( odbCommand , "@iServerID" , System.Data.DbType.Int32 , intServerID );

			odsData = osdDataBase.ExecuteDataSet( odbCommand );
			odtTable = odsData.Tables[0];
			if ( odtTable.Rows.Count == 1 )
			{
				oServer = new Server( );
				oServer.ServerID = odtTable.Rows[0]["iServerID"] is DBNull ? 0 : ( int )odtTable.Rows[0]["iServerID"];
				oServer.ServerName = odtTable.Rows[0]["vcServerName"] is DBNull ? "" : ( string )odtTable.Rows[0]["vcServerName"];
				oServer.IP = odtTable.Rows[0]["vcIP"] is DBNull ? "" : ( string )odtTable.Rows[0]["vcIP"];
				oServer.LastUpdate = odtTable.Rows[0]["dtLastUpdate"] is DBNull ? DateTime.Now : ( DateTime )odtTable.Rows[0]["dtLastUpdate"];
				oServer.IsSuccess = odtTable.Rows[0]["bIsSuccess"] is DBNull ? false : ( bool )odtTable.Rows[0]["bIsSuccess"];
				oServer.GuDormID = odtTable.Rows[0]["GuDormID"] is DBNull ? Guid.Empty : ( Guid )odtTable.Rows[0]["GuDormID"];
				oServer.Connection = odtTable.Rows[0]["vcServerConnection"] is DBNull ? "" : ( string )odtTable.Rows[0]["vcServerConnection"];
			}
			return oServer;
		}

		public static Server GetServerByDormID (Guid guDormID)
		{
			string strStoreProcedure = "SELECT * FROM ServerList WHERE guDormID = @guDormID";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetSqlStringCommand( strStoreProcedure );
			DataSet odsData;
			DataTable odtTable;
			Server oServer = null;

			osdDataBase.AddInParameter( odbCommand , "@guDormID" , System.Data.DbType.Guid , guDormID );

			odsData = osdDataBase.ExecuteDataSet( odbCommand );
			odtTable = odsData.Tables[0];
			if ( odtTable.Rows.Count == 1 )
			{
				oServer = new Server( );
				oServer.ServerID = odtTable.Rows[0]["iServerID"] is DBNull ? 0 : ( int )odtTable.Rows[0]["iServerID"];
				oServer.ServerName = odtTable.Rows[0]["vcServerName"] is DBNull ? "" : ( string )odtTable.Rows[0]["vcServerName"];
				oServer.IP = odtTable.Rows[0]["vcIP"] is DBNull ? "" : ( string )odtTable.Rows[0]["vcIP"];
				oServer.LastUpdate = odtTable.Rows[0]["dtLastUpdate"] is DBNull ? DateTime.Now : ( DateTime )odtTable.Rows[0]["dtLastUpdate"];
				oServer.IsSuccess = odtTable.Rows[0]["bIsSuccess"] is DBNull ? false : ( bool )odtTable.Rows[0]["bIsSuccess"];
				oServer.GuDormID = odtTable.Rows[0]["GuDormID"] is DBNull ? Guid.Empty : ( Guid )odtTable.Rows[0]["GuDormID"];
				oServer.Connection = odtTable.Rows[0]["vcServerConnection"] is DBNull ? "" : ( string )odtTable.Rows[0]["vcServerConnection"];
			}
			return oServer;
		}

		public static List<Server> GetServersByDormID (Guid guDormID)
		{
			string strStoreProcedure = "SELECT * FROM ServerList WHERE guDormID = @guDormID";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetSqlStringCommand( strStoreProcedure );
			DataSet odsData;
			DataTable odtTable;
			List<Server> oListServer = new List<Server>( );
			Server oServer = null;
			osdDataBase.AddInParameter( odbCommand , "@guDormID" , System.Data.DbType.Guid , guDormID );

			odsData = osdDataBase.ExecuteDataSet( odbCommand );
			odtTable = odsData.Tables[0];
			foreach ( DataRow row in odtTable.Rows )
			{
				oServer = new Server( );
				oServer.ServerID = odtTable.Rows[0]["iServerID"] is DBNull ? 0 : ( int )odtTable.Rows[0]["iServerID"];
				oServer.ServerName = odtTable.Rows[0]["vcServerName"] is DBNull ? "" : ( string )odtTable.Rows[0]["vcServerName"];
				oServer.IP = odtTable.Rows[0]["vcIP"] is DBNull ? "" : ( string )odtTable.Rows[0]["vcIP"];
				oServer.LastUpdate = odtTable.Rows[0]["dtLastUpdate"] is DBNull ? DateTime.Now : ( DateTime )odtTable.Rows[0]["dtLastUpdate"];
				oServer.IsSuccess = odtTable.Rows[0]["bIsSuccess"] is DBNull ? false : ( bool )odtTable.Rows[0]["bIsSuccess"];
				oServer.GuDormID = odtTable.Rows[0]["GuDormID"] is DBNull ? Guid.Empty : ( Guid )odtTable.Rows[0]["GuDormID"];
				oServer.Connection = odtTable.Rows[0]["vcServerConnection"] is DBNull ? "" : ( string )odtTable.Rows[0]["vcServerConnection"];

				oListServer.Add( oServer );

			}
			return oListServer;
		}

		public static void DeleteServer (int intServerID)
		{
			string strStoreProcedure = "DeleteServer";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			osdDataBase.AddInParameter( odbCommand , "@iServerID" , System.Data.DbType.Int32 , intServerID );

			osdDataBase.ExecuteNonQuery( odbCommand );
		}
		public static void SaveServer (Server oServer)
		{
			string strStoreProcedure = "SaveServer";
			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetStoredProcCommand( strStoreProcedure );

			osdDataBase.AddInParameter( odbCommand , "@vcServerName" , System.Data.DbType.String , oServer.ServerName );
			osdDataBase.AddInParameter( odbCommand , "@vcIP" , System.Data.DbType.String , oServer.IP );
			osdDataBase.AddInParameter( odbCommand , "@dtLastUpdate" , System.Data.DbType.DateTime , oServer.LastUpdate );
			osdDataBase.AddInParameter( odbCommand , "@bIsSuccess" , System.Data.DbType.Boolean , oServer.IsSuccess );
			osdDataBase.AddInParameter( odbCommand , "@guDormID" , System.Data.DbType.Guid , oServer.GuDormID );
			osdDataBase.AddInParameter( odbCommand , "@vcServerConnection" , System.Data.DbType.String , oServer.Connection );
			osdDataBase.AddParameter( odbCommand , "@iServerID" , System.Data.DbType.Int32 , ParameterDirection.InputOutput , null , DataRowVersion.Default , oServer.ServerID );

			osdDataBase.ExecuteNonQuery( odbCommand );
			oServer.ServerID = ( int )osdDataBase.GetParameterValue( odbCommand , "@iServerID" );
		}

		public static List<Server> GetAllServer ( )
		{
			List<Server> oList = new List<Server>( );

			SqlDatabase osdDataBase = new SqlDatabase( SqlConnectionString );
			DbCommand odbCommand = osdDataBase.GetSqlStringCommand( "SELECT * FROM [ServerList]" );
			DataSet odsData;
			DataTable odtTable;
			Server oServer = null;



			odsData = osdDataBase.ExecuteDataSet( odbCommand );
			odtTable = odsData.Tables[0];

			foreach ( DataRow row in odtTable.Rows )
			{
				oServer = new Server( );
				oServer.ServerID = row["iServerID"] is DBNull ? 0 : ( int )row["iServerID"];
				oServer.ServerName = row["vcServerName"] is DBNull ? "" : ( string )row["vcServerName"];
				oServer.IP = row["vcIP"] is DBNull ? "" : ( string )row["vcIP"];
				oServer.LastUpdate = row["dtLastUpdate"] is DBNull ? DateTime.Now : ( DateTime )row["dtLastUpdate"];
				oServer.IsSuccess = row["bIsSuccess"] is DBNull ? false : ( bool )row["bIsSuccess"];
				oServer.Connection = row["vcServerConnection"] is DBNull ? "" : ( string )row["vcServerConnection"];
				oServer.GuDormID = row["GuDormID"] is DBNull ? Guid.Empty : ( Guid )row["GuDormID"];

				oList.Add( oServer );
			}

			return oList;
		}

	}
}
