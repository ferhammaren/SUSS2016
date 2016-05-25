using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SUSS2016.DA;
using Clases.Modelos;

namespace SUSS2016.CLASES
{
   
   public class Alumnos
    {
        
        private static Alumno al=new Alumno();
       private static DataSet ds;

        public static void getInfoAlumno(int numero)
        {
            ds = INFOALUMNO.SelectSingle(numero);
            setAlumnoInfo();
        }

        private static void setAlumnoInfo()
        {
            //  Alumno.ap_paterno=(ds.Tables[0].Rows[0]["ap_paterno"]);
             al = new Alumno(ds.Tables[0].Rows[0]["nombre"].ToString(), ds.Tables[0].Rows[0]["ap_paterno"].ToString(), ds.Tables[0].Rows[0]["ap_materno"].ToString(), Convert.ToInt32(ds.Tables[0].Rows[0]["matricula"]), ds.Tables[0].Rows[0]["unidadAcademica"].ToString(), Convert.ToInt32(ds.Tables[0].Rows[0]["numUsuario"]));

        }

        //public static String getNombre()
        //{
        //    String nombre = al.ToString();
            
        //    return nombre;
        //}

        public static Alumno getAlumno()
        {
            return al;
        }

        public static String getNombre()
        {
            return al.nombre + " " + al.ap_paterno + " " + al.ap_materno + " ";

        }
        public static String getMatricula()
        {
            return al.matricula+"";
        }
    }
}
