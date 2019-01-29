using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using EN;
using DAL;

namespace BL
{
    public class UsuariosBL
    {

        UsuariosDal _dalUsuarios = new UsuariosDal();

        public int AgregarUsuario(EnUsuario PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();

            SqlCommand _comando = new SqlCommand("Agregar_Usuario", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@fcNombreCompleto", PEntidad.fcNombreCompleto));
            _comando.Parameters.Add(new SqlParameter("@fcNombreUsuario", PEntidad.fcNombreUsuario));
            _comando.Parameters.Add(new SqlParameter("@fiPuestoUsuario", PEntidad.fiPuestoUsuario));
            _comando.Parameters.Add(new SqlParameter("@fcPassword", PEntidad.fcPassword));


            int Resultado = _comando.ExecuteNonQuery();

            _Conexion.Close();
            return Resultado;
        }

        public List<EnUsuario> ListaDeUsuarios()
        {
            return _dalUsuarios.ListaDeUsuarios(); ;
        }               
        
        public int EliminarUsuario(EnUsuario PEntidad)
        {
            return _dalUsuarios.EliminarUsuario(PEntidad);
        }
      
      
    }
}
