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

    }
}