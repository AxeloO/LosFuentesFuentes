using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EN;


namespace BL
{


    public class DevolucionesBL
    {
        devolucionesDal _dal = new devolucionesDal();

        public int AgregarDevolucion(EnDevolucion PEntidad)
        {

            return _dal.AgregarDevolucion(PEntidad);
        }
        public List<EnDevolucion> ListaDevoluciones()
        {
            return _dal.MostrarEnDevolucion();
        }

    }
}
