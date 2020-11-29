using MarkLab2.Model;
using MarkLab2.Services;
using MarkLab2.Services.Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MarkLab2
{
    /// <summary>
    /// Interaction logic for Details.xaml
    /// </summary>
    public partial class Details : Window
    {
        public DepositDetailsModel Deposit { get; }

        public Details(IDeposit deposit)
        {
            Deposit = new DepositDetailsModel
            {
                Income = Math.Round(deposit.Calculate(), 2),
                Rate = deposit.IncomeRate,
                TimeActive = deposit.EndDate == DateTime.MaxValue ? "Unlimited OnDemand" : Util.YearDiff(deposit.StartDate, deposit.EndDate).ToString(),
                Type = GetDepositType(deposit)
            };
            InitializeComponent();
            detailsGrid.DataContext = Deposit;
        }

        private string GetDepositType(IDeposit deposit)
        {
            if (deposit is OnDemandDeposit)
                return "OnDemand";
            else if (deposit is SavingDeposit)
                return "Saving";
            else if (deposit is OnTermDeposit)
                return "OnTerm";
            else
                throw new Exception("Not supported deposit type");
        }
    }
}
