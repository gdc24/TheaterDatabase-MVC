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
        
        public Exec(int intExecID, string strPosition)
        {
            this.IntExecID = intExecID;
            this.StrPosition = strPosition;
        }
        
        public Exec() { }
        
        public static Exec Of(int intExecID, string strPosition)
        {
            return new Exec(intExecID, strPosition);
        }
    }
}
