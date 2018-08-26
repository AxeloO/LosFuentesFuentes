using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using EN;

namespace DAL
{
   public class UsuariosDal
    {

        public List<EnUsuario> ListaDeUsuarios()
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Consultar_Usuarios", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _comando.ExecuteReader();


            List<EnUsuario> Lista = new List<EnUsuario>();
            while (_reader.Read())
            {
                EnUsuario _EnUsuario = new EnUsuario();



                _EnUsuario.fiIdUsuario = _reader.GetInt64(0);
                _EnUsuario.fcNombreCompleto = _reader.GetString(1);
                _EnUsuario.fcNombreUsuario = _reader.GetString(2);
                _EnUsuario.fiPuestoUsuario = _reader.GetInt32(3);
                _EnUsuario.fcPassword = _reader.GetString(4);
               
                Lista.Add(_EnUsuario);
            }
            _Conexion.Close();
            return Lista;
        }

    }
}
