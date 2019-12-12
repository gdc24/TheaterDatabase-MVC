using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TheaterDatabase.DAL;
using TheaterDatabase.Models;

namespace TheaterDatabase.ViewModels.Analytics_VMs
{
    public class NonSingingVM
    {

        public IEnumerable<NonSingingVM> LstNonSingingMembers { get; set; }

        [Display(Name = "Member")]
        public Member Member { get; set; }

        [Display(Name = "Member Name")]
        public string StrName { get; set; }

        public int IntMemberID { get; set; }


        public NonSingingVM() { }

        public NonSingingVM(string strName, Member mem)
        {
            this.StrName = strName;
            this.Member = mem;
        }

        public static NonSingingVM Of(int intMemberID)
        {
            Member mem = MembersDAL.GetMember(intMemberID);
            return new NonSingingVM(mem.StrName, mem);
        }
    }
}