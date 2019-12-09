using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheaterDatabase.Models;

namespace TheaterDatabase.DAL
{
    public class ExecDAL
    {

        private static Exec GetExecFromDR(NpgsqlDataReader dr)
        {
            int intExecID = Convert.ToInt32(dr["intExecID"]);
            string strPosition = dr["strPosition"].ToString();

            Club club = ClubsDAL.GetClub(intClubID);
            Date date = DatesDAL.GetDate(intDateID);

            Exec exec = Exec.Of(intExecID, strPosition);
            return exec;
        }
        
        public static Exec GetExec(int intExecID)
        {
            Exec retval = null;

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT * FROM exec WHERE \"intExecID\" = " + intExecID;
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            // Read all rows and output the first column in each row
            while (dr.Read())
            {

                retval = GetExecFromDR(dr);
                //Console.Write("{0}\n", dr[0]);
            }

            conn.Close();

            return retval;
        }

        public static IEnumerable<Exec> GetAllExec()
        {
            List<Member> retval = new List<Member>();

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT * FROM exec";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Exec exec = GetExecFromDR(dr);
                retval.Add(exec);
            }

            conn.Close();

            return retval;
        }
        
        public static bool InsertExec(Exec exec)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "INSERT INTO exec" +
                           " (\"strPosition\")" +
                           " VALUES" +
                           " (@strMemberName);";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("strExecName", show.StrExecName);
            

            // Execute a query
            int result = cmd.ExecuteNonQuery();

            conn.Close();

            if (result == 1)
                return true;
            else
                return false;
        }

        public static bool UpdateExec(Exec exec)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "UPDATE exec " +
                           " SET \"strPosition\" = @strPosition" +
                           " WHERE \"intExecID\" = @intExecID;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("strPosition", show.StrPosition);
            cmd.Parameters.AddWithValue("intExecID", show.IntExecID);
            
            // Execute a query
            int result = cmd.ExecuteNonQuery();

            conn.Close();

            if (result == 1)
                return true;
            else
                return false;

        }

        public static bool DeleteExec(Exec exec)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "DELETE FROM exec WHERE \"intExecID\" = @intExecID ";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("intExecID", show.intExecID);

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
