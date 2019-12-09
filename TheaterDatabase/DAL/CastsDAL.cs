using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheaterDatabase.Models;

namespace TheaterDatabase.DAL
{
    public class CastsDAL
    {

        private static Cast GetCastFromDR(NpgsqlDataReader dr)
        {
            int intCastID = Convert.ToInt32(dr["intCastID"]);
            string strVoicePart = dr["strVoicePart"].ToString();
            string strRole = dr["strRole"].ToString();

            Show show = ShowsDAL.GetShow(intShowID);
            Member member = MembersDAL.GetMember(intMemberID);

            Cast cast = Cast.Of(intCastID, strVoicePart, strRole);
            return member;
        }
        
        public static Cast GetCast(int intCastID)
        {
            Cast retval = null;

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT * FROM casts WHERE \"intCastID\" = " + intCastID;
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            // Read all rows and output the first column in each row
            while (dr.Read())
            {

                retval = GetCastFromDR(dr);
                //Console.Write("{0}\n", dr[0]);
            }

            conn.Close();

            return retval;
        }

        public static IEnumerable<Cast> GetAllCasts()
        {
            List<Cast> retval = new List<Cast>();

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT * FROM casts";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Show show = GetCastFromDR(dr);
                retval.Add(cast);
            }

            conn.Close();

            return retval;
        }
        
        public static bool InsertCast(Cast cast)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "INSERT INTO casts" +
                           " (\"strVoicePart\")" +
                           " (\"strRole\")" +
                           " VALUES" +
                           " (@strVoicePart, @strRole);";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("strVoicePart", show.StrVoicePart);
            cmd.Parameters.AddWithValue("strRole", show.StrRole);
            

            // Execute a query
            int result = cmd.ExecuteNonQuery();

            conn.Close();

            if (result == 1)
                return true;
            else
                return false;
        }

        public static bool UpdateCast(Cast cast)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "UPDATE casts " +
                           " SET \"strVoicePart\" = @strVoicePart" +
                           " SET \"strRole\" = @strRole" +
                           " WHERE \"intCastID\" = @intCastID;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("strVoicePart", show.StrVoicePart);
            cmd.Parameters.AddWithValue("strRole", show.StrRole);
            cmd.Parameters.AddWithValue("intCastID", show.IntCastID);
            
            // Execute a query
            int result = cmd.ExecuteNonQuery();

            conn.Close();

            if (result == 1)
                return true;
            else
                return false;

        }

        public static bool DeleteCast(Cast cast)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "DELETE FROM casts WHERE \"intCastID\" = @intCastID ";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("intCastID", show.intCastID);

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
