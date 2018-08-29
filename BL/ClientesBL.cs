using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EN;

namespace BL
{
    public class ClientesBL
    {

        ClientesDal _ClientesDal = new ClientesDal();//Creacion de instancia Dal
        EnCliente _enCliente = new EnCliente();//Creacion de la instancia EN

        public int AgregarClientes(EnCliente _enCliente)
        {
            return _ClientesDal.AgregarCliente(_enCliente);
        }
        public List<EnCliente> MostrarClientes()
        {
            return _ClientesDal.MostrarEnCliente();
        }
        public List<EnCliente> MostrarClientePorNombre(EnCliente _enCliente)
        {
            return _ClientesDal.MostrarEnClientePorNombre(_enCliente);
        }
        public int ModificarProducto(EnCliente _enCliente)
        {
            return _ClientesDal.ModificarCliente(_enCliente);
        }
        public int EliminarProducto(EnCliente _enCliente)
        {
            return _ClientesDal.EliminarCliente(_enCliente);
        }
    }
}
