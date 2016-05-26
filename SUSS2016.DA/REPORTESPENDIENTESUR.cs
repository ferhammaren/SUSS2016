using System;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using MySql.Data.MySqlClient;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace DataAccess
{
	/// -----------------------------------------------------------------------------
	/// Project	 : DataAccess
	/// Class	 : Reportespendientesur
	/// 
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// Data access class for REPORTESPENDIENTESUR table.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Edgar]	25/05/2016 17:58:43	Created
	/// </history>
	/// -----------------------------------------------------------------------------
	public sealed class REPORTESPENDIENTESUR
	{
        private static DatabaseProviderFactory factory = new DatabaseProviderFactory();

        private REPORTESPENDIENTESUR() {}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Inserts a record into the REPORTESPENDIENTESUR table.
		/// <summary>
		/// <param name="matricula"></param>
		/// <param name="programa"></param>
		/// <param name="reporte"></param>
		/// <param name="tipoReporte"></param>
		/// <param name="rutaReporte"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Edgar]	25/05/2016 17:58:43	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static Int32 Insert(int matricula, int programa, string reporte, int tipoReporte, string rutaReporte)
		{
			try{
				//Database myDatabase = DatabaseFactory.CreateDatabase();
                Database myDatabase = factory.Create("constr");

                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.Insertreportespendientesur");

				myCommand.Parameters.Add(CreateInParameter("P_matricula", MySqlDbType.Int32, matricula));
				myCommand.Parameters.Add(CreateInParameter("P_programa", MySqlDbType.Int32, programa));
				myCommand.Parameters.Add(CreateInParameter("P_reporte", MySqlDbType.VarChar, reporte));
				myCommand.Parameters.Add(CreateInParameter("P_tipoReporte", MySqlDbType.Int32, tipoReporte));
				myCommand.Parameters.Add(CreateInParameter("P_rutaReporte", MySqlDbType.VarChar, rutaReporte));

				myCommand.Parameters.Add(CreateOutParameter("PKEY", MySqlDbType.Int32, null));//AERobles
				
				// Execute the query and return the new identity value
				myDatabase.ExecuteNonQuery(myCommand);
				return Convert.ToInt32(myCommand.Parameters["PKEY"].Value);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "keklmao");
				if(rethrow)
					throw;
				return 0;
			}
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects all records from the REPORTESPENDIENTESUR table.
		/// <summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Edgar]	25/05/2016 17:58:43	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static DataSet  SelectAll(int ur)
		{
			try{
                Database myDatabase = factory.Create("constr");
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.SelectAllreportespendientesur");


                myCommand.Parameters.Add(CreateInParameter("unidad", MySqlDbType.Int32, ur));
                return myDatabase.ExecuteDataSet(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "keklmao");
				if(rethrow)
					throw;
				return new DataSet();
			}
		}

        public static void Delete(int matricula)
        {
            Database myDatabase = factory.Create("constr");
            MySqlCommand myCommand = (MySqlCommand)myDatabase.GetStoredProcCommand("deleteReporteUR");

            myCommand.Parameters.Add(CreateInParameter("matricula", MySqlDbType.Int32, matricula));

            myDatabase.ExecuteNonQuery(myCommand);
        }

        public static DataSet SelectBy(int idSolicitud)
        {
            Database myDatabase = factory.Create("constr");
            MySqlCommand myCommand = (MySqlCommand)myDatabase.GetStoredProcCommand("selectsinglesolicitudur");

            myCommand.Parameters.Add(CreateInParameter("idSol", MySqlDbType.Int32, idSolicitud));

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
