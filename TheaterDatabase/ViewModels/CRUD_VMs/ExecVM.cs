﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheaterDatabase.Models;

namespace TheaterDatabase.ViewModels.CRUD_VMs
{
    public class ExecVM : Exec
    {

        public IEnumerable<Exec> LstExec { get; set; }

        public IEnumerable<Member> LstAllMembers { get; set; }

        public IEnumerable<Club> LstAllClubs { get; set; }

        public IEnumerable<Date> LstAllDates { get; set; }


    }
}