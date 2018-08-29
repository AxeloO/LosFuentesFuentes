using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using EN;

namespace BL
{
    public class VentasBL
    {
        VentasDal _ventasDal = new VentasDal();

        public int AgregarVenta(EnVentas PEntidad)
        {
            return _ventasDal.AgregarVenta(PEntidad);
        }


        public List<EnVentas> MostrarVentas()
        {
            return _ventasDal.MostrarEnVentas();
        }

        public List<EnVentas> MostrarVentasPorDia(EnVentas PEntidad)
        {
            return _ventasDal.MostrarEnVentasPorDia(PEntidad);
        }

    }
}
