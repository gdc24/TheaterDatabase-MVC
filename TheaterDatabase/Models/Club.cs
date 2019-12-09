using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheaterDatabase.Models
{
    public class Club
    {
        [Key]
        [Display(Name = "Club ID")]
        
        public int IntClubID { get; set; }
        
        [Display(Name = "Club Name")]
        
        public string StrClubName { get; set; }
        
        [Display(Name = "Advisor")]
        
        public string StrAdvisor { get; set; }
        
        [Display(Name = "Umbrella Org")]
        
        public string StrUmbrellaOrg { get; set; }
        
        [Display(Name = "Umbrella Org")]
        
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
