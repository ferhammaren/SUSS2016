using System;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using MySql.Data.MySqlClient;

namespace SUSS2016.DA
{
	/// -----------------------------------------------------------------------------
	/// Project	 : datas
	/// Class	 : Solicitudes
	/// 
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// Data access class for SOLICITUDES table.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Fer]	5/22/2016 3:40:25 AM	Created
	/// </history>
	/// -----------------------------------------------------------------------------
	public sealed class SOLICITUDES
	{
        private static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        private SOLICITUDES() {}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Inserts a record into the SOLICITUDES table.
		/// <summary>
		/// <param name="idSolicitud"></param>
		/// <param name="matricula"></param>
		/// <param name="idPrograma"></param>
		/// <param name="horarioAlumno"></param>
		/// <param name="horarioPrestacion"></param>
		/// <param name="horasPorHacer"></param>
		/// <param name="fechaAsignacion"></param>
		/// <param name="fechaConclusion"></param>
		/// <param name="estadoSolicitud"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/22/2016 3:40:25 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Insert(int matricula, int idPrograma, string horarioAlumno, string horarioPrestacion, int horasPorHacer, DateTime fechaAsignacion, int fechaConclusion, int estadoSolicitud)
		{
            Database myDatabase = factory.Create("constr");
            MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("Insertsolicitudes");
            
			myCommand.Parameters.Add(CreateInParameter("matricula", MySqlDbType.Int32, matricula));
			myCommand.Parameters.Add(CreateInParameter("idPrograma", MySqlDbType.Int32, idPrograma));
			myCommand.Parameters.Add(CreateInParameter("horarioAlumno", MySqlDbType.VarChar, horarioAlumno));
			myCommand.Parameters.Add(CreateInParameter("horarioPrestacion", MySqlDbType.VarChar, horarioPrestacion));
			myCommand.Parameters.Add(CreateInParameter("horasPorHacer", MySqlDbType.Int32, horasPorHacer));
			myCommand.Parameters.Add(CreateInParameter("fechaAsignacion", MySqlDbType.DateTime, fechaAsignacion));
			myCommand.Parameters.Add(CreateInParameter("fechaConclusion", MySqlDbType.Int32, fechaConclusion));
			myCommand.Parameters.Add(CreateInParameter("estadoSolicitud", MySqlDbType.Int32, estadoSolicitud));

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects all records from the SOLICITUDES table.
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
            Database myDatabase = factory.Create("constr");
            MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.SelectAllsolicitudes");

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
