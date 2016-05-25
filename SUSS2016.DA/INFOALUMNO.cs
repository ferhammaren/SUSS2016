using System;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using MySql.Data.MySqlClient;

namespace SUSS2016.DA
{
	/// -----------------------------------------------------------------------------
	/// Project	 : datas
	/// Class	 : Infoalumno
	/// 
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// Data access class for INFOALUMNO table.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Fer]	5/22/2016 3:40:25 AM	Created
	/// </history>
	/// -----------------------------------------------------------------------------
	public sealed class INFOALUMNO
	{
        private static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        private INFOALUMNO() {}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Inserts a record into the INFOALUMNO table.
		/// <summary>
		/// <param name="matricula"></param>
		/// <param name="numUsuario"></param>
		/// <param name="ap_paterno"></param>
		/// <param name="ap_materno"></param>
		/// <param name="nombre"></param>
		/// <param name="correoAlt"></param>
		/// <param name="unidadAcademica"></param>
		/// <param name="carrera"></param>
		/// <param name="creditosCumplidos"></param>
		/// <param name="fechaTallerPrimeraEtapa"></param>
		/// <param name="fechaTallerSegundaEtapa"></param>
		/// <param name="horasPrimeraEtapa"></param>
		/// <param name="horasSegundaEtapa"></param>
		/// <param name="fechaAcPrimeraEtapa"></param>
		/// <param name="fechaAcSegundaEtapa"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/22/2016 3:40:25 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Insert(int matricula, int numUsuario, string ap_paterno, string ap_materno, string nombre, string correoAlt, int unidadAcademica, int carrera, int creditosCumplidos, DateTime fechaTallerPrimeraEtapa, DateTime fechaTallerSegundaEtapa, int horasPrimeraEtapa, int horasSegundaEtapa, DateTime fechaAcPrimeraEtapa, int fechaAcSegundaEtapa)
		{
            Database myDatabase = factory.Create("constr");
            MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.Insertinfoalumno");

			myCommand.Parameters.Add(CreateInParameter("P_matricula", MySqlDbType.Int32, matricula));
			myCommand.Parameters.Add(CreateInParameter("P_numUsuario", MySqlDbType.Int32, numUsuario));
			myCommand.Parameters.Add(CreateInParameter("P_ap_paterno", MySqlDbType.VarChar, ap_paterno));
			myCommand.Parameters.Add(CreateInParameter("P_ap_materno", MySqlDbType.VarChar, ap_materno));
			myCommand.Parameters.Add(CreateInParameter("P_nombre", MySqlDbType.VarChar, nombre));
			myCommand.Parameters.Add(CreateInParameter("P_correoAlt", MySqlDbType.VarChar, correoAlt));
			myCommand.Parameters.Add(CreateInParameter("P_unidadAcademica", MySqlDbType.Int32, unidadAcademica));
			myCommand.Parameters.Add(CreateInParameter("P_carrera", MySqlDbType.Int32, carrera));
			myCommand.Parameters.Add(CreateInParameter("P_creditosCumplidos", MySqlDbType.Int32, creditosCumplidos));
			myCommand.Parameters.Add(CreateInParameter("P_fechaTallerPrimeraEtapa", MySqlDbType.DateTime, fechaTallerPrimeraEtapa));
			myCommand.Parameters.Add(CreateInParameter("P_fechaTallerSegundaEtapa", MySqlDbType.DateTime, fechaTallerSegundaEtapa));
			myCommand.Parameters.Add(CreateInParameter("P_horasPrimeraEtapa", MySqlDbType.Int32, horasPrimeraEtapa));
			myCommand.Parameters.Add(CreateInParameter("P_horasSegundaEtapa", MySqlDbType.Int32, horasSegundaEtapa));
			myCommand.Parameters.Add(CreateInParameter("P_fechaAcPrimeraEtapa", MySqlDbType.DateTime, fechaAcPrimeraEtapa));
			myCommand.Parameters.Add(CreateInParameter("P_fechaAcSegundaEtapa", MySqlDbType.Int32, fechaAcSegundaEtapa));

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Updates a record in the INFOALUMNO table.
		/// <summary>
		/// <param name="matricula"></param>
		/// <param name="numUsuario"></param>
		/// <param name="ap_paterno"></param>
		/// <param name="ap_materno"></param>
		/// <param name="nombre"></param>
		/// <param name="correoAlt"></param>
		/// <param name="unidadAcademica"></param>
		/// <param name="carrera"></param>
		/// <param name="creditosCumplidos"></param>
		/// <param name="fechaTallerPrimeraEtapa"></param>
		/// <param name="fechaTallerSegundaEtapa"></param>
		/// <param name="horasPrimeraEtapa"></param>
		/// <param name="horasSegundaEtapa"></param>
		/// <param name="fechaAcPrimeraEtapa"></param>
		/// <param name="fechaAcSegundaEtapa"></param>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/22/2016 3:40:25 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Update(int matricula, int numUsuario, string correoAlt, int creditosCumplidos, DateTime fechaTallerPrimeraEtapa, DateTime fechaTallerSegundaEtapa, int horasPrimeraEtapa, int horasSegundaEtapa, DateTime fechaAcPrimeraEtapa, int fechaAcSegundaEtapa)
		{
            Database myDatabase = factory.Create("constr");
            MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.Updateinfoalumno");

			myCommand.Parameters.Add(CreateInParameter("P_matricula", MySqlDbType.Int32, matricula));
			myCommand.Parameters.Add(CreateInParameter("P_numUsuario", MySqlDbType.Int32, numUsuario));
			myCommand.Parameters.Add(CreateInParameter("P_correoAlt", MySqlDbType.VarChar, correoAlt));
			myCommand.Parameters.Add(CreateInParameter("P_creditosCumplidos", MySqlDbType.Int32, creditosCumplidos));
			myCommand.Parameters.Add(CreateInParameter("P_fechaTallerPrimeraEtapa", MySqlDbType.DateTime, fechaTallerPrimeraEtapa));
			myCommand.Parameters.Add(CreateInParameter("P_fechaTallerSegundaEtapa", MySqlDbType.DateTime, fechaTallerSegundaEtapa));
			myCommand.Parameters.Add(CreateInParameter("P_horasPrimeraEtapa", MySqlDbType.Int32, horasPrimeraEtapa));
			myCommand.Parameters.Add(CreateInParameter("P_horasSegundaEtapa", MySqlDbType.Int32, horasSegundaEtapa));
			myCommand.Parameters.Add(CreateInParameter("P_fechaAcPrimeraEtapa", MySqlDbType.DateTime, fechaAcPrimeraEtapa));
			myCommand.Parameters.Add(CreateInParameter("P_fechaAcSegundaEtapa", MySqlDbType.Int32, fechaAcSegundaEtapa));

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Deletes a record from the INFOALUMNO table by a composite primary key.
		/// <summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/22/2016 3:40:25 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Delete(int matricula)
		{
            Database myDatabase = factory.Create("constr");
            MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.Deleteinfoalumno");

			myCommand.Parameters.Add(CreateInParameter("P_matricula", MySqlDbType.Int32, matricula));

			myDatabase.ExecuteNonQuery(myCommand);
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects a single record from the INFOALUMNO table.
		/// <summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/22/2016 3:40:25 AM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static DataSet  SelectSingle(int numUsuario) 
		{
            Database myDatabase = factory.Create("constr");
            MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("SelectAlumnoByUserId");

			myCommand.Parameters.Add(CreateInParameter("userId", MySqlDbType.Int32, numUsuario));

			return myDatabase.ExecuteDataSet(myCommand);
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects all records from the INFOALUMNO table.
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
            MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.SelectAllinfoalumno");

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
