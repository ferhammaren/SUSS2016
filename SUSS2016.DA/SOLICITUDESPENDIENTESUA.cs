using System;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using MySql.Data.MySqlClient;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace SUSS2016.DA
{
	/// -----------------------------------------------------------------------------
	/// Project	 : SUSS2016.DA
	/// Class	 : Solicitudespendientesua
	/// 
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// Data access class for SOLICITUDESPENDIENTESUA table.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Fer]	5/25/2016 12:23:20 AM	Created
	/// </history>
	/// -----------------------------------------------------------------------------
	public sealed class SOLICITUDESPENDIENTESUA
	{
        private static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        private SOLICITUDESPENDIENTESUA() {}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Inserts a record into the SOLICITUDESPENDIENTESUA table.
		/// <summary>
		/// <param name="matricula"></param>
		/// <param name="idPrograma"></param>
		/// <param name="horarioAlumno"></param>
		/// <param name="horarioPrestacion"></param>
		/// <param name="fechaAsignacion"></param>
		/// <param name="fechaConclusion"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/25/2016 12:23:20 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Insert(int matricula, int idPrograma, string horarioAlumno, string horarioPrestacion, DateTime fechaAsignacion, DateTime fechaConclusion)
		{
			try{
                Database myDatabase = factory.Create("constr");
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("Insertsolicitudespendientesua");

				myCommand.Parameters.Add(CreateInParameter("P_matricula", MySqlDbType.Int32, matricula));
				myCommand.Parameters.Add(CreateInParameter("P_idPrograma", MySqlDbType.Int32, idPrograma));
				myCommand.Parameters.Add(CreateInParameter("P_horarioAlumno", MySqlDbType.VarChar, horarioAlumno));
				myCommand.Parameters.Add(CreateInParameter("P_horarioPrestacion", MySqlDbType.VarChar, horarioPrestacion));
				myCommand.Parameters.Add(CreateInParameter("P_fechaAsignacion", MySqlDbType.DateTime, fechaAsignacion));
				myCommand.Parameters.Add(CreateInParameter("P_fechaConclusion", MySqlDbType.DateTime, fechaConclusion));

				myCommand.Parameters.Add(CreateOutParameter("PKEY", MySqlDbType.Int32, null));//AERobles
				
				// Execute the query and return the new identity value
				myDatabase.ExecuteNonQuery(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "NO");
                if (rethrow)
                {

                }
				
			}
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Updates a record in the SOLICITUDESPENDIENTESUA table.
		/// <summary>
		/// <param name="idSolicitud"></param>
		/// <param name="matricula"></param>
		/// <param name="idPrograma"></param>
		/// <param name="horarioAlumno"></param>
		/// <param name="horarioPrestacion"></param>
		/// <param name="fechaAsignacion"></param>
		/// <param name="fechaConclusion"></param>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/25/2016 12:23:20 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Update(int idSolicitud, int matricula, int idPrograma, string horarioAlumno, string horarioPrestacion, DateTime fechaAsignacion, DateTime fechaConclusion)
		{
			try{
                Database myDatabase = factory.Create("constr");
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("Updatesolicitudespendientesua");

				myCommand.Parameters.Add(CreateInParameter("P_idSolicitud", MySqlDbType.Int32, idSolicitud));
				myCommand.Parameters.Add(CreateInParameter("P_matricula", MySqlDbType.Int32, matricula));
				myCommand.Parameters.Add(CreateInParameter("P_idPrograma", MySqlDbType.Int32, idPrograma));
				myCommand.Parameters.Add(CreateInParameter("P_horarioAlumno", MySqlDbType.VarChar, horarioAlumno));
				myCommand.Parameters.Add(CreateInParameter("P_horarioPrestacion", MySqlDbType.VarChar, horarioPrestacion));
				myCommand.Parameters.Add(CreateInParameter("P_fechaAsignacion", MySqlDbType.DateTime, fechaAsignacion));
				myCommand.Parameters.Add(CreateInParameter("P_fechaConclusion", MySqlDbType.DateTime, fechaConclusion));

				myDatabase.ExecuteNonQuery(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "NO");
				if(rethrow)
					throw;
			}
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects all records from the SOLICITUDESPENDIENTESUA table.
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
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("SelectAllsolicitudespendientesua");

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
