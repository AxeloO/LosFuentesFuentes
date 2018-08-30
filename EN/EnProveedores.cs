using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class EnProveedores
    {
        public long FiIdProveedor { get; set; }
        public string FcNombreProveedor { get; set; }
        public string FcDomicilio { get; set; }
        public int FiTelefono { get; set; }
        public string FcRFC { get; set; }
        public string FcCuentaBancaria { get; set; }
        public string FcProductosSurtidos { get; set; }
        public decimal FdLimiteCredito { get; set; }

    }
}
