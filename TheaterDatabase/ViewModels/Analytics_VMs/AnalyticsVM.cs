using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterDatabase.ViewModels.Analytics_VMs
{
    public class AnalyticsVM
    {

        public BudgetAverageVM _budgetAverage_vm { get; set; }

        public MusicalsCountVM _musicalsCount_vm { get; set; }

        public RepeatStaffPositionsVM _repeatStaffPositions_vm { get; set; }

        public MembersByVoicePartVM _membersByVoicePart_vm { get; set; }

        public ShowsByInstrumentVM _showsByInstrument_vm { get; set; }

        public AnalyticsVM()
        {
            _budgetAverage_vm = new BudgetAverageVM();
            _musicalsCount_vm = new MusicalsCountVM();
            _repeatStaffPositions_vm = new RepeatStaffPositionsVM();
            _membersByVoicePart_vm = new MembersByVoicePartVM();
            _showsByInstrument_vm = new ShowsByInstrumentVM();
        }

    }
}