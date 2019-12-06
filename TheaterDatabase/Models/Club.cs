using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterDatabase.Models
{
    public class Club
    {
        public int IntClubID { get; set; }
        public String StrClubName { get; set; }
        public String StrAdvisor { get; set; }
        public UmbrellaOrg UmbrellaOrg { get; set; }
        private Club(int intClubID, String strClubName, String strAdvisor, UmbrellaOrg umbrellaOrg)
        {
            this.IntClubID = intClubID;
            this.StrClubName = strClubName;
            this.StrAdvisor = strAdvisor;
            this.UmbrellaOrg = umbrellaOrg;
        }

        public static Club of(int intClubID, String strClubName, String strAdvisor, UmbrellaOrg umbrellaOrg)
        {
            return new Club(intClubID, strClubName, strAdvisor, umbrellaOrg);
        }
    }
}