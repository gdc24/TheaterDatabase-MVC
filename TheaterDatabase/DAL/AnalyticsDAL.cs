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

        public static IEnumerable<string> GetPossibleVoiceParts()
        {

            List<string> retval = new List<string>();

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT DISTINCT \"strVoicePart\" FROM casts";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            string tmpVoicePart;

            while (dr.Read())
            {
                tmpVoicePart = dr["strVoicePart"].ToString();
                retval.Add(tmpVoicePart);
            }

            conn.Close();

            return retval;

        }

        public static IEnumerable<MembersByVoicePartVM> GetMembersByVoicePart(string strVoicePart)
        {
            List<MembersByVoicePartVM> retval = new List<MembersByVoicePartVM>();

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "Select m.\"strName\", COUNT(m.\"strName\")" +
                " FROM members m, casts c" +
                " WHERE m.\"intMemberID\" = c.\"intMemberID\"" +
                " AND c.\"strVoicePart\" = '" + strVoicePart + "'" +
                " GROUP BY m.\"strName\"";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                MembersByVoicePartVM tmpMemberByVoicePart = new MembersByVoicePartVM
                {
                    StrName = dr["strName"].ToString(),
                    IntCount = Convert.ToInt32(dr["count"])
                };
                retval.Add(tmpMemberByVoicePart);
            }

            conn.Close();

            return retval;
        }
        
        public static IEnumerable<ShowsByInstrumentVM> GetShowsByInstrument(string strSearch)
        {
            List<ShowsByInstrumentVM> retval = new List<ShowsByInstrumentVM>();

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT DISTINCT s.\"intShowID\", p.\"strInstrument\"" +
                " FROM pits p, shows s" +
                " WHERE p.\"intShowID\" = s.\"intShowID\"" +
                " and p.\"strInstrument\" ILIKE '%" + strSearch + "%'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ShowsByInstrumentVM tmpShowByInstrument = new ShowsByInstrumentVM
                {
                    IntShowID = Convert.ToInt32(dr["intShowID"]),
                    StrInstrument = dr["strInstrument"].ToString()
                };
                retval.Add(tmpShowByInstrument);
            }

            conn.Close();

            return retval;
        }

        
        public static IEnumerable<NonSingingVM> GetNonSingingMembers()
        {
            List<NonSingingVM> retval = new List<NonSingingVM>();

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "SELECT m.\"intMemberID\"" +
                " FROM members m" +
                " WHERE EXISTS(SELECT *" +
                "              FROM casts c, shows s" +
                "              WHERE c.\"intMemberID\" = m.\"intMemberID\"" +
                "              AND c.\"intShowID\" = s.\"intShowID\"" +
                "              AND s.\"ysnIsMusical\" = TRUE" +
                "              AND c.\"strVoicePart\" IS NULL)";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int id = Convert.ToInt32(dr["intMemberID"]);

                NonSingingVM nonSingingMember = NonSingingVM.Of(id);

                retval.Add(nonSingingMember);
            }

            conn.Close();

            return retval;
        }

        public static IEnumerable<AllActorsNotInVM> GetAllActorsNotIn(int intShowID)
        {
            List<AllActorsNotInVM> retval = new List<AllActorsNotInVM>();

            // create and open a connection
            NpgsqlConnection conn = DatabaseConnection.GetConnection();
            conn.Open();

            // Define a query
            string query = "select DISTINCT m.\"intMemberID\"" +
                " from members m, casts c" +
                " WHERE m.\"intMemberID\" = c.\"intMemberID\" " +
                " EXCEPT(select m2.\"intMemberID\" " +
                "        from members m2, shows s, casts c2" +
                "        where m2.\"intMemberID\" = c2.\"intMemberID\"" +
                "        and c2.\"intShowID\" = s.\"intShowID\"" +
                "        and s.\"intShowID\" = " + intShowID + ")";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            // Execute a query
            NpgsqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int id = Convert.ToInt32(dr["intMemberID"]);

                AllActorsNotInVM tmpActorNotIn = AllActorsNotInVM.Of(id);
                retval.Add(tmpActorNotIn);
            }

            conn.Close();

            return retval;
        }


    }
}