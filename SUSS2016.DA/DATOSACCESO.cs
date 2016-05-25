using System;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using MySql.Data.MySqlClient;

namespace SUSS2016.DA
{
	/// -----------------------------------------------------------------------------
	/// Project	 : datas
	/// Class	 : Datosacceso
	/// 
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// Data access class for DATOSACCESO table.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Fer]	5/22/2016 3:40:25 AM	Created
	/// </history>
	/// -----------------------------------------------------------------------------
	public sealed class DATOSACCESO
	{
		private DATOSACCESO() {}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Inserts a record into the DATOSACCESO table.
		/// <summary>
		/// <param name="correo"></param>
		/// <param name="pass"></param>
		/// <param name="rolUsuario"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/22/2016 3:40:25 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static Int32 Insert(string correo, string pass, int rolUsuario)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.Insertdatosacceso");

			myCommand.Parameters.Add(CreateInParameter("P_correo", MySqlDbType.VarChar, correo));
			myCommand.Parameters.Add(CreateInParameter("P_pass", MySqlDbType.VarChar, pass));
			myCommand.Parameters.Add(CreateInParameter("P_rolUsuario", MySqlDbType.Int32, rolUsuario));

			myCommand.Parameters.Add(CreateOutParameter("PKEY", MySqlDbType.Int32, null));//AERobles
			
			// Execute the query and return the new identity value
			myDatabase.ExecuteNonQuery(myCommand);
			return Convert.ToInt32(myCommand.Parameters["PKEY"].Value);
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Updates a record in the DATOSACCESO table.
		/// <summary>
		/// <param name="numeroUsuario"></param>
		/// <param name="correo"></param>
		/// <param name="pass"></param>
		/// <param name="rolUsuario"></param>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/22/2016 3:40:25 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Update(int numeroUsuario, string correo, string pass, int rolUsuario)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.Updatedatosacceso");

			myCommand.Parameters.Add(CreateInParameter("P_numeroUsuario", MySqlDbType.Int32, numeroUsuario));
			myCommand.Parameters.Add(CreateInParameter("P_correo", MySqlDbType.VarChar, correo));
			myCommand.Parameters.Add(CreateInParameter("P_pass", MySqlDbType.VarChar, pass));
			myCommand.Parameters.Add(CreateInParameter("P_rolUsuario", MySqlDbType.Int32, rolUsuario));

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Deletes a record from the DATOSACCESO table by a composite primary key.
		/// <summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/22/2016 3:40:25 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Delete(int numeroUsuario)
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.Deletedatosacceso");

			myCommand.Parameters.Add(CreateInParameter("P_numeroUsuario", MySqlDbType.Int32, numeroUsuario));

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects a single record from the DATOSACCESO table.
		/// <summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/22/2016 3:40:25 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static DataSet  SelectSingle(int numeroUsuario) 
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.SelectSingledatosacceso");

			myCommand.Parameters.Add(CreateInParameter("P_numeroUsuario", MySqlDbType.Int32, numeroUsuario));

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects all records from the DATOSACCESO table.
		/// <summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/22/2016 3:40:25 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static DataSet  SelectAll()
		{
			Database myDatabase = DatabaseFactory.CreateDatabase();
			MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.SelectAlldatosacceso");

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
