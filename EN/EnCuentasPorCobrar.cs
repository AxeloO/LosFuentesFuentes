using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class EnCuentasPorCobrar
    {
        public int FiIdCliente { get; set; }
        public string FcNombreCLiente { get; set; }
        public string FDtFechaAdquisicion { get; set; }
        public string FDtFechaLimitePago { get; set; }
        public int FiNoNota { get; set; }
        public decimal FdMontoAPagar { get; set; }
        public int FiInteresNormal { get; set; }
        public int FdTotalAPagar { get; set; }        
    }
}
