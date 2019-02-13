using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class EnCuentasPorPagar
    {
        public long FiIdProveedor { get; set; }
        public string FcNombreProveedor { get; set; }
        public int FiNoFactura { get; set; }
        public string FDtFechaAdquisicion { get; set; }
        public string FcProductoAdquirido { get; set; }
        public decimal FdCantidad { get; set; }      
        public decimal FdTotalAPagar { get; set; }  
        public string FcStatus { get; set; }
    }
}
