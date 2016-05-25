using System;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using MySql.Data.MySqlClient;

namespace SUSS2016.DA
{
	/// -----------------------------------------------------------------------------
	/// Project	 : DA
	/// Class	 : Unidadacademica
	/// 
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// Data access class for UNIDADACADEMICA table.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Fer]	5/25/2016 11:22:21 AM	Created
	/// </history>
	/// -----------------------------------------------------------------------------
	public sealed class UNIDADACADEMICA
	{
		private UNIDADACADEMICA() {}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Inserts a record into the UNIDADACADEMICA table.
		/// <summary>
		/// <param name="idUA"></param>
		/// <param name="descripcion"></param>
		/// <param name="direccion"></param>
		/// <param name="municipio"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/25/2016 11:22:21 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Insert(int idUA, string descripcion, string direccion, int municipio)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.Insertunidadacademica");

			myCommand.Parameters.Add(CreateInParameter("P_idUA", MySqlDbType.Int32, idUA));
			myCommand.Parameters.Add(CreateInParameter("P_descripcion", MySqlDbType.VarChar, descripcion));
			myCommand.Parameters.Add(CreateInParameter("P_direccion", MySqlDbType.VarChar, direccion));
			myCommand.Parameters.Add(CreateInParameter("P_municipio", MySqlDbType.Int32, municipio));

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects a single record from the UNIDADACADEMICA table.
		/// <summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/25/2016 11:22:21 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static DataSet  SelectSingle(int idUA) 
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.SelectSingleunidadacademica");

			myCommand.Parameters.Add(CreateInParameter("P_idUA", MySqlDbType.Int32, idUA));

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects all records from the UNIDADACADEMICA table.
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
			MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.SelectAllunidadacademica");

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
