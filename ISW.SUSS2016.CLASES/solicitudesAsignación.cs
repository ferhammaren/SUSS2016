using SUSS2016.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUSS2016.CLASES
{
    class solicitudesAsignación
    {

        public static void enviarSolicitudUR(int programa, int matricula, DateTime fechaAs, DateTime fechaTerm, string horarioAlumno, string horarioPrest)
        {
            SOLICITUDESPENDIENTESUR.Insert(programa, matricula, fechaAs, fechaTerm, horarioAlumno, horarioPrest);
        }
        public static void enviarSolicitudUA(int programa, int matricula, DateTime fechaAs, DateTime fechaTerm, string horarioAlumno, string horarioPrest)
        {
            SOLICITUDESPENDIENTESUA.Insert( matricula, programa, horarioAlumno, horarioPrest, fechaAs, fechaTerm);
            SOLICITUDESPENDIENTESUR.Delete(matricula);
        }
    }
   
    
}
