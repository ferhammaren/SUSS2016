using System;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using MySql.Data.MySqlClient;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace DA
{
	/// -----------------------------------------------------------------------------
	/// Project	 : DA
	/// Class	 : Programaserviciosocial
	/// 
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// Data access class for PROGRAMASERVICIOSOCIAL table.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Fer]	5/24/2016 10:54:37 AM	Created
	/// </history>
	/// -----------------------------------------------------------------------------
	public sealed class PROGRAMASERVICIOSOCIAL
	{
        private static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        private PROGRAMASERVICIOSOCIAL() {}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Inserts a record into the PROGRAMASERVICIOSOCIAL table.
		/// <summary>
		/// <param name="idPrograma"></param>
		/// <param name="carrera"></param>
		/// <param name="nombrePrograma"></param>
		/// <param name="idSupervisor"></param>
		/// <param name="etapa"></param>
		/// <param name="horas"></param>
		/// <param name="cupo"></param>
		/// <param name="asignados"></param>
		/// <param name="municipio"></param>
		/// <param name="unidadReceptora"></param>
		/// <param name="sector"></param>
		/// <param name="objetivo"></param>
		/// <param name="actividades"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/24/2016 10:54:37 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Insert(int idPrograma, int carrera, string nombrePrograma, int idSupervisor, int etapa, int horas, int cupo, int asignados, string municipio, int unidadReceptora, int sector, string objetivo, string actividades)
		{
             
			try{
                Database myDatabase = factory.Create("constr");
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss. Insertprogramaserviciosocial");

				myCommand.Parameters.Add(CreateInParameter("P_idPrograma", MySqlDbType.Int32, idPrograma));
				myCommand.Parameters.Add(CreateInParameter("P_carrera", MySqlDbType.Int32, carrera));
				myCommand.Parameters.Add(CreateInParameter("P_nombrePrograma", MySqlDbType.VarChar, nombrePrograma));
				myCommand.Parameters.Add(CreateInParameter("P_idSupervisor", MySqlDbType.Int32, idSupervisor));
				myCommand.Parameters.Add(CreateInParameter("P_etapa", MySqlDbType.Int32, etapa));
				myCommand.Parameters.Add(CreateInParameter("P_horas", MySqlDbType.Int32, horas));
				myCommand.Parameters.Add(CreateInParameter("P_cupo", MySqlDbType.Int32, cupo));
				myCommand.Parameters.Add(CreateInParameter("P_asignados", MySqlDbType.Int32, asignados));
				myCommand.Parameters.Add(CreateInParameter("P_municipio", MySqlDbType.VarChar, municipio));
				myCommand.Parameters.Add(CreateInParameter("P_unidadReceptora", MySqlDbType.Int32, unidadReceptora));
				myCommand.Parameters.Add(CreateInParameter("P_sector", MySqlDbType.Int32, sector));
				myCommand.Parameters.Add(CreateInParameter("P_objetivo", MySqlDbType.VarChar, objetivo));
				myCommand.Parameters.Add(CreateInParameter("P_actividades", MySqlDbType.VarChar, actividades));

				myDatabase.ExecuteNonQuery(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "yoo");
				
			}
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects a single record from the PROGRAMASERVICIOSOCIAL table.
		/// <summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/24/2016 10:54:37 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static DataSet  SelectSingle(int idPrograma) 
		{
			try{
                Database myDatabase = factory.Create("constr");
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("SelectSingleprogramaserviciosocial");

				myCommand.Parameters.Add(CreateInParameter("idPrograma", MySqlDbType.Int32, idPrograma));

				return myDatabase.ExecuteDataSet(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "yoo");
				if(rethrow)
					throw;
				return new DataSet();
			}
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects all records from the PROGRAMASERVICIOSOCIAL table.
		/// <summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/24/2016 10:54:37 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static DataSet  SelectAll()
		{
			try{
                Database myDatabase = factory.Create("constr");
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("SelectAllprogramaserviciosocial");

				return myDatabase.ExecuteDataSet(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "yoo");
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
