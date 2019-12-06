using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheaterDatabase.Models;

namespace TheaterDatabase.DAL
{
    public class ClubsDAL
    {


        private static Club GetClubFromDR(NpgsqlDataReader dr)
        {
            int id = Convert.ToInt32(dr["intClubID"]);
            String strClubName = dr["strClubName"].ToString();
            String strAdvisor = dr["strAdvisor"].ToString();
            UmbrellaOrg strUmbrellaOrg = (UmbrellaOrg)Enum.Parse(typeof(UmbrellaOrg), dr["strUmbrellaOrg"].ToString());
            Club club = Club.of(id, strClubName, strAdvisor, strUmbrellaOrg);
            return club;
        }

        public static Club GetClub(int intClubID)
        {
            Club retval = null;

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.getConnection();
            conn.Open();

            // Define a query
            String query = "SELECT * FROM clubs WHERE intClubID = " + intClubID;
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            // Read all rows and output the first column in each row
            while (dr.Read())
            {

                retval = GetClubFromDR(dr);
                //Console.Write("{0}\n", dr[0]);
            }

            conn.Close();

            return retval;
        }

        public static IEnumerable<Club> GetAllClubs()
        {
            IEnumerable<Club> retval = null;

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.getConnection();
            conn.Open();

            // Define a query
            String query = "SELECT intClubID, strClubName, strAdvisor, strUmbrellaOrg FROM clubs";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Club club = GetClubFromDR(dr);
                retval.Append(club);
            }

            conn.Close();

            return retval;
        }

        public static bool InsertClub(Club club)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.getConnection();
            conn.Open();

            // Define a query
            String query = "INSERT INTO clubs" +
                           " (\"strClubName\", \"strAdvisor\", \"strUmbrellaOrg\")" +
                           " VALUES" +
                           " (@strClubName, @strAdvisor, @strUmbrellaOrg);";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("strClubName", club.StrClubName);
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

        public static bool UpdateClub(Club club)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.getConnection();
            conn.Open();

            // Define a query
            String query = "UPDATE clubs " +
                           " SET \"strClubName\" = @strClubName" +
                           " \"strAdvisor\" = @strAdvisor" +
                           " \"strUmbrellaOrg\" = @strUmbrellaOrg" +
                           " WHERE \"intClubID\" = @intClubID;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("strClubName", club.StrClubName);
            cmd.Parameters.AddWithValue("strAdvisor", club.StrAdvisor);
            cmd.Parameters.AddWithValue("strUmbrellaOrg", club.UmbrellaOrg);
            cmd.Parameters.AddWithValue("intClubID", club.IntClubID);

            // Execute a query
            int result = cmd.ExecuteNonQuery();

            conn.Close();

            if (result == 1)
                return true;
            else
                return false;

        }

        public static bool DeleteClub(Club club)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.getConnection();
            conn.Open();

            // Define a query
            String query = "DELETE FROM clubs WHERE \"intClubID\" = @intClubID ";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("intClubID", club.IntClubID);

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