using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheaterDatabase.Models
{
    public class Exec
    {
        [Key]
        [Display(Name = "Exec ID")]
        
        public int IntExecID {  get; set;  }
        
        [Display(Name = "Position")]
        
        public string StrPosition {  get; set;  }
        
        [Display(Name = "Member")]
        
        public Member Member {  get; set;  }
        
        [Display(Name = "Member ID")]
        
        public int IntMemberID {  get; set;  }
        
        [Display(Name = "Date")]
        
        public Date Date {  get; set;  }
        
        [Display(Name = "Date ID")]
        
        public int IntDateID {  get; set;  }


        [Display(Name = "Club")]
        public Club Club { get; set; }


        [Display(Name = "Club ID")]
        public int IntClubID { get; set; }
        
        public Exec(int intExecID, string strPosition, int intMemberID, Member member, int intDateID, Date date, int intClubID, Club club)
        {
            this.IntExecID = intExecID;
            this.StrPosition = strPosition;
            this.IntMemberID = intMemberID;
            this.Member = member;
            this.IntDateID = intDateID;
            this.Date = date;
            this.IntClubID = intClubID;
            this.Club = club;
        }
        
        public Exec() { }
        
        public static Exec Of(int intExecID, string strPosition, int intMemberID, Member member, int intDateID, Date date, int intClubID, Club club)
        {
            return new Exec(intExecID, strPosition, intMemberID, member, intDateID, date, intClubID, club);
        }
    }
}
