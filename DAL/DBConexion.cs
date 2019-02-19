using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace DAL
{
   public static class DBConexion
    {

      // public static string CadenaDeConexion = @"Data Source = 192.168.1.82;Initial Catalog=DBFuentes; Persist Security Info=True;User ID = ventas; Password=123456; Context Connection=False";

        public static string CadenaDeConexion = @"Data Source=DESKTOP-QRLGBTN\SQLEXPRESS;Initial Catalog=DBFuentes;Integrated Security=True";

        public static IDbConnection Conexion()
        {
            return new SqlConnection(CadenaDeConexion);
        }

        public static IDbCommand obtenerComando(string pComando, IDbConnection pConexion)
        {
            return new SqlCommand(pComando, pConexion as SqlConnection);
        }
    }
}
