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
    public class VentasDal
    {
        public int AgregarVenta(EnVentas PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();

            SqlCommand _comando = new SqlCommand("Agregar_Ventas", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
           // _comando.Parameters.Add(new SqlParameter("@fiIdVenta", PEntidad.fiIdVenta));
            _comando.Parameters.Add(new SqlParameter("@fDtFechaSalida", PEntidad.fDtFechaSalida));
            _comando.Parameters.Add(new SqlParameter("@fcNombreCliente", PEntidad.fcNombreCliente));
            _comando.Parameters.Add(new SqlParameter("@fcDomicilio", PEntidad.fcDomicilio));
            _comando.Parameters.Add(new SqlParameter("@fcCiudad", PEntidad.fcCiudad));
            _comando.Parameters.Add(new SqlParameter("@fcTelefono", PEntidad.fcTelefono));
            _comando.Parameters.Add(new SqlParameter("@fcFechaPago", PEntidad.fcFechaPago));
            _comando.Parameters.Add(new SqlParameter("@fiCantidad", PEntidad.fiCantidad));
            _comando.Parameters.Add(new SqlParameter("@fcConcepto", PEntidad.fcConcepto));
            _comando.Parameters.Add(new SqlParameter("@fdPrecioUnitario", PEntidad.fdPrecioUnitario));
            _comando.Parameters.Add(new SqlParameter("@fdImporte", PEntidad.fdImporte));
            _comando.Parameters.Add(new SqlParameter("@fdTotal", PEntidad.fdTotal));
            int Resultado = _comando.ExecuteNonQuery();

            _Conexion.Close();
            return Resultado;
        }

        public List<EnVentas> MostrarEnVentas()
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Consultar_Ventas", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _comando.ExecuteReader();
            List<EnVentas> Lista = new List<EnVentas>();
            while (_reader.Read())
            {
                EnVentas _EnVentas = new EnVentas();
                _EnVentas.fiIdVenta = _reader.GetInt64(0);
                _EnVentas.fDtFechaSalida = _reader.GetString(1);
                _EnVentas.fcNombreCliente = _reader.GetString(2);
                _EnVentas.fcDomicilio = _reader.GetString(3);
                _EnVentas.fcCiudad = _reader.GetString(4);
                _EnVentas.fcTelefono = _reader.GetString(5);
                _EnVentas.fcFechaPago = _reader.GetString(6);
                _EnVentas.fiCantidad = _reader.GetInt32(7);
                _EnVentas.fcConcepto = _reader.GetString(8);
                _EnVentas.fdPrecioUnitario = _reader.GetDecimal(9);
                _EnVentas.fdImporte = _reader.GetInt32(10);
                _EnVentas.fdTotal = _reader.GetDecimal(11);
                Lista.Add(_EnVentas);
            }
            _Conexion.Close();
            return Lista;
        }

        public List<EnVentas> MostrarEnVentasPorDia(EnVentas PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Consultar_Venta_Por_Dia", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@FDtFechaSalida", PEntidad.fDtFechaSalida));
            IDataReader _reader = _comando.ExecuteReader();
            List<EnVentas> Lista = new List<EnVentas>();
            while (_reader.Read())
            {
                EnVentas _EnVentas = new EnVentas();

                _EnVentas.fiIdVenta = _reader.GetInt64(0);
                _EnVentas.fDtFechaSalida = _reader.GetString(1);
                _EnVentas.fcNombreCliente = _reader.GetString(2);
                _EnVentas.fcDomicilio = _reader.GetString(3);
                _EnVentas.fcCiudad = _reader.GetString(4);
                _EnVentas.fcTelefono = _reader.GetString(5);
                _EnVentas.fcFechaPago = _reader.GetString(6);
                _EnVentas.fiCantidad = _reader.GetInt32(7);
                _EnVentas.fcConcepto = _reader.GetString(8);
                _EnVentas.fdPrecioUnitario = _reader.GetDecimal(9);
                _EnVentas.fdImporte = _reader.GetInt32(10);
                _EnVentas.fdTotal = _reader.GetDecimal(11);

                Lista.Add(_EnVentas);

            }
            _Conexion.Close();

            return Lista;
        }
                
    }

}
