using System;
using System.Collections.Generic;
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
        
        public Exec(int intExecID, string strPosition, int intMemberID, Member member)
        {
            this.IntExecID = intExecID;
            this.StrPosition = strPosition;
            this.IntMemberID = intMemberID;
            this.member = member;
        }
        
        public Exec() { }
        
        public static Exec Of(int intExecID, string strPosition, int intMemberID, Member member)
        {
            return new Exec(intExecID, strPosition, intMemberID, member);
        }
    }
}
