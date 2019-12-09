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
        
        public Staff(int intStaffID, string strPosition, int intMemberID, Member member)
        {
            this.IntStaffID = intStaffID;
            this.StrPosition = strPosition;
            this.IntMemberID = intMemberID;
            this.Member = member;
        }
        
        public Staff() { }
        
        public static Staff Of(int intStaffID, string strPosition, int intMemberID, Member member)
        {
            return new Staff(intStaffID, strPosition, intMemberID, member);
        }
    }
}
