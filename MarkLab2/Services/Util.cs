using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkLab2.Services
{
    static class Util
    {
        public static int YearDiff(DateTime from, DateTime to)
        {
            var zeroTime = new DateTime(1, 1, 1);
            return (zeroTime + (to - from)).Year - 1;
        }
    }
}
