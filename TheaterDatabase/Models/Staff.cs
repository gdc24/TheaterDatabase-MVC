using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterDatabase.Models
{
    public class Staff
    {
        [Key]
        [Display(Name = "Staff ID")]
        
        public int IntStaffID {  get; set;  }
        
        public string StrPosition {  get; set;  }
        
        public Staff(int intStaffID, string strPosition)
        {
            this.IntStaffID = intStaffID;
            this.StrPosition = strPosition;
        }
        
        public Staff() { }
        
        public static Staff Of(int intStaffID, string strPosition)
        {
            return new Staff(intStaffID, strPosition);
        }
    }
}
