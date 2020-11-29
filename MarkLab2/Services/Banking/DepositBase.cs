using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkLab2.Services.Banking
{
    public abstract class DepositBase : IDeposit
    {
        public DepositBase(double startSum, DateTime startDate, DateTime expectedEndDate, double initRate)
        {
            InitAmount = startSum;
            StartDate = startDate;
            EndDate = expectedEndDate;
            IncomeRate = initRate;
        }

        public DateTime StartDate { get; }

        public DateTime EndDate { get; }

        public double InitAmount { get; }

        public double IncomeRate { get; }

        public abstract double Calculate();
    }
}
