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
   public class CuentasPorPagarDal
    {

        public int AgregarCuentasPorPagar(EnCuentasPorPagar PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();

            SqlCommand _comando = new SqlCommand("Agregar_Cuentas_Por_Pagar", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@FcNombreProveedor", PEntidad.FcNombreProveedor));
            _comando.Parameters.Add(new SqlParameter("@FiNoFactura", PEntidad.FiNoFactura));
            _comando.Parameters.Add(new SqlParameter("@FdFechaAdquisicion", PEntidad.FDtFechaAdquisicion));
            _comando.Parameters.Add(new SqlParameter("@FcProductoAdquirido", PEntidad.FcProductoAdquirido));
            _comando.Parameters.Add(new SqlParameter("@FiCantidad", PEntidad.FiCantidad));
            _comando.Parameters.Add(new SqlParameter("@FdTotalAPagar", PEntidad.FdTotalAPagar));
           
            //_comando.Parameters.Add(new SqlParameter("@PorcentajeGananciaCredito", PEntidad.FdLimiteCredito));

            int Resultado = _comando.ExecuteNonQuery();

            _Conexion.Close();
            return Resultado;
        }

        public List<EnCuentasPorPagar> MostrarEnCuentasPorPagar()
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Consultar_Cuentas_Por_Pagar", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _comando.ExecuteReader();
            List<EnCuentasPorPagar> Lista = new List<EnCuentasPorPagar>();
            while (_reader.Read())
            {
                EnCuentasPorPagar _EnCuentas = new EnCuentasPorPagar();
                _EnCuentas.FiIdProveedor = _reader.GetInt64(0);
                _EnCuentas.FcNombreProveedor = _reader.GetString(1);
                _EnCuentas.FiNoFactura = _reader.GetInt32(2);
                _EnCuentas.FDtFechaAdquisicion = _reader.GetString(3);
                _EnCuentas.FcProductoAdquirido = _reader.GetString(4);
                _EnCuentas.FiCantidad = _reader.GetInt32(5);
                _EnCuentas.FdTotalAPagar = _reader.GetDecimal(6);

                Lista.Add(_EnCuentas);
            }
            _Conexion.Close();
            return Lista;
        }

        public List<EnCuentasPorPagar> MostrarEnCuentaPorNombre(EnCuentasPorPagar PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Consultar_Cuentas_Por_Pagar_Por_Nombre", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@FcNombreProveedor", PEntidad.FcNombreProveedor));
            IDataReader _reader = _comando.ExecuteReader();
            List<EnCuentasPorPagar> Lista = new List<EnCuentasPorPagar>();
            while (_reader.Read())
            {
                EnCuentasPorPagar _EnCuentas = new EnCuentasPorPagar();

                _EnCuentas.FiIdProveedor = _reader.GetInt64(0);
                _EnCuentas.FcNombreProveedor = _reader.GetString(1);
                _EnCuentas.FiNoFactura = _reader.GetInt32(2);
                _EnCuentas.FDtFechaAdquisicion = _reader.GetString(3);
                _EnCuentas.FcProductoAdquirido = _reader.GetString(4);
                _EnCuentas.FiCantidad = _reader.GetInt32(5);
                _EnCuentas.FdTotalAPagar = _reader.GetDecimal(6);

                Lista.Add(_EnCuentas);

            }
            _Conexion.Close();

            return Lista;
        }

        public int ModificarCuenta(EnCuentasPorPagar PEntidad)
        {
            IDbConnection _conexion = DBConexion.Conexion();
            _conexion.Open();
            SqlCommand _comando = new SqlCommand("Modificar_Cuentas_Por_Pagar", _conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@FiIdProveedor", PEntidad.FiIdProveedor));
            _comando.Parameters.Add(new SqlParameter("@FcNombreProveedor", PEntidad.FcNombreProveedor));
            _comando.Parameters.Add(new SqlParameter("@FiNoFactura", PEntidad.FiNoFactura));
            _comando.Parameters.Add(new SqlParameter("@FdFechaAdquisicion", PEntidad.FDtFechaAdquisicion));
            _comando.Parameters.Add(new SqlParameter("@FcProductoAdquirido", PEntidad.FcProductoAdquirido));
            _comando.Parameters.Add(new SqlParameter("@FiCantidad", PEntidad.FiCantidad));
            _comando.Parameters.Add(new SqlParameter("@FdTotalAPagar", PEntidad.FdTotalAPagar));
            

            int Resultado = _comando.ExecuteNonQuery();
            _conexion.Close();
            return Resultado;

        }

        public int EliminarCuenta(EnCuentasPorPagar PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Eliminar_Cuentas_Por_Pagar", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@FiIdProveedor", PEntidad.FiIdProveedor));
            int Resultado = _comando.ExecuteNonQuery();
            _Conexion.Close();
            return Resultado;

        }
    }
}
