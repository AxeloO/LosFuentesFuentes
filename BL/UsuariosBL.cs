using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EN;
using DAL;

namespace BL
{
    public class UsuariosBL
    {

        UsuariosDal _dalUsuarios = new UsuariosDal();

        public List<EnUsuario> ListaDeUsuarios()
        {
            return _dalUsuarios.ListaDeUsuarios(); ;
        }
    }
}
