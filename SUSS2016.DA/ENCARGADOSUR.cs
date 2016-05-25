using System;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using MySql.Data.MySqlClient;

namespace SUSS2016.DA
{
	/// -----------------------------------------------------------------------------
	/// Project	 : DA
	/// Class	 : Encargadosur
	/// 
	/// -----------------------------------------------------------------------------
	/// <summary>
	/// Data access class for ENCARGADOSUR table.
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <history>
	/// 	[Fer]	5/25/2016 4:32:39 PM	Created
	/// </history>
	/// -----------------------------------------------------------------------------
	public sealed class ENCARGADOSUR
	{
        private static DatabaseProviderFactory factory = new DatabaseProviderFactory();
        private ENCARGADOSUR() {}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Selects all records from the ENCARGADOSUR table.
        /// <summary>
        /// <returns>DataSet</returns>
        /// <remarks>
        /// </remarks>
        /// <history>
        /// 	[Fer]	5/25/2016 4:32:39 PM	Created
        /// </history>
        /// -----------------------------------------------------------------------------
        public static DataSet SelectSingle(int numUsuario)
        {
            Database myDatabase = factory.Create("constr");
            MySqlCommand myCommand = (MySqlCommand)myDatabase.GetStoredProcCommand("SelectSingleencargadosur");

            myCommand.Parameters.Add(CreateInParameter("userId", MySqlDbType.Int32, numUsuario));

            return myDatabase.ExecuteDataSet(myCommand);
        }
        public static DataSet  SelectAll()
		{
            Database myDatabase = factory.Create("constr");
            MySqlCommand myCommand = (MySqlCommand) myDatabase.GetStoredProcCommand("suss.SelectAllencargadosur");

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
