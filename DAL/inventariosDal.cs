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
    public class inventariosDal
    {
        public int AgregarProducto(Inventario PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
          
            SqlCommand _comando = new SqlCommand("Agregar_Producto", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@NombreProducto", PEntidad.NombreProducto));
            _comando.Parameters.Add(new SqlParameter("@GrupoPertenenciente", PEntidad.GrupoPerteneciente));
            _comando.Parameters.Add(new SqlParameter("@Catidad", PEntidad.Cantidad));
            _comando.Parameters.Add(new SqlParameter("@CostoUnitario", PEntidad.CostoUnitario));
            _comando.Parameters.Add(new SqlParameter("@PorcentajeGananciaContado",PEntidad.PorcentajeGananciaContado));
            _comando.Parameters.Add(new SqlParameter("@PrecioContado",PEntidad.PrecioContado));
            _comando.Parameters.Add(new SqlParameter("@PorcentajeGananciaCredito", PEntidad.PorcentajeGananciaCredito));
            _comando.Parameters.Add(new SqlParameter("@PrecioACredito", PEntidad.PrecioACredito));
            _comando.Parameters.Add(new SqlParameter("@Presentacion", PEntidad.Presentacion));           
                   
            int Resultado = _comando.ExecuteNonQuery();

            _Conexion.Close();
            return Resultado;
        }

        public List<Inventario> MostrarInventario()
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Consultar_Productos", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _comando.ExecuteReader();
            List<Inventario> Lista = new List<Inventario>();
            while (_reader.Read())
            {
                Inventario _inventario = new Inventario();
                _inventario.IdProducto = _reader.GetInt32(0);
                _inventario.NombreProducto = _reader.GetString(1);
                _inventario.GrupoPerteneciente = _reader.GetString(2);
                _inventario.Cantidad = _reader.GetInt32(3);
                _inventario.Presentacion = _reader.GetString(4);
                _inventario.CostoUnitario = _reader.GetDecimal(5);
                _inventario.PorcentajeGananciaContado = _reader.GetDecimal(6);
                _inventario.PrecioContado = _reader.GetDecimal(7);
                _inventario.PorcentajeGananciaCredito = _reader.GetDecimal(8);
                _inventario.PrecioACredito = _reader.GetDecimal(9);
                Lista.Add(_inventario);
            }
            _Conexion.Close();
            return Lista;
        }

        public List<Inventario> MostrarInventarioPorNombre(Inventario PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Consultar_Productos_Por_Nombre", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@NombreProducto", PEntidad.NombreProducto));
            IDataReader _reader = _comando.ExecuteReader();
            List<Inventario> Lista = new List<Inventario>();
            while (_reader.Read())
            {
                Inventario _inventario = new Inventario();
                _inventario.IdProducto = _reader.GetInt64(0);
                _inventario.NombreProducto = _reader.GetString(1);
                _inventario.GrupoPerteneciente = _reader.GetString(2);
                _inventario.Cantidad = _reader.GetInt32(3);
                _inventario.Presentacion = _reader.GetString(4);
                _inventario.CostoUnitario = _reader.GetDecimal(5);
                _inventario.PorcentajeGananciaContado = _reader.GetDecimal(6);
                _inventario.PrecioContado = _reader.GetDecimal(7);
                _inventario.PorcentajeGananciaCredito = _reader.GetDecimal(8);
                _inventario.PrecioACredito = _reader.GetDecimal(9);

                Lista.Add(_inventario);
                                
            }            
            _Conexion.Close();
            
            return Lista;
        }
        
        public int ModificarProducto(Inventario PEntidad)
        {
            IDbConnection _conexion = DBConexion.Conexion();
            _conexion.Open();
            SqlCommand _comando = new SqlCommand("Modificar_Producto", _conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@IdProducto", PEntidad.IdProducto));
            _comando.Parameters.Add(new SqlParameter("@NombreProducto", PEntidad.NombreProducto));
            _comando.Parameters.Add(new SqlParameter("@GrupoPerteneciente", PEntidad.GrupoPerteneciente));
            _comando.Parameters.Add(new SqlParameter("@Cantidad", PEntidad.Cantidad));
            _comando.Parameters.Add(new SqlParameter("@ConstoUnitario", PEntidad.CostoUnitario));
            _comando.Parameters.Add(new SqlParameter("@PorcentajeGananciaContado", PEntidad.PorcentajeGananciaContado));
            _comando.Parameters.Add(new SqlParameter("@PrecioContado", PEntidad.PrecioContado));
            _comando.Parameters.Add(new SqlParameter("@PorcentajeGanaciaCredito", PEntidad.PorcentajeGananciaCredito));
            _comando.Parameters.Add(new SqlParameter("@PrecioACredito", PEntidad.PrecioACredito));
            int Resultado = _comando.ExecuteNonQuery();
            _conexion.Close();
            return Resultado;

        }

        public int EliminarProducto(Inventario PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Eliminar_Producto", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@IdProducto", PEntidad.IdProducto));
            int Resultado = _comando.ExecuteNonQuery();
            _Conexion.Close();
            return Resultado;
      
        }

    }
}
