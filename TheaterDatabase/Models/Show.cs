using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheaterDatabase.Models
{
    public class Show
    {
        [Key]
        [Display(Name = "Show ID")]
        public int IntShowID { get; set; }

        public string StrName { get; set; }

        public string StrAuthor { get; set; }

        public int IntBudget { get; set; }

        public bool YsnIsMusical { get; set; }

        public int IntClubID { get; set; }


        public Club Club { get; set; }

        public int IntDateID { get; set; }


        public Date Date { get; set; }


        public Show(int intShowID, string strName, string strAuthor, int intBudget, bool ysnIsMusical, int intClubID, Club club, int intDateID, Date date)
        {
            this.IntShowID = intShowID;
            this.StrName = strName;
            this.StrAuthor = strAuthor;
            this.IntBudget = intBudget;
            this.YsnIsMusical = ysnIsMusical;
            this.IntClubID = intClubID;
            this.Club = club;
            this.IntDateID = intDateID;
            this.Date = date;
        }

        public Show() { }

        public static Show Of(int intShowID, string strName, string strAuthor, int intBudget, bool ysnIsMusical, int intClubID, Club club, int intDateID, Date date)
        {
            return new Show(intShowID, strName, strAuthor, intBudget, ysnIsMusical, intClubID, club, intDateID, date);
        }



    }
}