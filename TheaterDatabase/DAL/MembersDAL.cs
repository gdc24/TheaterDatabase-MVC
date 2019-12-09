using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheaterDatabase.Models;

namespace TheaterDatabase.DAL
{
    public class MembersDAL
    {

        private static Member GetMemberFromDR(NpgsqlDataReader dr)
        {
            int intMemberID = Convert.ToInt32(dr["intMemberID"]);
            string strMemberName = dr["strMemberName"].ToString();

            Club club = ClubsDAL.GetClub(intClubID);
            Date date = DatesDAL.GetDate(intDateID);

            Member member = Member.Of(intMemberID, strMemberName);
            return member;
        }
        
        public static Member GetMember(int intMemberID)
        {
            Member retval = null;

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT * FROM members WHERE \"intMemberID\" = " + intMemberID;
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            // Read all rows and output the first column in each row
            while (dr.Read())
            {

                retval = GetMemberFromDR(dr);
                //Console.Write("{0}\n", dr[0]);
            }

            conn.Close();

            return retval;
        }

        public static IEnumerable<Member> GetAllMembers()
        {
            List<Member> retval = new List<Member>();

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT * FROM members";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Show show = GetMemberFromDR(dr);
                retval.Add(member);
            }

            conn.Close();

            return retval;
        }
        
        public static bool InsertMember(Member member)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "INSERT INTO members" +
                           " (\"strMemberName\")" +
                           " VALUES" +
                           " (@strMemberName);";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("strMemberName", show.StrMemberName);
            

            // Execute a query
            int result = cmd.ExecuteNonQuery();

            conn.Close();

            if (result == 1)
                return true;
            else
                return false;
        }

        public static bool UpdateMember(Member member)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "UPDATE members " +
                           " SET \"strMemberName\" = @strMemberName" +
                           " WHERE \"intMemberID\" = @intMemberID;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("strMemberName", show.StrMemberName);
            cmd.Parameters.AddWithValue("intMemberID", show.IntMemberID);
            
            // Execute a query
            int result = cmd.ExecuteNonQuery();

            conn.Close();

            if (result == 1)
                return true;
            else
                return false;

        }

        public static bool DeleteMember(Member member)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "DELETE FROM members WHERE \"intMemberID\" = @intMemberID ";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("intMemberID", show.intMemberID);

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
