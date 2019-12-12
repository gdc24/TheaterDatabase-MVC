using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TheaterDatabase.DAL;
using TheaterDatabase.Models;

namespace TheaterDatabase.ViewModels.Analytics_VMs
{
    public class AllActorsNotInVM
    {


        public IEnumerable<AllActorsNotInVM> LstAllActorsNotIn { get; set; }


        public int IntShowID { get; set; }

        [Display(Name = "Not In")]
        public Show Show { get; set; }

        [Display(Name = "Member")]
        public Member Member { get; set; }

        public IEnumerable<Show> LstAllShows { get; set; }


        public AllActorsNotInVM() { }

        public AllActorsNotInVM(Member member)
        {
            this.Member = member;
        }

        public static AllActorsNotInVM Of(int intMemberID)
        {
            Member mem = MembersDAL.GetMember(intMemberID);
            return new AllActorsNotInVM(mem);
        }


    }
}