﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using EN;

namespace DAL
{
    class inventariosDal
    {
        public int AgregarProducto(Inventario PEntidad)
        {
            IDbConnection _Conexion = DBConexion.Conexion();
            _Conexion.Open();
            SqlCommand _comando = new SqlCommand("Agregar_Producto", _Conexion as SqlConnection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.Add(new SqlParameter("@NombreProducto", PEntidad.NombreProducto));
            _comando.Parameters.Add(new SqlParameter("@GrupoPerteneciente", PEntidad.GrupoPerteneciente));
            _comando.Parameters.Add(new SqlParameter("@Cantidad", PEntidad.Cantidad));
            _comando.Parameters.Add(new SqlParameter("@ConstoUnitario", PEntidad.CostoUnitario));
            _comando.Parameters.Add(new SqlParameter("@PorcentajeGananciaContado",PEntidad.PorcentajeGananciaContado));
            _comando.Parameters.Add(new SqlParameter("@PrecioContado",PEntidad.PrecioContado));
            _comando.Parameters.Add(new SqlParameter("@PorcentajeGanaciaCredito", PEntidad.PorcentajeGananciaCredito));
            _comando.Parameters.Add(new SqlParameter("@PrecioACredito", PEntidad.PrecioACredito));
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


            }
        }

    }
}
