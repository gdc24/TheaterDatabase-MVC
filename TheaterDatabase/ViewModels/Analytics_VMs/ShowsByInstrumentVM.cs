using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TheaterDatabase.DAL;
using TheaterDatabase.Models;

namespace TheaterDatabase.ViewModels.Analytics_VMs
{
    public class ShowsByInstrumentVM
    {
        public IEnumerable<ShowsByInstrumentVM> LstShowsByInstrument { get; set; }

        [Display(Name = "Search Term")]
        public string StrSearch { get; set; }

        [Display(Name = "Instrument")]
        public string StrInstrument { get; set; }

        [Display(Name = "Show")]
        public Show Show { get; set; }

        public int IntShowID { get; set; }

        public ShowsByInstrumentVM() { }

        public ShowsByInstrumentVM(string strSearch, Show show)
        {
            this.StrSearch = strSearch;
            this.Show = show;
        }

        public static ShowsByInstrumentVM Of(string strSearch, int intShowID)
        {
            Show show = ShowsDAL.GetShow(intShowID);
            return new ShowsByInstrumentVM(strSearch, show);
        }



    }
}