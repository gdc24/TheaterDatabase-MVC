﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheaterDatabase.Models;

namespace TheaterDatabase.ViewModels.CRUD_VMs
{
    public class ShowsVM : Show
    {
        public IEnumerable<Show> LstShows { get; set; }

        public IEnumerable<Club> LstAllClubs { get; set; }
        public IEnumerable<Date> LstAllDates { get; set; }
    }
}