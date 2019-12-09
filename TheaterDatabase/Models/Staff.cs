using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterDatabase.Models
{
    public class Staff
    {
        [Key]
        [Display(Name = "Staff ID")]
        
        public int IntStaffID {  get; set;  }
        
        public string StrPosition {  get; set;  }
        
        public Member Member {  get; set;  }
        
        public int IntMemberID {  get; set;  }
        
        public Show Show {  get; set;  }
        
        public int IntShowID {  get; set;  }
        
        public Staff(int intStaffID, string strPosition, int intMemberID, Member member, int intShowID, Show show)
        {
            this.IntStaffID = intStaffID;
            this.StrPosition = strPosition;
            this.IntMemberID = intMemberID;
            this.Member = member;
            this.IntShowID = intShowID;
            this.Show = show;
        }
        
        public Staff() { }
        
        public static Staff Of(int intStaffID, string strPosition, int intMemberID, Member member, int intShowID, Show show)
        {
            return new Staff(intStaffID, strPosition, intMemberID, member, intShowID, show);
        }
    }
}
