using System;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using MySql.Data.MySqlClient;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace SUSS2016.DA
{
	/// -----------------------------------------------------------------------------
	/// Project	 : SUSS2016.DA
	/// Class	 : Programasasignados
	/// 
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// Data access class for PROGRAMASASIGNADOS table.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Fer]	5/25/2016 12:23:20 AM	Created
	/// </history>
	/// -----------------------------------------------------------------------------
	public sealed class PROGRAMASASIGNADOS
	{
        private static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        private PROGRAMASASIGNADOS() {}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Inserts a record into the PROGRAMASASIGNADOS table.
		/// <summary>
		/// <param name="idPrestacion"></param>
		/// <param name="idPrograma"></param>
		/// <param name="matriculaAlumno"></param>
		/// <param name="fechaInicio"></param>
		/// <param name="fechaFin"></param>
		/// <param name="horas"></param>
		/// <param name="horarioAlumno"></param>
		/// <param name="rutaHorario"></param>
		/// <param name="activo"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/25/2016 12:23:20 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Insert(int idPrestacion, int idPrograma, int matriculaAlumno, DateTime fechaInicio, DateTime fechaFin, int horas, string horarioAlumno, string rutaHorario, int activo)
		{
			try{
                Database myDatabase = factory.Create("constr");
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("Insertprogramasasignados");

				myCommand.Parameters.Add(CreateInParameter("P_idPrestacion", MySqlDbType.Int32, idPrestacion));
				myCommand.Parameters.Add(CreateInParameter("P_idPrograma", MySqlDbType.Int32, idPrograma));
				myCommand.Parameters.Add(CreateInParameter("P_matriculaAlumno", MySqlDbType.Int32, matriculaAlumno));
				myCommand.Parameters.Add(CreateInParameter("P_fechaInicio", MySqlDbType.DateTime, fechaInicio));
				myCommand.Parameters.Add(CreateInParameter("P_fechaFin", MySqlDbType.DateTime, fechaFin));
				myCommand.Parameters.Add(CreateInParameter("P_horas", MySqlDbType.Int32, horas));
				myCommand.Parameters.Add(CreateInParameter("P_horarioAlumno", MySqlDbType.VarChar, horarioAlumno));
				myCommand.Parameters.Add(CreateInParameter("P_rutaHorario", MySqlDbType.VarChar, rutaHorario));
				myCommand.Parameters.Add(CreateInParameter("P_activo", MySqlDbType.Int32, activo));

				myDatabase.ExecuteNonQuery(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "NO");
			
			}
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Updates a record in the PROGRAMASASIGNADOS table.
		/// <summary>
		/// <param name="idPrestacion"></param>
		/// <param name="idPrograma"></param>
		/// <param name="matriculaAlumno"></param>
		/// <param name="fechaInicio"></param>
		/// <param name="fechaFin"></param>
		/// <param name="horas"></param>
		/// <param name="horarioAlumno"></param>
		/// <param name="rutaHorario"></param>
		/// <param name="activo"></param>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/25/2016 12:23:20 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Update(int idPrestacion, int idPrograma, int matriculaAlumno, DateTime fechaInicio, DateTime fechaFin, int horas, string horarioAlumno, string rutaHorario, int activo)
		{
			try{
                Database myDatabase = factory.Create("constr");
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("Updateprogramasasignados");

				myCommand.Parameters.Add(CreateInParameter("P_idPrestacion", MySqlDbType.Int32, idPrestacion));
				myCommand.Parameters.Add(CreateInParameter("P_idPrograma", MySqlDbType.Int32, idPrograma));
				myCommand.Parameters.Add(CreateInParameter("P_matriculaAlumno", MySqlDbType.Int32, matriculaAlumno));
				myCommand.Parameters.Add(CreateInParameter("P_fechaInicio", MySqlDbType.DateTime, fechaInicio));
				myCommand.Parameters.Add(CreateInParameter("P_fechaFin", MySqlDbType.DateTime, fechaFin));
				myCommand.Parameters.Add(CreateInParameter("P_horas", MySqlDbType.Int32, horas));
				myCommand.Parameters.Add(CreateInParameter("P_horarioAlumno", MySqlDbType.VarChar, horarioAlumno));
				myCommand.Parameters.Add(CreateInParameter("P_rutaHorario", MySqlDbType.VarChar, rutaHorario));
				myCommand.Parameters.Add(CreateInParameter("P_activo", MySqlDbType.Int32, activo));

				myDatabase.ExecuteNonQuery(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "NO");
				if(rethrow)
					throw;
			}
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects all records from the PROGRAMASASIGNADOS table.
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
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("SelectAllprogramasasignados");

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
