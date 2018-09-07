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
        public int AgregarUsuario(EnUsuario PEntidad)//Hacer uso de la entidad de negocio que se llama EnUsuario creando un parametro PEntidad
        {//Establece la conexion con la conexion a la base de datos
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            //Llamada de procesos almacenados creados en el sql server
            SqlCommand _comando = new SqlCommand("Agregar_Usuario", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@fiIdUsuario", PEntidad.fiIdUsuario));
            _comando.Parameters.Add(new SqlParameter("@fcNombreCompleto", PEntidad.fcNombreCompleto));
            _comando.Parameters.Add(new SqlParameter("@fcNombreUsuario", PEntidad.fcNombreUsuario));
            _comando.Parameters.Add(new SqlParameter("@fiPuestoUsuario", PEntidad.fiPuestoUsuario));
            _comando.Parameters.Add(new SqlParameter("@fcPassword", PEntidad.fcPassword));
            int Resultado = _comando.ExecuteNonQuery();

            _Conexion.Close();
            return Resultado;
        }

        public List<EnUsuario> ListaDeUsuarios()//Mostrar Usuarios
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Consultar_Usuarios", _Conexion as SqlConnection);//Lamada de procedimieno almacenado
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _comando.ExecuteReader();//lee los resultados que nos va a mostrar
            //Creacion de lista que nos mostrara los resultados de la consulta
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
            _Conexion.Close();//Cierra la conexion con la base de datos
            return Lista;
        }



        public int EliminarUsuario(EnUsuario PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Eliminar_Usuario", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@fiIdUsuario", PEntidad.fiIdUsuario));
            int Resultado = _comando.ExecuteNonQuery();
            _Conexion.Close();
            return Resultado;

        }

    }

  
}
