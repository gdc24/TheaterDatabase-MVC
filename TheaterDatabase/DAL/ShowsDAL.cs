using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheaterDatabase.Models;

namespace TheaterDatabase.DAL
{
    public class ShowsDAL
    {

        private static Show GetShowFromDR(NpgsqlDataReader dr)
        {
            int id = Convert.ToInt32(dr["intShowID"]);
            string strName = dr["strName"].ToString();
            string strAuthor = dr["strAuthor"].ToString();
            int intBudget = Convert.ToInt32(dr["intBudget"]);
            bool ysnIsMusical = Convert.ToBoolean(dr["ysnIsMusical"]);
            int intClubID = Convert.ToInt32(dr["intClubID"]);
            int intDateID = Convert.ToInt32(dr["intDateID"]);

            Club club = ClubsDAL.GetClub(intClubID);
            Date date = DatesDAL.GetDate(intDateID);

            Show show = Show.Of(id, strName, strAuthor, intBudget, ysnIsMusical, intClubID, club, intDateID, date);
            return show;
        }

        public static IEnumerable<Show> GetAllShows()
        {
            List<Show> retval = new List<Show>();

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT * FROM shows";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Show show = GetShowFromDR(dr);
                retval.Add(show);
            }

            conn.Close();

            return retval;
        }
        
        public static bool InsertShow(Show show)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "INSERT INTO shows" +
                           " (\"strName\", \"strAuthor\", \"intBudget\", \"ysnIsMusical\", \"intClubID\", \"intDateID\")" +
                           " VALUES" +
                           " (@strName, @strAuthor, @intBudget, @ysnIsMusical, @intClubID, @intDateID);";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("strName", show.StrName);
            cmd.Parameters.AddWithValue("strAuthor", show.StrAuthor);
            cmd.Parameters.AddWithValue("intBudget", show.IntBudget);
            cmd.Parameters.AddWithValue("ysnIsMusical", show.YsnIsMusical);
            cmd.Parameters.AddWithValue("intClubID", show.IntClubID);
            cmd.Parameters.AddWithValue("intDateID", show.IntDateID);

            // Execute a query
            int result = cmd.ExecuteNonQuery();

            conn.Close();

            if (result == 1)
                return true;
            else
                return false;
        }

        public static bool UpdateShow(Show show)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "UPDATE shows " +
                           " SET \"strName\" = @strName" +
                           " \"strAuthor\" = @strAuthor" +
                           " \"intBudget\" = @intBudget" +
                           " \"ysnIsMusical\" = @ysnIsMusical" +
                           " \"intClubID\" = @intClubID" +
                           " \"intDateID\" = @intDateID" +
                           " WHERE \"id\" = @id;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("strName", show.StrName);
            cmd.Parameters.AddWithValue("strAuthor", show.StrAuthor);
            cmd.Parameters.AddWithValue("intBudget", show.IntBudget);
            cmd.Parameters.AddWithValue("ysnIsMusical", show.YsnIsMusical);
            cmd.Parameters.AddWithValue("intClubID", show.IntClubID);
            cmd.Parameters.AddWithValue("intDateID", show.IntDateID);
            cmd.Parameters.AddWithValue("id", show.Id);
            
            // Execute a query
            int result = cmd.ExecuteNonQuery();

            conn.Close();

            if (result == 1)
                return true;
            else
                return false;

        }

        public static bool DeleteShow(Show show)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "DELETE FROM shows WHERE \"id\" = @id ";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id", show.id);

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
