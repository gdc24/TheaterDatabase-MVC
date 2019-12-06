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


    }
}