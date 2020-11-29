using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkLab2.Services.Banking
{
    public class OnDemandDeposit : DepositBase
    {
        public OnDemandDeposit(double startSum, DateTime startDate) : base(startSum, startDate, DateTime.MaxValue, 0.01)
        {
            
        }

        public override double Calculate()
        {
            var now = DateTime.Now;
            var monthDiff = ((now.Year - StartDate.Year) * 12) + now.Month - StartDate.Month;
            var total = InitAmount * Math.Pow(1 + IncomeRate, monthDiff);
            return total;
        }
    }
}
