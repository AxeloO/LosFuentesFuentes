﻿using System;
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

        //public static string CadenaDeConexion = @"Data Source=192.168.1.88;Initial Catalog=DBFuentes;User ID=Ventas;Password=12345;Context Connection=False";


       // public static string CadenaDeConexion = @"Data Source = 192.168.1.82;Initial Catalog=DBFuentes; Persist Security Info=True;User ID = ventas; Password=12345; Context Connection=False";
        //public static string CadenaDeConexion = @"Data Source=192.168.1.88;Initial Catalog=DBFuentes; UserId:Ventas; Password:12345";
<<<<<<< HEAD

        public static string CadenaDeConexion = @"Data Source=DESKTOP-QRLGBTN\SQLEXPRESS;Initial Catalog=DBFuentes;Integrated Security=True";

       // public static string CadenaDeConexion = @"Data Source=DESKTOP-QMNNJTQ\SQLEXPRESS;Initial Catalog=DBFuentes;Integrated Security=True";

=======
//<<<<<<< HEAD
        //public static string CadenaDeConexion = @"Data Source=DESKTOP-QRLGBTN\SQLEXPRESS;Initial Catalog=DBFuentes;Integrated Security=True";
//=======
       // public static string CadenaDeConexion = @"Data Source=DESKTOP-QMNNJTQ\SQLEXPRESS;Initial Catalog=DBFuentes;Integrated Security=True";
//>>>>>>> 401598836fe5632222278200ac256678bca1c7de
>>>>>>> 0eb25f00a9f8af7763dec5dc015f56b2fcea0242

        //public static string CadenaDeConexion = @"Data Source = 192.168.1.82;Initial Catalog=DBFuentes; Persist Security Info=True;User ID = ventas; Password=12345; Context Connection=False";
        //public static string CadenaDeConexion = @"Data Source=192.168.1.88;Initial Catalog=DBFuentes; UserId:Ventas; Password:12345";
     //  public static string CadenaDeConexion = @"Data Source=ZURYGAR\SQLEXPRESS;Initial Catalog=DBFuentes;Integrated Security=True";


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
