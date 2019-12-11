using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheaterDatabase.ViewModels.Analytics_VMs;

namespace TheaterDatabase.DAL
{
    public class AnalyticsDAL
    {


        public static IEnumerable<BudgetAverageVM> GetBudgetAverages()
        {
            List<BudgetAverageVM> retval = new List<BudgetAverageVM>();

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT cl.\"strClubName\", AVG(s.\"intBudget\") as intAvgBudget" +
                " FROM clubs cl, shows s" +
                " WHERE s.\"intClubID\" = cl.\"intClubID\"" +
                " GROUP BY cl.\"strClubName\"";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int intBudgetAverage = Convert.ToInt32(dr["intAvgBudget"]);
                string strClubName = dr["strClubName"].ToString();

                BudgetAverageVM tmpBudgetAvg = BudgetAverageVM.Of(intBudgetAverage, strClubName);

                retval.Add(tmpBudgetAvg);
            }

            conn.Close();

            return retval;
        }


        public static IEnumerable<MusicalsCountVM> GetMusicalCounts()
        {
            List<MusicalsCountVM> retval = new List<MusicalsCountVM>();

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT COUNT(s.*) FROM shows s WHERE s.\"ysnIsMusical\" = TRUE";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            int intMusicalCount;

            while (dr.Read())
            {
                intMusicalCount = Convert.ToInt32(dr["count"]);
                retval.Add(MusicalsCountVM.Of(intMusicalCount, "musicals"));
            }

            conn.Close();

            // create and open a connection
            NpgsqlConnection conn2 = DatabaseConnection.GetConnection();
            conn2.Open();

            // Define a query
            string query2 = "SELECT COUNT(s.*) FROM shows s WHERE s.\"ysnIsMusical\" = FALSE";
            NpgsqlCommand cmd2 = new NpgsqlCommand(query2, conn2);

            // Execute a query
            NpgsqlDataReader dr2 = cmd2.ExecuteReader();

            int intPlaysCount;

            while (dr2.Read())
            {
                intPlaysCount = Convert.ToInt32(dr2["count"]);
                retval.Add(MusicalsCountVM.Of(intPlaysCount, "plays"));
            }

            conn2.Close();

            return retval;
        }

        public static IEnumerable<string> GetPossiblePositions()
        {

            List<string> retval = new List<string>();

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT DISTINCT \"strPosition\" FROM staff";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            string tmpPosition;

            while (dr.Read())
            {
                tmpPosition = dr["strPosition"].ToString();
                retval.Add(tmpPosition);
            }

            conn.Close();

            return retval;

        }

        public static IEnumerable<RepeatStaffPositionsVM> GetRepeatStaffPositions(string strPositionName)
        {
            List<RepeatStaffPositionsVM> retval = new List<RepeatStaffPositionsVM>();

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT m.\"strName\", count(m.*)" +
                " FROM members m, staff s" +
                " WHERE s.\"strPosition\" = '" + strPositionName + "'" +
                " AND s.\"intMemberID\" = m.\"intMemberID\"" +
                " GROUP BY m.\"strName\"" +
                " HAVING count(m.*) >= 2";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                RepeatStaffPositionsVM tmpRepeatStaff = new RepeatStaffPositionsVM
                {
                    StrName = dr["strName"].ToString(),
                    IntCount = Convert.ToInt32(dr["count"])
                };
                retval.Add(tmpRepeatStaff);
            }

            conn.Close();

            return retval;
        }
    }
}