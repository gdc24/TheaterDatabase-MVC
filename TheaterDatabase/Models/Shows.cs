using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheaterDatabase.Models
{
    public class Shows
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





    }
}