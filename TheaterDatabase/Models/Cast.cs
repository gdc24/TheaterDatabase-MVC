using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterDatabase.Models
{
    public class Cast
    {
        [Key]
        [Display(Name = "Cast ID")]
        
        public int IntCastID {  get; set;  }
        
        public string StrVoicePart {  get; set;  }
        
        public string StrRole {  get; set;  }
        
        public Cast(int intCastID, string strVoicePart, string strRole)
        {
            this.IntCastID = intCastID;
            this.StrVoicePart = strVoicePart;
            this.StrRole = strRole;
        }
        
        public Cast { }
        
        public static Cast Of(int intCastID, string strVoicePart, string strRole)
        {
            return new Cast(intCastID, strVoicePart, strRole);
        }
    }
}
