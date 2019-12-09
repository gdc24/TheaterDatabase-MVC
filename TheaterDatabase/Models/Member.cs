using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterDatabase.Models
{
    public class Member
    {
        [Key]
        [Display(Name = "Member ID")]
        
        public int IntMemberID {  get; set;  }
        
        public string StrName {  get; set;  }
        
        public Member(int intMemberID, string strName)
        {
            this.IntMemberID = intMemberID;
            this.StrName = strName;
        }
    }
}
