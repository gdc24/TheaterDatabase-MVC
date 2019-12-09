using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        
        public Club Club {  get; set;  }
        
        public int IntClubID {  get; set;  }
        
        public Member(int intMemberID, string strName, int intClubID, Club club)
        {
            this.IntMemberID = intMemberID;
            this.StrName = strName;
            this.IntClubID = intClubID;
            this.Club = club;
        }
        
        public Member() { }
        
        public static Member Of(int intMemberID, string strName, int intClubID, Club club) 
        {
            return new Member(intMemberID, strName, intClubID, club);
        }
    }
}
