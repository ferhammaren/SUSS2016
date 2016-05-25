using System;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using MySql.Data.MySqlClient;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace SUSS2016.DA
{
	/// -----------------------------------------------------------------------------
	/// Project	 : SUSS2016.DA
	/// Class	 : Encargadosua
	/// 
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// Data access class for ENCARGADOSUA table.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Fer]	5/25/2016 12:23:20 AM	Created
	/// </history>
	/// -----------------------------------------------------------------------------
	public sealed class ENCARGADOSUA
	{
        private static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        private ENCARGADOSUA() {}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Inserts a record into the ENCARGADOSUA table.
		/// <summary>
		/// <param name="idEncargado"></param>
		/// <param name="nombre"></param>
		/// <param name="ap_paterno"></param>
		/// <param name="ap_materno"></param>
		/// <param name="idUA"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/25/2016 12:23:20 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Insert(int idEncargado, string nombre, int ap_paterno, int ap_materno, int idUA)
		{
			try{
                Database myDatabase = factory.Create("constr");
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.Insertencargadosua");

				myCommand.Parameters.Add(CreateInParameter("P_idEncargado", MySqlDbType.Int32, idEncargado));
				myCommand.Parameters.Add(CreateInParameter("P_nombre", MySqlDbType.VarChar, nombre));
				myCommand.Parameters.Add(CreateInParameter("P_ap_paterno", MySqlDbType.Int32, ap_paterno));
				myCommand.Parameters.Add(CreateInParameter("P_ap_materno", MySqlDbType.Int32, ap_materno));
				myCommand.Parameters.Add(CreateInParameter("P_idUA", MySqlDbType.Int32, idUA));

				myDatabase.ExecuteNonQuery(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "NO");
				
			}
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Updates a record in the ENCARGADOSUA table.
		/// <summary>
		/// <param name="idEncargado"></param>
		/// <param name="nombre"></param>
		/// <param name="ap_paterno"></param>
		/// <param name="ap_materno"></param>
		/// <param name="idUA"></param>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/25/2016 12:23:20 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Update(int idEncargado, string nombre, int ap_paterno, int ap_materno, int idUA)
		{
			try{
                Database myDatabase = factory.Create("constr");
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.Updateencargadosua");

				myCommand.Parameters.Add(CreateInParameter("P_idEncargado", MySqlDbType.Int32, idEncargado));
				myCommand.Parameters.Add(CreateInParameter("P_nombre", MySqlDbType.VarChar, nombre));
				myCommand.Parameters.Add(CreateInParameter("P_ap_paterno", MySqlDbType.Int32, ap_paterno));
				myCommand.Parameters.Add(CreateInParameter("P_ap_materno", MySqlDbType.Int32, ap_materno));
				myCommand.Parameters.Add(CreateInParameter("P_idUA", MySqlDbType.Int32, idUA));

				myDatabase.ExecuteNonQuery(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "NO");
				if(rethrow)
					throw;
			}
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects all records from the ENCARGADOSUA table.
		/// <summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/25/2016 12:23:20 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static DataSet  SelectAll()
		{
			try{
                Database myDatabase = factory.Create("constr");
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.SelectAllencargadosua");

				return myDatabase.ExecuteDataSet(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "NO");
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
