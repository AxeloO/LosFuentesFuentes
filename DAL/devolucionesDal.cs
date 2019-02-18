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
    public class devolucionesDal
    {
        public int AgregarDevolucion(EnDevolucion PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();

            SqlCommand _comando = new SqlCommand("Agregar_Devoluciones", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@FiFolioVenta", PEntidad.fiFolioVenta));
            //_comando.Parameters.Add(new SqlParameter("@FiIdDevolucion", PEntidad.fiIdDevolucion));
            _comando.Parameters.Add(new SqlParameter("@FcFechaDevolucion", PEntidad.fcFechaDevolucion));
            _comando.Parameters.Add(new SqlParameter("@FcNombreDelCliente", PEntidad.fcNombreDelCliente));
            _comando.Parameters.Add(new SqlParameter("@FcNombreProductoDevolucion", PEntidad.fcNombreProductoDevolucion));
            _comando.Parameters.Add(new SqlParameter("@FiCantidadDevolucion", PEntidad.fiCantidadDevolucion));
            _comando.Parameters.Add(new SqlParameter("@FcCausaDevolucion", PEntidad.fcCausaDevolucion));
            
            


            int Resultado = _comando.ExecuteNonQuery();

            _Conexion.Close();
            return Resultado;
        }

        public List<EnDevolucion> MostrarEnDevolucion()
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Consulta_Devoluciones", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _comando.ExecuteReader();
            List<EnDevolucion> Lista = new List<EnDevolucion>();
            while (_reader.Read())
            {
                EnDevolucion _EnDevolucion = new EnDevolucion();
                _EnDevolucion.fiFolioVenta = _reader.GetInt32(0);
                _EnDevolucion.fiIdDevolucion = _reader.GetInt64(1);
                _EnDevolucion.fcFechaDevolucion = _reader.GetString(2);
                _EnDevolucion.fcNombreDelCliente = _reader.GetString(3);
                _EnDevolucion.fcNombreProductoDevolucion = _reader.GetString(4);
                _EnDevolucion.fiCantidadDevolucion = _reader.GetInt32(5);//Al momento de pedir que me muestre la lista me manda este error "System.InvalidCastException: 'La conversión especificada no es válida."
                _EnDevolucion.fcCausaDevolucion = _reader.GetString(6);
                
                
                Lista.Add(_EnDevolucion);
            }
            _Conexion.Close();
            return Lista;
        }
    }
}
