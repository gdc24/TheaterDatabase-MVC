using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheaterDatabase.Models;

namespace TheaterDatabase.DAL
{
    public class PitsDAL
    {

        private static Pit GetPitFromDR(NpgsqlDataReader dr)
        {
            int intPitID = Convert.ToInt32(dr["intPitID"]);
            string strInstrument = dr["strInstrument"].ToString();
            int intSeat = Convert.ToInt32(dr["intSeat"]);
            int intMemberID = Convert.ToInt32(dr["intMemberID"]);
            int intShowID = Convert.ToInt32(dr["intShowID"]);


            Show show = ShowsDAL.GetShow(intShowID);
            Member member = MembersDAL.GetMember(intMemberID);

            Pit pit = Pit.Of(intPitID, strInstrument, intSeat, intMemberID, member, intShowID, show);
            return member;
        }
        
        public static Pit GetPit(int intPitID)
        {
            Pit retval = null;

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT * FROM pits WHERE \"intPitID\" = " + intPitID;
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            // Read all rows and output the first column in each row
            while (dr.Read())
            {

                retval = GetPitFromDR(dr);
                //Console.Write("{0}\n", dr[0]);
            }

            conn.Close();

            return retval;
        }

        public static IEnumerable<Pit> GetAllPits()
        {
            List<Pit> retval = new List<Pit>();

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT * FROM pits";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Pit pit = GetPitFromDR(dr);
                retval.Add(pit);
            }

            conn.Close();

            return retval;
        }
        
        public static bool InsertPit(Pit pit)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "INSERT INTO pits" +
                           " (\"strInstrument\")" +
                           " (\"intSeat\")" + " (\"intMemebrID\")" +
                           " (\"intShowID\")" + 
                           " VALUES" +
                           " (@strInstrument, @intSeat, @intMemberID, @intShowID);";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("strInstrument", pit.StrInstrument);
            cmd.Parameters.AddWithValue("intSeat", pit.IntSeat);
            cmd.Parameters.AddWithValue("intMemberID", pit.IntMemberID);
            cmd.Parameters.AddWithValue("intShowID", pit.IntShowID);
            

            // Execute a query
            int result = cmd.ExecuteNonQuery();

            conn.Close();

            if (result == 1)
                return true;
            else
                return false;
        }

        public static bool UpdatePit(Pit pit)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "UPDATE pits " +
                           " SET \"strInstrument\" = @strInstrument" +
                           " SET \"intSeat\" = @intSeat" + " \"intMemberID\" = @intMemberID" +
                           " \"intShowID\" = @intShowID" +
                           " WHERE \"intPitID\" = @intPitID;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("strInstrument", pit.StrInstrument);
            cmd.Parameters.AddWithValue("intSeat", pit.IntSeat);
            cmd.Parameters.AddWithValue("intPitID", pit.IntPitID);
            cmd.Parameters.AddWithValue("intMemberID", pit.IntMemberID);
            cmd.Parameters.AddWithValue("intShowID", pit.IntShowID);
            
            // Execute a query
            int result = cmd.ExecuteNonQuery();

            conn.Close();

            if (result == 1)
                return true;
            else
                return false;

        }

        public static bool DeletePit(Pit pit)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "DELETE FROM pits WHERE \"intPitID\" = @intPitID ";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("intPitID", pit.intPitID);

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
