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
            _comando.Parameters.Add(new SqlParameter("@fiFolioVenta", PEntidad.fiFolioVenta));
            _comando.Parameters.Add(new SqlParameter("@fiIdDevolucion", PEntidad.fiIdDevolucion));
            _comando.Parameters.Add(new SqlParameter("@fcNombreProductoDevolucion", PEntidad.fcNombreProductoDevolucion));
            _comando.Parameters.Add(new SqlParameter("@fiCantidadDevolucion", PEntidad.fiCantidadDevolucion));
            _comando.Parameters.Add(new SqlParameter("@fcCausaDevolucion", PEntidad.fcCausaDevolucion));


            int Resultado = _comando.ExecuteNonQuery();

            _Conexion.Close();
            return Resultado;
        }

        public List<EnDevolucion> MostrarEnDevolucion()
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Consultar_Devoluciones_Por_fiIDevolucion", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _comando.ExecuteReader();
            List<EnDevolucion> Lista = new List<EnDevolucion>();
            while (_reader.Read())
            {
                EnDevolucion _EnDevolucion = new EnDevolucion();
                _EnDevolucion.fiFolioVenta = _reader.GetInt32(0);
                _EnDevolucion.fiIdDevolucion = _reader.GetInt32(1);
                _EnDevolucion.fcNombreProductoDevolucion = _reader.GetString(2);
                _EnDevolucion.fiCantidadDevolucion = _reader.GetInt32(3);
                _EnDevolucion.fcCausaDevolucion = _reader.GetString(4);
                
                Lista.Add(_EnDevolucion);
            }
            _Conexion.Close();
            return Lista;
        }
    }
}
