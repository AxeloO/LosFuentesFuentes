using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class EnCliente
    {
        public long FiIdCliente { get; set; }
        public string FcNombreCompleto { get; set; }
        public string FcDomicilio { get; set; }
        public int FiTelefono { get; set; }
        public string FcRFC { get; set; }
        public string FcTipoCredito { get; set; }
        public string FcTipoGarantia { get; set; }
        public decimal FdLimiteCredito { get; set; }
    }
}
