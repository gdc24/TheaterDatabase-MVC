using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterDatabase.Models
{
    public class Club
    {
        public int IntClubID { get; set; }
        public string StrClubName { get; set; }
        public string StrAdvisor { get; set; }
        public string StrUmbrellaOrg { get; set; }
        public UmbrellaOrg UmbrellaOrg { get; set; }
        private Club(int intClubID, string strClubName, string strAdvisor, string strUmbrellaOrg, UmbrellaOrg umbrellaOrg)
        {
            this.IntClubID = intClubID;
            this.StrClubName = strClubName;
            this.StrAdvisor = strAdvisor;
            this.StrUmbrellaOrg = strUmbrellaOrg;
            this.UmbrellaOrg = umbrellaOrg;
        }

        public static Club Of(int intClubID, string strClubName, string strAdvisor, string strUmbrellaOrg, UmbrellaOrg umbrellaOrg)
        {
            return new Club(intClubID, strClubName, strAdvisor, strUmbrellaOrg, umbrellaOrg);
        }
    }
}