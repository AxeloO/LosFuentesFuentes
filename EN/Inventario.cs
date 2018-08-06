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
        public string GrupoPerteneciente { get; set; }
        public int Cantidad { get; set; }
        public string Presentacion { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal PorcentajeGananciaContado { get; set; }
        public decimal PrecioContado { get; set; }
        public decimal PorcentajeGananciaCredito { get; set; }
        public decimal PrecioACredito { get; set; }
    }
}
