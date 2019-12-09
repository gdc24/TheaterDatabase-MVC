using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheaterDatabase.Models;

namespace TheaterDatabase.DAL
{
    public class StaffDAL
    {

        private static Staff GetStaffFromDR(NpgsqlDataReader dr)
        {
            int intStaffID = Convert.ToInt32(dr["intStaffID"]);
            string strPosition = dr["strPosition"].ToString();
            int intMemberID = Convert.ToInt32(dr["intMemberID"]);
            int intShowID = Convert.ToInt32(dr["intShowID"]);

            Show show = ShowsDAL.GetShow(intShowID);
            Member member = MembersDAL.GetMember(intMemberID);

            Staff staff = Staff.Of(intStaffID, strPosition, intMemberID, member, intShowID, show);
            return staff;
        }
        
        public static Staff GetStaff(int intStaffID)
        {
            Staff retval = null;

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT * FROM staff WHERE \"intStaffID\" = " + intStaffID;
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            // Read all rows and output the first column in each row
            while (dr.Read())
            {

                retval = GetStaffFromDR(dr);
                //Console.Write("{0}\n", dr[0]);
            }

            conn.Close();

            return retval;
        }

        public static IEnumerable<Staff> GetAllStaff()
        {
            List<Staff> retval = new List<Staff>();

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT * FROM staff";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Staff staff = GetStaffFromDR(dr);
                retval.Add(staff);
            }

            conn.Close();

            return retval;
        }
        
        public static bool InsertStaff(Staff staff)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "INSERT INTO staff" +
                           " (\"strPosition\")" + " (\"intMemebrID\")" +
                           " (\"intShowID\")" + 
                           " VALUES" +
                           " (@strPosition);";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("strPosition", staff.StrPosition);
            cmd.Parameters.AddWithValue("intMemberID", staff.IntMemberID);
            cmd.Parameters.AddWithValue("intShowID", staff.IntShowID);
            

            // Execute a query
            int result = cmd.ExecuteNonQuery();

            conn.Close();

            if (result == 1)
                return true;
            else
                return false;
        }

        public static bool UpdateStaff(Staff staff)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "UPDATE staff " +
                           " SET \"strPosition\" = @strPosition" + " \"intMemberID\" = @intMemberID" +
                           " \"intShowID\" = @intShowID" +
                           " WHERE \"intStaffID\" = @intStaffID;";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("strPosition", staff.StrPosition);
            cmd.Parameters.AddWithValue("intStaffID", staff.IntStaffID);
            cmd.Parameters.AddWithValue("intMemberID", staff.IntMemberID);
            cmd.Parameters.AddWithValue("intShowID", staff.IntShowID);
            
            
            // Execute a query
            int result = cmd.ExecuteNonQuery();

            conn.Close();

            if (result == 1)
                return true;
            else
                return false;

        }

        public static bool DeleteStaff(Staff staff)
        {

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "DELETE FROM staff WHERE \"intStaffID\" = @intStaffID ";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("intStaffID", staff.IntStaffID);

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
