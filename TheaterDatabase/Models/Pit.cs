using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterDatabase.Models
{
    public class Pit
    {
        [Key]
        [Display(Name = "Pit ID")]
        
        public int IntPitID {  get; set;  }
        
        public string StrInstrument {  get; set;  }
        
        public int IntSeat {  get; set;  }
        
        public Member Member {  get; set;  }
        
        public int IntMemberID {  get; set;  }
        
        public Pit(int intPitID, string strInstrument, int intSeat, int intMemberID, Member member) 
        {
            this.IntPitID = intPitID;
            this.StrInstrument = strInstrument;
            this.IntSeat = intSeat;
            this.IntMemberID = intMemberID;
            this.Member = member;
        }
        
        public Pit() {  }
        
        public static Pit Of(int intPitID, string strInstrument, int intSeat, int intMemberID, Member member)
        {
            return new Pit(intPitID, strInstrument, intSeat, intMemberId, member);
        }
    }
}
