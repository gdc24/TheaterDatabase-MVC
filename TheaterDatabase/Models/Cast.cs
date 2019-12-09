using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheaterDatabase.Models
{
    public class Cast
    {
        [Key]
        [Display(Name = "Cast ID")]
        
        public int IntCastID {  get; set;  }
        
        [Display(Name = "Voice Part")]
        
        public string StrVoicePart {  get; set;  }
        
        [Display(Name = "Role")]
        
        public string StrRole {  get; set;  }
        
        [Display(Name = "Member")]
        
        public Member Member {  get; set;  }
        
        [Display(Name = "Member ID")]
        
        public int IntMemberID {  get; set;  }
        
        [Display(Name = "Show")]
        
        public Show Show {  get; set;  }
        
        [Display(Name = "Show ID")]
        
        public int IntShowID {  get; set;  }
        
        public Cast(int intCastID, string strVoicePart, string strRole, int intMemberID, Member member, int intShowID, Show show)
        {
            this.IntCastID = intCastID;
            this.StrVoicePart = strVoicePart;
            this.StrRole = strRole;
            this.IntMemberID = intMemberID;
            this.Member = member;
            this.IntShowID = intShowID;
            this.Show = show;
        }
        
        public Cast() { }
        
        public static Cast Of(int intCastID, string strVoicePart, string strRole, int intMemberID, Member member,  int intShowID, Show show)
        {
            return new Cast(intCastID, strVoicePart, strRole, intMemberID, member, intShowID, show);
        }
    }
}
