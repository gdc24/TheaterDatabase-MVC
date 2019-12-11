using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheaterDatabase.ViewModels.Analytics_VMs
{
    public class RepeatStaffPositionsVM
    {

        public IEnumerable<RepeatStaffPositionsVM> LstRepeatStaffPositions { get; set; }

        public string StrPosition { get; set; }

        [Display(Name="Name")]
        public string StrName { get; set; }

        [Display(Name="Count")]
        public int IntCount { get; set; }

        public IEnumerable<string> LstPossiblePositions { get; set; }


        public RepeatStaffPositionsVM() { }

        public RepeatStaffPositionsVM(int intCount, string strName, string strPosition)
        {
            this.IntCount = intCount;
            this.StrName = strName;
            this.StrPosition = strPosition;
        }

        public static RepeatStaffPositionsVM Of(int intCount, string strName, string strPosition)
        {
            return new RepeatStaffPositionsVM(intCount, strName, strPosition);
        }

    }
}