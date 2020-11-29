using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkLab2.Services.Banking
{
    public interface IDeposit
    {
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        double InitAmount { get; }
        double IncomeRate { get; }
        double Calculate();
    }
}
