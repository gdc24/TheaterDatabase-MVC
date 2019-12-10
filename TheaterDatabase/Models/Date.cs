using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheaterDatabase.Models
{
    public class Date
    {
        [Key]
        [Display(Name = "Date ID")]
        
        public int IntDateID { get; set; }

        [Display(Name = "Year")]
        
        public int IntYear { get; set; }

        [Display(Name = "Semester")]
        
        public string StrSemester { get; set; }

        [Display(Name = "Semester")]
        
        public Semester Semester { get; set; }


        [Display(Name = "Semester & Year")]

        public string SemAndYear { get; set; }

        private Date(int intDateID, string strSemester, Semester semester, int intYear)
        {
            this.IntDateID = intDateID;
            this.StrSemester = strSemester;
            this.Semester = semester;
            this.IntYear = intYear;
            this.SemAndYear = semester + " " + intYear;
        }

        public Date() {  }

        public static Date Of(int intDateID, string strSemester, Semester semester, int intYear)
        {
            return new Date(intDateID, strSemester, semester, intYear);
        }

    }
}
