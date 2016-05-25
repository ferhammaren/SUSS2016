using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ISW
{
    public abstract class Usuario 
    {
        private string idUsuario { get; set; }
        private string pwd { get; set; }
        private int numUsuario { get; set; }
        private int rolUsuario { get; set; }

        public Usuario(String id, int numUsuario, int rolUsuario)
        {
            this.idUsuario = id;
            this.numUsuario = numUsuario;
            this.rolUsuario = rolUsuario;
        }

        public Usuario() { }
    }
}
