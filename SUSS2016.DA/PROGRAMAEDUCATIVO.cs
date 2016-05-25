using System;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using MySql.Data.MySqlClient;

namespace SUSS2016.DA
{
	/// -----------------------------------------------------------------------------
	/// Project	 : DA
	/// Class	 : Programaeducativo
	/// 
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// Data access class for PROGRAMAEDUCATIVO table.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Fer]	5/25/2016 11:22:21 AM	Created
	/// </history>
	/// -----------------------------------------------------------------------------
	public sealed class PROGRAMAEDUCATIVO
	{
		private PROGRAMAEDUCATIVO() {}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Inserts a record into the PROGRAMAEDUCATIVO table.
		/// <summary>
		/// <param name="idPrograma"></param>
		/// <param name="descripcion"></param>
		/// <param name="creditosTotales"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/25/2016 11:22:21 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Insert(int idPrograma, string descripcion, int creditosTotales)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.Insertprogramaeducativo");

			myCommand.Parameters.Add(CreateInParameter("P_idPrograma", MySqlDbType.Int32, idPrograma));
			myCommand.Parameters.Add(CreateInParameter("P_descripcion", MySqlDbType.VarChar, descripcion));
			myCommand.Parameters.Add(CreateInParameter("P_creditosTotales", MySqlDbType.Int32, creditosTotales));

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects a single record from the PROGRAMAEDUCATIVO table.
		/// <summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/25/2016 11:22:21 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static DataSet  SelectSingle(int idPrograma) 
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.SelectSingleprogramaeducativo");

			myCommand.Parameters.Add(CreateInParameter("P_idPrograma", MySqlDbType.Int32, idPrograma));

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects all records from the PROGRAMAEDUCATIVO table.
		/// <summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/25/2016 11:22:21 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static DataSet  SelectAll()
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.SelectAllprogramaeducativo");

			return myDatabase.ExecuteDataSet(myCommand);
		}

		private static MySqlParameter CreateInParameter(string paramName, MySqlDbType dbType, object value)
		{
			MySqlParameter parameter = new MySqlParameter(paramName, dbType);
			parameter.Direction = ParameterDirection.Input;
		
			if (value == null)
			{
			parameter.IsNullable = true;
			parameter.Value = DBNull.Value;
			return parameter;
			}
			
			parameter.Value = value;
			
			return parameter;
		}
		private static MySqlParameter CreateOutParameter(string paramName, MySqlDbType dbType, object value)
		{
			MySqlParameter parameter = new MySqlParameter(paramName, dbType);
			parameter.Direction = ParameterDirection.Output;
			
			if (value == null)
			{
			parameter.IsNullable = true;
			parameter.Value = DBNull.Value;
			return parameter;
			}
			
			parameter.Value = value;
			
			return parameter;
			}
	}
}
