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

        [Display(Name = "Name")]
        
        public string StrName { get; set; }

        [Display(Name = "Author")]
        
        public string StrAuthor { get; set; }

        [Display(Name = "Budget")]
        
        public int IntBudget { get; set; }

        [Display(Name = "Is Musical")]
        
        public bool YsnIsMusical { get; set; }

        [Display(Name = "Club ID")]
        
        public int IntClubID { get; set; }

        [Display(Name = "Club")]
        
        public Club Club { get; set; }

        [Display(Name = "Date ID")]
        
        public int IntDateID { get; set; }

        [Display(Name = "Date")]
        
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
