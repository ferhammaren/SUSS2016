using System;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using MySql.Data.MySqlClient;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace SUSS2016.DA
{
	/// -----------------------------------------------------------------------------
	/// Project	 : datas
	/// Class	 : Info_usuarios
	/// 
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// Data access class for INFO_USUARIOS table.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Fer]	5/17/2016 6:23:02 PM	Created
	/// </history>
	/// -----------------------------------------------------------------------------
	public sealed class INFO_USUARIOS
	{
		private INFO_USUARIOS() {}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Inserts a record into the INFO_USUARIOS table.
		/// <summary>
		/// <param name="ap_paterno"></param>
		/// <param name="ap_materno"></param>
		/// <param name="nombre"></param>
		/// <param name="organizacion"></param>
		/// <param name="correo"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/17/2016 6:23:02 PM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static Int32 Insert(string ap_paterno, string ap_materno, string nombre, string organizacion, string correo)
		{
			try{
				Database myDatabase = DatabaseFactory.CreateDatabase();
				MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("practica1.Insertinfo_usuarios");

				myCommand.Parameters.Add(CreateInParameter("P_ap_paterno", MySqlDbType.VarChar, ap_paterno));
				myCommand.Parameters.Add(CreateInParameter("P_ap_materno", MySqlDbType.VarChar, ap_materno));
				myCommand.Parameters.Add(CreateInParameter("P_nombre", MySqlDbType.VarChar, nombre));
				myCommand.Parameters.Add(CreateInParameter("P_organizacion", MySqlDbType.VarChar, organizacion));
				myCommand.Parameters.Add(CreateInParameter("P_correo", MySqlDbType.VarChar, correo));

				myCommand.Parameters.Add(CreateOutParameter("PKEY", MySqlDbType.Int32, null));//AERobles
				
				// Execute the query and return the new identity value
				myDatabase.ExecuteNonQuery(myCommand);
				return Convert.ToInt32(myCommand.Parameters["PKEY"].Value);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "hue");
				if(rethrow)
					throw;
				return 0;
			}
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Deletes a record from the INFO_USUARIOS table by a composite primary key.
		/// <summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/17/2016 6:23:02 PM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Delete(int num_usuario)
		{
			try{
				Database myDatabase = DatabaseFactory.CreateDatabase();
				MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("practica1.Deleteinfo_usuarios");

				myCommand.Parameters.Add(CreateInParameter("P_num_usuario", MySqlDbType.Int32, num_usuario));

				myDatabase.ExecuteNonQuery(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "hue");
				if(rethrow)
					throw;
			}
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Deletes a record from the INFO_USUARIOS table by a foreign key.
		/// <summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/17/2016 6:23:02 PM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void UpdateByNum_usuario(int num_usuario)
		{
			try{
				Database myDatabase = DatabaseFactory.CreateDatabase();
				MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("practica1.UpdateByinfo_usuariosNum_usuario");

				myCommand.Parameters.Add(CreateInParameter("P_num_usuario", MySqlDbType.Int32, num_usuario));

				myDatabase.ExecuteNonQuery(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "hue");
				if(rethrow)
					throw;
			}
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects a single record from the INFO_USUARIOS table.
		/// <summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/17/2016 6:23:02 PM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static DataSet  SelectSingle(int num_usuario) 
		{
			try{
				Database myDatabase = DatabaseFactory.CreateDatabase();
				MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("practica1.SelectSingleinfo_usuarios");

				myCommand.Parameters.Add(CreateInParameter("P_num_usuario", MySqlDbType.Int32, num_usuario));

				return myDatabase.ExecuteDataSet(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "hue");
				if(rethrow)
					throw;
				return new DataSet();
			}
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects all records from the INFO_USUARIOS table.
		/// <summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/17/2016 6:23:02 PM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static DataSet  SelectAll()
		{
			try{
				Database myDatabase = DatabaseFactory.CreateDatabase();
				MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("practica1.SelectAllinfo_usuarios");

				return myDatabase.ExecuteDataSet(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "hue");
				if(rethrow)
					throw;
				return new DataSet();
			}
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
