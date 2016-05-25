using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ISW.Clases
{
    public class Receptor : Usuario
    {
        public string nombre { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public int idReceptor { get; set; }

        public Receptor(string nombre, string ap_paterno, string ap_matenro, int idReceptor)
        {
            this.nombre = nombre;
            this.ap_paterno = ap_paterno;
            this.ap_paterno = ap_materno;
            this.idReceptor = idReceptor;
        }
    }
}
