using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkLab2.Services.Banking
{
    public class OnTermDeposit : DepositBase
    {
        public OnTermDeposit(double startSum, DateTime startDate, DateTime expectedEndDate) : base(startSum, startDate, expectedEndDate, GetIncomeRate(startDate, expectedEndDate))
        {
        }

        public override double Calculate()
        {
            return InitAmount * Math.Pow(1 + IncomeRate, Util.YearDiff(StartDate, EndDate));
        }

        private static double GetIncomeRate(DateTime from, DateTime to) => from.AddYears(3) < to ? 0.13 : 0.07;
    }
}
