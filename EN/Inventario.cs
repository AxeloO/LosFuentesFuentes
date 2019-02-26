 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN
{
    public class Inventario
    {
        
        public long IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string GrupoPertenenciente { get; set; }
        public decimal Cantidad { get; set; }
        public string Presentacion { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal PrecioContado { get; set; }
        public decimal PrecioACredito { get; set; }
    }
}
