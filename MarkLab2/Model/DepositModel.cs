using MarkLab2.Services.Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkLab2.Model
{
    class DepositModel
    {
        public int Id { get; set; }

        public IDeposit Deposit { get; set; }
    }
}
