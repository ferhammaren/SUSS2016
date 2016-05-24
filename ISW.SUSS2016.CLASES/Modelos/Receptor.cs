using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ISW.Clases
{
    class Receptor : Usuario
    {
        private string nombre { get; set; }
        private string ap_paterno { get; set; }
        private string ap_materno { get; set; }
        private int idReceptor { get; set; }

        public Receptor(string nombre, string ap_paterno, string ap_matenro, int idReceptor)
        {
            this.nombre = nombre;
            this.ap_paterno = ap_paterno;
            this.ap_paterno = ap_materno;
            this.idReceptor = idReceptor;
        }
    }
}
