using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EN;
using DAL;


namespace BL
{
    public class ProveedoresBL
    {
        ProveedoresDAL _ProveedorDal = new ProveedoresDAL();//Creacion de instancia Dal
        EnProveedores _enProveedor = new EnProveedores();//Creacion de la instancia EN

        public int AgregarProveedor(EnProveedores _enProveedor)
        {
            return _ProveedorDal.AgregarProveedor(_enProveedor);
        }
        public List<EnProveedores> MostrarProveedor()
        {
            return _ProveedorDal.MostrarEnProveedores();
        }
        public List<EnProveedores> MostrarClientePorNombre(EnProveedores _enProveedor)
        {
            return _ProveedorDal.MostrarEnProveedorPorNombre(_enProveedor);
        }
        public int ModificarProducto(EnProveedores _enProveedor)
        {
            return _ProveedorDal.ModificarProveedor(_enProveedor);
        }
        public int EliminarProducto(EnProveedores _enProveedor)
        {
            return _ProveedorDal.EliminarProveedor(_enProveedor);
        }
    }
}
