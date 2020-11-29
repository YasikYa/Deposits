using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkLab2.Services.Banking
{
    public class SavingDeposit : OnTermDeposit
    {
        private double _monthIncrease;
        public SavingDeposit(double startSum, DateTime startDate, DateTime expectedEndDate, double monthIncrease) : base(startSum, startDate, expectedEndDate)
        {
            _monthIncrease = monthIncrease;
        }

        public override double Calculate()
        {
            var incomeRateIndex = 1 + IncomeRate / 12;
            return (InitAmount * Math.Pow(incomeRateIndex, 12 * Util.YearDiff(StartDate, EndDate)) * incomeRateIndex - InitAmount * incomeRateIndex) / (IncomeRate / 12);
        }
    }
}
