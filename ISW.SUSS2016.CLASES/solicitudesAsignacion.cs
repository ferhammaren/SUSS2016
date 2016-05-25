using SUSS2016.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUSS2016.CLASES
{
    public class solicitudesAsignacion
    {
        public static string hAlumno = "";
        public static string hprestacion = "";
        public solicitudesAsignacion()
        {

        }
        public static void enviarSolicitudUR(int programa, int matricula, DateTime fechaAs, DateTime fechaTerm)
        {
            SOLICITUDESPENDIENTESUR.Insert(programa, matricula, fechaAs, fechaTerm, hAlumno, hprestacion);
        }
        public static void enviarSolicitudUA(int programa, int matricula, DateTime fechaAs, DateTime fechaTerm, string horarioAlumno, string horarioPrest)
        {
            SOLICITUDESPENDIENTESUA.Insert(matricula, programa, hAlumno, hprestacion, fechaAs, fechaTerm);
            SOLICITUDESPENDIENTESUR.Delete(matricula);
        }
        public static void sethAlumno(string path)
        {
            hAlumno = path;
        }
        public static void sethPrestacion(string path)
        {
            hprestacion = path;
        }
    }


}
