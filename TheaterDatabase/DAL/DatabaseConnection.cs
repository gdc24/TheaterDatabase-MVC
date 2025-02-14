﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterDatabase.DAL
{

    public class DatabaseConnection
    {
        public static readonly string SERVER = "127.0.0.1";
        public static readonly string USER = "postgres";
        public static readonly string DATABASE = "TheatreProductions";
        public static readonly string PASS = "123456";

        public static NpgsqlConnection GetConnection()
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