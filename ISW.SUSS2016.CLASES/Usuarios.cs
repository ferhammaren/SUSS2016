
using SUSS2016.DA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUSS2016.CLASES
{
    public class Usuarios
    {
        static int numUsuario;

        public static Boolean autenticarUsuario(String correo, String pass, int rol)
        {
            DataSet resultado;
            resultado = USUARIOS.SelectSingle(correo, pass, rol);
            if (resultado.Tables[0].Rows.Count > 0)
            {
                numUsuario = Convert.ToInt32(resultado.Tables[0].Rows[0]["numeroUsuario"].ToString());
                return true;
            }
            else
                return false;
        }
        public static int getUserNumber()
        {
            return numUsuario;
        }
    }
}
