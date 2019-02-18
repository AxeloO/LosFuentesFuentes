using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN;
using DAL;

namespace BL
{
    public class InventarioBL
    {
        inventariosDal _dal = new inventariosDal();

        public int AgregarProductos(Inventario PEntidad)
        {
            return _dal.AgregarProducto(PEntidad);
        }
        public List<Inventario> MostrarInventario()
        {
          return _dal.MostrarInventario();
        }
        public List<Inventario> MostrarInventarioEmpleado()
        {
            return _dal.MostrarInventarioEmpleado();
        }
        public List<Inventario> MostrarInventarioPorNombre(Inventario PEntidad)
        {
            return _dal.MostrarInventarioPorNombre(PEntidad);
        }
        public int ModificarProducto(Inventario PEntidad)
        {
            return _dal.ModificarProducto(PEntidad);
        }
        public int EliminarProducto(Inventario PEntidad)
        {
            return _dal.EliminarProducto(PEntidad);
        }

    }
}
