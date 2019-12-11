using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterDatabase.ViewModels.Analytics_VMs
{
    public class MusicalsCountVM
    {
        public IEnumerable<MusicalsCountVM> LstMusicalCounts { get; set; }

        public string StrShowType { get; set; }

        public int IntCount { get; set; }

        public MusicalsCountVM() { }

        public MusicalsCountVM(int intCount, string strShowType)
        {
            this.IntCount = intCount;
            this.StrShowType = strShowType;
        }

        public static MusicalsCountVM Of(int intCount, string strShowType)
        {
            return new MusicalsCountVM(intCount, strShowType);
        }


    }
}