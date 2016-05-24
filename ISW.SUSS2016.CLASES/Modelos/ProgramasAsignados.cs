using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ISW.Clases
{
    class ProgramasAsignados
    {
        private int idPrestacion { get; set; }
        private int idPrograma { get; set; }
        private int matricula { get; set; }
        private DateTime fechaInicio { get; set; }
        private int horas { get; set; }
        private string horarioAlumno { get; set; }
        private string rutaHorario { get; set; }
        private Boolean activo { get; set; }

        public ProgramasAsignados(int idPres, int idProg, int mat, DateTime fechaIni, int horas, string horario, string rutaH, Boolean act)
        {
            this.idPrestacion = idPres;
            this.idPrograma = idProg;
            this.matricula = mat;
            this.fechaInicio = fechaIni;
            this.horas = horas;
            this.horarioAlumno = horario;
            this.rutaHorario = rutaH;
            this.activo = act;
        }
    }
}
