using Proyecto_ISW.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Modelos
{
    public class Alumno 
    {
        public string nombre { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        private int idUsuario { get; set; }
        public int matricula { get; set; }
        private string unidadAcademica { get; set; }
        public string correoAlt { get; set; }
        public int horasPrimEtapa { get; set; }
        public int horasSegEtapa { get; set; }
        public DateTime fechaTallerPrimEtapa { get; set; }
        public DateTime fechaTallerSegEtapa { get; set; }
        public DateTime fechaAcPrimEtapa { get; set; }
        public DateTime fechaAcSegEtapa { get; set; }
        private ProgramaSS[] programas { get; set; }

        public Alumno(string nombre, string ap_pat, string ap_mat, int matricula, string unidadAc, int idUsuario)
        {
            this.nombre = nombre;
            this.ap_paterno = ap_pat;
            this.ap_materno = ap_mat;
            this.matricula = matricula;
            this.unidadAcademica = unidadAc;
            this.idUsuario = idUsuario;
        }

        public Alumno()
        {

        }

        public String ToString()
        {
            return nombre + " " + ap_paterno + " " + ap_materno + " ";
        }

    }
}
