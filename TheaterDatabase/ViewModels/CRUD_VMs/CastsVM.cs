using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheaterDatabase.Models;

namespace TheaterDatabase.ViewModels.CRUD_VMs
{
    public class CastsVM : Cast
    {

        public IEnumerable<Cast> LstCasts { get; set; }

        public IEnumerable<Member> LstAllMembers { get; set; }

        public IEnumerable<Show> LstAllShows { get; set; }
    }
}