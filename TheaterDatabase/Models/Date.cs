using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterDatabase.Models
{
    public class Date
    {

        public int IntDateID { get; set; }

        public int IntYear { get; set; }

        public string StrSemester { get; set; }

        public Semester Semester { get; set; }

        private Date(int intDateID, string strSemester, Semester semester, int intYear)
        {
            this.IntDateID = intDateID;
            this.StrSemester = strSemester;
            this.Semester = semester;
            this.IntYear = intYear;
        }

        public static Date Of(int intDateID, string strSemester, Semester semester, int intYear)
        {
            return new Date(intDateID, strSemester, semester, intYear);
        }

    }
}