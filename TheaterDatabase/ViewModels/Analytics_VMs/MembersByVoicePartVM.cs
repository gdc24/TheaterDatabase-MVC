using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TheaterDatabase.Models;

namespace TheaterDatabase.ViewModels.Analytics_VMs
{
    public class MembersByVoicePartVM
    {
        public IEnumerable<MembersByVoicePartVM> LstMembersByVoicePart { get; set; }

        [Display(Name = "Voice Part")]
        public string StrVoicePart { get; set; }

        [Display(Name = "Name")]
        public string StrName { get; set; }

        [Display(Name = "Count")]
        public int IntCount { get; set; }

        public IEnumerable<string> LstAllVoiceParts { get; set; }


        public MembersByVoicePartVM() { }

        public MembersByVoicePartVM(int intCount, string strName, string strVoicePart)
        {
            this.IntCount = intCount;
            this.StrName = strName;
            this.StrVoicePart = strVoicePart;
        }

        public static MembersByVoicePartVM Of(int intCount, string strName, string strVoicePart)
        {
            return new MembersByVoicePartVM(intCount, strName, strVoicePart);
        }
    }
}