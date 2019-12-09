using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheaterDatabase.Models;

namespace TheaterDatabase.DAL
{
    public class DatesDAL
    {
        private static Date GetDateFromDR(NpgsqlDataReader dr)
        {
            int id = Convert.ToInt32(dr["intDateID"]);
            string strSemester = dr["strSemester"].ToString();
            Semester semester = (Semester)Enum.Parse(typeof(Semester), strSemester, true);
            int intYear = Convert.ToInt32(dr["intYear"]);
            Date date = Date.Of(id, strSemester, semester, intYear);
            return date;
        }

        public static Date GetDate(int intDateID)
        {
            Date retval = null;

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT * FROM dates WHERE \"intDateID\" = " + intDateID;
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            // Read all rows and output the first column in each row
            while (dr.Read())
            {

                retval = GetDateFromDR(dr);
                //Console.Write("{0}\n", dr[0]);
            }

            conn.Close();

            return retval;
        }

        public static IEnumerable<Date> GetAllDates()
        {
            List<Date> retval = new List<Date>();

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT intDateID, strDateName, strAdvisor, strUmbrellaOrg FROM dates";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Date date = GetDateFromDR(dr);
                retval.Add(date);
            }

            conn.Close();

            return retval;
        }
        
        public static bool InsertDate(Date date)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "INSERT INTO dates" +
                           " (\"strDateName\", \"strAdvisor\", \"strUmbrellaOrg\")" +
                           " VALUES" +
                           " (@strDateName, @strAdvisor, @strUmbrellaOrg);";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("strDateName", club.StrDateName);
            cmd.Parameters.AddWithValue("strAdvisor", club.StrAdvisor);
            cmd.Parameters.AddWithValue("strUmbrellaOrg", club.UmbrellaOrg);

            // Execute a query
            int result = cmd.ExecuteNonQuery();

            conn.Close();

            if (result == 1)
                return true;
            else
                return false;
        }

        public static bool UpdateDate(Date date)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "UPDATE dates " +
                           " SET \"strDateName\" = @strDateName" +
                           " \"strAdvisor\" = @strAdvisor" +
                           " \"strUmbrellaOrg\" = @strUmbrellaOrg" +
                           " WHERE \"intDateID\" = @intDateID;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("strDateName", club.StrDateName);
            cmd.Parameters.AddWithValue("strAdvisor", club.StrAdvisor);
            cmd.Parameters.AddWithValue("strUmbrellaOrg", club.UmbrellaOrg);
            cmd.Parameters.AddWithValue("intDateID", club.IntDateID);

            // Execute a query
            int result = cmd.ExecuteNonQuery();

            conn.Close();

            if (result == 1)
                return true;
            else
                return false;

        }

        public static bool DeleteDate(Date date)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "DELETE FROM dates WHERE \"intDateID\" = @intDateID ";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("intDateID", club.IntDateID);

            // Execute a query
            int result = cmd.ExecuteNonQuery();

            conn.Close();

            if (result == 1)
                return true;
            else
                return false;
        }



    }
}
