using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterDatabase.ViewModels.CRUD_VMs
{
    public class CRUDVM
    {

        public CastsVM _casts_vm { get; set; }
        public ExecVM _exec_vm { get; set; }
        public MembersVM _members_vm { get; set; }
        public PitsVM _pits_vm { get; set; }
        public ShowsVM _shows_vm { get; set; }
        public StaffVM _staff_vm { get; set; }


        public CRUDVM()
        {
            _casts_vm = new CastsVM();
            _exec_vm = new ExecVM();
            _members_vm = new MembersVM();
            _pits_vm = new PitsVM();
            _shows_vm = new ShowsVM();
            _staff_vm = new StaffVM();
        }

    }
}