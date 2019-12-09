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
        
        public Pit() {  }
        
        public static Pit Of(int intPitID, string strInstrument, int intSeat)
        {
            return new Pit(intPitID, strInstrument, intSeat);
        }
    }
}
