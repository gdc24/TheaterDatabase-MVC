using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheaterDatabase.ViewModels.Analytics_VMs
{
    public class BudgetAverageVM
    {
        
        public IEnumerable<BudgetAverageVM> LstBudgetAverages { get; set; }

        public string StrClubName { get; set; }

        public int IntBudgetAverage { get; set; }

        public BudgetAverageVM() { }

        public BudgetAverageVM(int intBudgetAverage, string strClubName) {
            this.IntBudgetAverage = intBudgetAverage;
            this.StrClubName = strClubName;
        }

        public static BudgetAverageVM Of(int intBudgetAverage, string strClubName)
        {
            return new BudgetAverageVM(intBudgetAverage, strClubName);
        }

    }
}