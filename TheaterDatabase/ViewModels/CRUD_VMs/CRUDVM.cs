using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterDatabase.ViewModels.CRUD_VMs
{
    public class CRUDVM
    {

        public ShowsVM _shows_vm { get; set; }


        public CRUDVM()
        {
            _shows_vm = new ShowsVM();
        }

    }
}