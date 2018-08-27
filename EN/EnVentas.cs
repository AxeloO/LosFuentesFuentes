using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class EnVentas
    {
        public long fiIdVenta { get; set; }
        public string fDtFechaSalida { get; set; }
        public string fcNombreCliente { get; set; }
        public string fcDomicilio { get; set; }
        public string fcCiudad { get; set; }
        public string fcTelefono { get; set; }
        public string fcFechaPago { get; set; }
        public int fiCantidad { get; set; }
        public string fcConcepto { get; set; }
        public decimal fdPrecioUnitario { get; set; }
        public decimal fdImporte { get; set; }
        public decimal fdTotal { get; set; }
    }
}
