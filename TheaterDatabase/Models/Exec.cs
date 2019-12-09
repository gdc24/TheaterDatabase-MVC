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
        
        public string StrPosition {  get; set;  }
        
        public Member Member {  get; set;  }
        
        public int IntMemberID {  get; set;  }
        
        public Date Date {  get; set;  }
        
        public int IntDateID {  get; set;  }
        
        public Exec(int intExecID, string strPosition, int intMemberID, Member member, int intDateID, Date date)
        {
            this.IntExecID = intExecID;
            this.StrPosition = strPosition;
            this.IntMemberID = intMemberID;
            this.Member = member;
            this.IntDateID = intDateID;
            this.Date = date;
        }
        
        public Exec() { }
        
        public static Exec Of(int intExecID, string strPosition, int intMemberID, Member member, int intDateID, Date date)
        {
            return new Exec(intExecID, strPosition, intMemberID, member, intDateID, date);
        }
    }
}
