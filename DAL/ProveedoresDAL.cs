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
    public class ProveedoresDAL
    {

        public int AgregarProveedor(EnProveedores PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();

            SqlCommand _comando = new SqlCommand("Agregar_Proveedor", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@FcNombreProveedor", PEntidad.FcNombreProveedor));
            _comando.Parameters.Add(new SqlParameter("@FcDireccion", PEntidad.FcDomicilio));
            _comando.Parameters.Add(new SqlParameter("@FiTelefono", PEntidad.FiTelefono));
            _comando.Parameters.Add(new SqlParameter("@FcRFC", PEntidad.FcRFC));
            _comando.Parameters.Add(new SqlParameter("@FcCuentaBancaria", PEntidad.FcCuentaBancaria));
            _comando.Parameters.Add(new SqlParameter("@FcProductosSurtidos", PEntidad.FcProductosSurtidos));
            _comando.Parameters.Add(new SqlParameter("@FdLimiteCredito", PEntidad.FdLimiteCredito));
            //_comando.Parameters.Add(new SqlParameter("@PorcentajeGananciaCredito", PEntidad.FdLimiteCredito));

            int Resultado = _comando.ExecuteNonQuery();

            _Conexion.Close();
            return Resultado;
        }

        public List<EnProveedores> MostrarEnProveedores()
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Consultar_Proveedor", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _comando.ExecuteReader();
            List<EnProveedores> Lista = new List<EnProveedores>();
            while (_reader.Read())
            {
                EnProveedores _EnProveedor = new EnProveedores();
                _EnProveedor.FiIdProveedor = _reader.GetInt64(0);
                _EnProveedor.FcNombreProveedor = _reader.GetString(1);
                _EnProveedor.FcDomicilio = _reader.GetString(2);
                _EnProveedor.FiTelefono = _reader.GetString(3);
                _EnProveedor.FcRFC = _reader.GetString(4);
                _EnProveedor.FcCuentaBancaria = _reader.GetString(5);
                _EnProveedor.FcProductosSurtidos = _reader.GetString(6);
                _EnProveedor.FdLimiteCredito = _reader.GetDecimal(7);
                Lista.Add(_EnProveedor);
            }
            _Conexion.Close();
            return Lista;
        }

        public List<EnProveedores> MostrarEnProveedorPorNombre(EnProveedores PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Consultar_Proveedor_Por_Nombre", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@FcNombreProveedor", PEntidad.FcNombreProveedor));
            IDataReader _reader = _comando.ExecuteReader();
            List<EnProveedores> Lista = new List<EnProveedores>();
            while (_reader.Read())
            {
                EnProveedores _EnProveedores = new EnProveedores ();

                _EnProveedores.FiIdProveedor = _reader.GetInt64(0);
                _EnProveedores.FcNombreProveedor = _reader.GetString(1);
                _EnProveedores.FcDomicilio = _reader.GetString(2);
                _EnProveedores.FiTelefono = _reader.GetString(3);
                _EnProveedores.FcRFC = _reader.GetString(4);
                _EnProveedores.FcCuentaBancaria = _reader.GetString(5);
                _EnProveedores.FcProductosSurtidos = _reader.GetString(6);
                _EnProveedores.FdLimiteCredito = _reader.GetDecimal(7);

                Lista.Add(_EnProveedores);

            }
            _Conexion.Close();

            return Lista;
        }

        public int ModificarProveedor(EnProveedores PEntidad)
        {
            IDbConnection _conexion = DBConexion.Conexion();
            _conexion.Open();
            SqlCommand _comando = new SqlCommand("Modificar_Proveedor", _conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@FiIdProveedor", PEntidad.FiIdProveedor));
            _comando.Parameters.Add(new SqlParameter("@FcNombreProveedor", PEntidad.FcNombreProveedor));
            _comando.Parameters.Add(new SqlParameter("@FcDomicilio", PEntidad.FcDomicilio));
            _comando.Parameters.Add(new SqlParameter("@FiTelefono", PEntidad.FiTelefono));
            _comando.Parameters.Add(new SqlParameter("@FcRFC", PEntidad.FcRFC));
            _comando.Parameters.Add(new SqlParameter("@FcCuentaBancaria", PEntidad.FcCuentaBancaria));
            _comando.Parameters.Add(new SqlParameter("@FcProductosSurtidos", PEntidad.FcProductosSurtidos));
            _comando.Parameters.Add(new SqlParameter("@FdLimiteCredito", PEntidad.FdLimiteCredito));

            int Resultado = _comando.ExecuteNonQuery();
            _conexion.Close();
            return Resultado;

        }

        public int EliminarProveedor(EnProveedores PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Eliminar_Proveedor", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@FiIdProveedor", PEntidad.FiIdProveedor));
            int Resultado = _comando.ExecuteNonQuery();
            _Conexion.Close();
            return Resultado;

        }
    }
}
