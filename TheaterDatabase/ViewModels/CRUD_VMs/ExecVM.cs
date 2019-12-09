using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheaterDatabase.Models;

namespace TheaterDatabase.ViewModels.CRUD_VMs
{
    public class ExecVM : Exec
    {

        public IEnumerable<Show> LstExec { get; set; }
    }
}