﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterDatabase.ViewModels.Analytics_VMs
{
    public class AnalyticsVM
    {

        public BudgetAverageVM _budgetAverage_vm { get; set; }

        public MusicalsCountVM _musicalsCount_vm { get; set; }

        public AnalyticsVM()
        {
            _budgetAverage_vm = new BudgetAverageVM();
            _musicalsCount_vm = new MusicalsCountVM();
        }

    }
}