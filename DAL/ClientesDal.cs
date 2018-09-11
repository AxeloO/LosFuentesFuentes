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
    public class ClientesDal
    {
        public int AgregarCliente(EnCliente PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();

            SqlCommand _comando = new SqlCommand("Agregar_Cliente", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@FcNombreCompleto", PEntidad.FcNombreCompleto));
            _comando.Parameters.Add(new SqlParameter("@FcDomicilio", PEntidad.FcDomicilio));
            _comando.Parameters.Add(new SqlParameter("@FiTelefono", PEntidad.FiTelefono));
            _comando.Parameters.Add(new SqlParameter("@FcRFC", PEntidad.FcRFC));
            _comando.Parameters.Add(new SqlParameter("@FcTipoCredito", PEntidad.FcTipoCredito));
            _comando.Parameters.Add(new SqlParameter("@FcTipoGarantia", PEntidad.FcTipoGarantia));
            _comando.Parameters.Add(new SqlParameter("@FdLimiteCredito", PEntidad.FdLimiteCredito));
            //_comando.Parameters.Add(new SqlParameter("@PorcentajeGananciaCredito", PEntidad.FdLimiteCredito));
            
            int Resultado = _comando.ExecuteNonQuery();

            _Conexion.Close();
            return Resultado;
        }

        public List<EnCliente> MostrarEnCliente()
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Consultar_Cliente", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _comando.ExecuteReader();
            List<EnCliente> Lista = new List<EnCliente>();
            while (_reader.Read())
            {
                EnCliente _EnCliente = new EnCliente();
                _EnCliente.FiIdCliente = _reader.GetInt64(0);
                _EnCliente.FcNombreCompleto = _reader.GetString(1);
                _EnCliente.FcDomicilio = _reader.GetString(2);
                _EnCliente.FiTelefono = _reader.GetString(3);
                _EnCliente.FcRFC = _reader.GetString(4);
                _EnCliente.FcTipoCredito = _reader.GetString(5);
                _EnCliente.FcTipoGarantia = _reader.GetString(6);
                _EnCliente.FdLimiteCredito = _reader.GetDecimal(7);               
                Lista.Add(_EnCliente);
            }
            _Conexion.Close();
            return Lista;
        }

        public List<EnCliente> MostrarEnClientePorNombre(EnCliente PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Consultar_Cliente_Por_Nombre", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@FcNombreCompleto", PEntidad.FcNombreCompleto));
            IDataReader _reader = _comando.ExecuteReader();
            List<EnCliente> Lista = new List<EnCliente>();
            while (_reader.Read())
            {
                EnCliente _EnCliente = new EnCliente();

                _EnCliente.FiIdCliente = _reader.GetInt64(0);
                _EnCliente.FcNombreCompleto = _reader.GetString(1);
                _EnCliente.FcDomicilio = _reader.GetString(2);
                _EnCliente.FiTelefono = _reader.GetString(3);
                _EnCliente.FcRFC = _reader.GetString(4);
                _EnCliente.FcTipoCredito = _reader.GetString(5);
                _EnCliente.FcTipoGarantia = _reader.GetString(6);
                _EnCliente.FdLimiteCredito = _reader.GetDecimal(7);

                Lista.Add(_EnCliente);

            }
            _Conexion.Close();

            return Lista;
        }

        public int ModificarCliente(EnCliente PEntidad)
        {
            IDbConnection _conexion = DBConexion.Conexion();
            _conexion.Open();
            SqlCommand _comando = new SqlCommand("Modificar_Cliente", _conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@FiIdCliente", PEntidad.FiIdCliente));
            _comando.Parameters.Add(new SqlParameter("@FcNombreCompleto", PEntidad.FcNombreCompleto));
            _comando.Parameters.Add(new SqlParameter("@FcDomicilio", PEntidad.FcDomicilio));
            _comando.Parameters.Add(new SqlParameter("@FiTelefono", PEntidad.FiTelefono));
            _comando.Parameters.Add(new SqlParameter("@FcRFC", PEntidad.FcRFC));
            _comando.Parameters.Add(new SqlParameter("@FcTipoCredito", PEntidad.FcTipoCredito));
            _comando.Parameters.Add(new SqlParameter("@FcTipoGarantia", PEntidad.FcTipoGarantia));
            _comando.Parameters.Add(new SqlParameter("@FdLimiteCredito", PEntidad.FdLimiteCredito));
            
            int Resultado = _comando.ExecuteNonQuery();
            _conexion.Close();
            return Resultado;

        }

        public int EliminarCliente(EnCliente PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Eliminar_Cliente", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@FiIdCliente", PEntidad.FiIdCliente));
            int Resultado = _comando.ExecuteNonQuery();
            _Conexion.Close();
            return Resultado;

        }
    }
}
