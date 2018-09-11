using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class EnUsuario
    {//Recibe los parametros de la base de datos
        public long  fiIdUsuario { get; set; }
        public string fcNombreCompleto { get; set; }
        public string fcNombreUsuario { get; set; }
        public int fiPuestoUsuario { get; set; }
        public string fcPassword { get; set; }
    }
}
