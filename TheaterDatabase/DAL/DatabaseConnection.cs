using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterDatabase.DAL
{

    public class DatabaseConnection
    {
        public static readonly String SERVER = "127.0.0.1";
        public static readonly String USER = "postgres";
        public static readonly String DATABASE = "TheaterProductions";
        public static readonly String PASS = "123456";

        public static NpgsqlConnection getConnection()
        {
            // Specify connection options and open an connection
            NpgsqlConnection conn = new NpgsqlConnection("" +
                "Server=" + SERVER + ";" +
                "User Id=" + USER + ";" +
                "Password=" + PASS + ";" +
                "Database=" + DATABASE + ";");

            return conn;
        }

    }
}