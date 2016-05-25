using System;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using MySql.Data.MySqlClient;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace SUSS2016.DA
{
	/// -----------------------------------------------------------------------------
	/// Project	 : SUSS2016.DA
	/// Class	 : Solicitudespendientesur
	/// 
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// Data access class for SOLICITUDESPENDIENTESUR table.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Fer]	5/25/2016 12:23:20 AM	Created
	/// </history>
	/// -----------------------------------------------------------------------------
	public sealed class SOLICITUDESPENDIENTESUR
	{
        private static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        private SOLICITUDESPENDIENTESUR() {}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Inserts a record into the SOLICITUDESPENDIENTESUR table.
		/// <summary>
		/// <param name="idSolicitud"></param>
		/// <param name="idPrograma"></param>
		/// <param name="matricula"></param>
		/// <param name="fechaAsignacion"></param>
		/// <param name="fechaConclusion"></param>
		/// <param name="horarioAlumno"></param>
		/// <param name="horarioPrestacion"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/25/2016 12:23:20 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Insert(int idSolicitud, int idPrograma, int matricula, DateTime fechaAsignacion, DateTime fechaConclusion, string horarioAlumno, string horarioPrestacion)
		{
			try{
                Database myDatabase = factory.Create("constr");
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("Insertsolicitudespendientesur");

				myCommand.Parameters.Add(CreateInParameter("P_idSolicitud", MySqlDbType.Int32, idSolicitud));
				myCommand.Parameters.Add(CreateInParameter("P_idPrograma", MySqlDbType.Int32, idPrograma));
				myCommand.Parameters.Add(CreateInParameter("P_matricula", MySqlDbType.Int32, matricula));
				myCommand.Parameters.Add(CreateInParameter("P_fechaAsignacion", MySqlDbType.DateTime, fechaAsignacion));
				myCommand.Parameters.Add(CreateInParameter("P_fechaConclusion", MySqlDbType.DateTime, fechaConclusion));
				myCommand.Parameters.Add(CreateInParameter("P_horarioAlumno", MySqlDbType.VarChar, horarioAlumno));
				myCommand.Parameters.Add(CreateInParameter("P_horarioPrestacion", MySqlDbType.VarChar, horarioPrestacion));

				myDatabase.ExecuteNonQuery(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "NO");
				
			}
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects all records from the SOLICITUDESPENDIENTESUR table.
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
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("SelectAllsolicitudespendientesur");

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
