using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        
        public Show Show {  get; set;  }
        
        public int IntShowID {  get; set;  }
        
        public Pit(int intPitID, string strInstrument, int intSeat, int intMemberID, Member member, int intShowID, Show show) 
        {
            this.IntPitID = intPitID;
            this.StrInstrument = strInstrument;
            this.IntSeat = intSeat;
            this.IntMemberID = intMemberID;
            this.Member = member;
            this.IntShowID = intShowID;
            this.Show = show;
        }
        
        public Pit() {  }
        
        public static Pit Of(int intPitID, string strInstrument, int intSeat, int intMemberID, Member member, int intShowID, Show show)
        {
            return new Pit(intPitID, strInstrument, intSeat, intMemberID, member, intShowID, show);
        }
    }
}
