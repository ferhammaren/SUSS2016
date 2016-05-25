using System;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using MySql.Data.MySqlClient;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace SUSS2016.DA
{
	/// -----------------------------------------------------------------------------
	/// Project	 : datas
	/// Class	 : Usuarios
	/// 
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// Data access class for USUARIOS table.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Fer]	5/17/2016 6:23:02 PM	Created
	/// </history>
	/// -----------------------------------------------------------------------------
	public sealed class USUARIOS
	{
       private static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        private USUARIOS() {}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Inserts a record into the USUARIOS table.
		/// <summary>
		/// <param name="nom_Usuario"></param>
		/// <param name="pass_Usuario"></param>
		/// <param name="ultimo_Acceso"></param>
		/// <returns></returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/17/2016 6:23:02 PM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static Int32 Insert(string nom_Usuario, string pass_Usuario, DateTime ultimo_Acceso)
		{
			try{
                Database myDatabase = factory.Create("constr");
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("practica1.Insertusuarios");

				myCommand.Parameters.Add(CreateInParameter("P_nom_Usuario", MySqlDbType.VarChar, nom_Usuario));
				myCommand.Parameters.Add(CreateInParameter("P_pass_Usuario", MySqlDbType.VarChar, pass_Usuario));
				myCommand.Parameters.Add(CreateInParameter("P_ultimo_Acceso", MySqlDbType.DateTime, ultimo_Acceso));

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
		/// Deletes a record from the USUARIOS table by a composite primary key.
		/// <summary>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/17/2016 6:23:02 PM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static void Delete(int num_Usuario)
		{
			try{
                Database myDatabase = factory.Create("constr");
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("practica1.Deleteusuarios");

				myCommand.Parameters.Add(CreateInParameter("P_num_Usuario", MySqlDbType.Int32, num_Usuario));

				myDatabase.ExecuteNonQuery(myCommand);
			}catch(Exception ex){
				bool rethrow = ExceptionPolicy.HandleException(ex, "hue");
				if(rethrow)
					throw;
			}
		}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// Selects a single record from the USUARIOS table.
		/// <summary>
		/// <returns>DataSet</returns>
		/// <remarks>
		/// </remarks>
		/// <history>
		/// 	[Fer]	5/17/2016 6:23:02 PM	Created
		/// </history>
		/// -----------------------------------------------------------------------------
		public static DataSet  SelectSingle(string correo,string pass,int rol) 
		{

			try{
                Database myDatabase = factory.Create("constr");
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.autenticarUsuario");

				myCommand.Parameters.Add(CreateInParameter("correo", MySqlDbType.VarChar, correo));
                myCommand.Parameters.Add(CreateInParameter("usPass", MySqlDbType.VarChar, pass));
                myCommand.Parameters.Add(CreateInParameter("rol", MySqlDbType.Int32, rol));



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
		/// Selects all records from the USUARIOS table.
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
                Database myDatabase = factory.Create("constr");
                MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("SelectAllusuarios");

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
