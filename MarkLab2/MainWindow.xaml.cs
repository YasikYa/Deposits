using MarkLab2.Model;
using MarkLab2.Services.Banking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MarkLab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<DepositModel> _ongoingDeposits = new ObservableCollection<DepositModel>();

        public MainWindow()
        {
            _ongoingDeposits.Add(new DepositModel { Id = 1, Deposit = new OnDemandDeposit(100000, DateTime.Now.AddMonths(-13)) });
            _ongoingDeposits.Add(new DepositModel { Id = 2, Deposit = new OnTermDeposit(100000, DateTime.Now, DateTime.Now.AddMonths(25)) });
            _ongoingDeposits.Add(new DepositModel { Id = 3, Deposit = new OnTermDeposit(100000, DateTime.Now, DateTime.Now.AddMonths(42)) });
            _ongoingDeposits.Add(new DepositModel { Id = 4, Deposit = new SavingDeposit(100000, DateTime.Now, DateTime.Now.AddMonths(25), 1000) });
            _ongoingDeposits.Add(new DepositModel { Id = 5, Deposit = new SavingDeposit(100000, DateTime.Now, DateTime.Now.AddMonths(42), 1000) });

            InitializeComponent();
            depositList.ItemsSource = _ongoingDeposits;
        }

        private void addTermdepositButton_Click(object sender, RoutedEventArgs e)
        {
            var createTermDepositForm = new NewDeposit();
            createTermDepositForm.ShowDialog();
            _ongoingDeposits.Add(new DepositModel { Id = _ongoingDeposits.Count + 1, Deposit = createTermDepositForm.Deposit });
        }

        private void deleteDeposit_Click(object sender, RoutedEventArgs e)
        {
            var id = Convert.ToInt32((sender as Button).DataContext.ToString());
            var deleteDeposit = _ongoingDeposits.FirstOrDefault(dm => dm.Id == id);
            _ongoingDeposits.Remove(deleteDeposit);
        }

        private void detailsButton_Click(object sender, RoutedEventArgs e)
        {
            var id = Convert.ToInt32((sender as Button).DataContext.ToString());
            var deposit = _ongoingDeposits.FirstOrDefault(dm => dm.Id == id);
            var detailsForm = new Details(deposit.Deposit);
            detailsForm.ShowDialog();
        }

        private void addSavingDepositButton_Click(object sender, RoutedEventArgs e)
        {
            var createSavingDepositForm = new NewSaving();
            createSavingDepositForm.ShowDialog();
            _ongoingDeposits.Add(new DepositModel { Id = _ongoingDeposits.Count + 1, Deposit = createSavingDepositForm.Deposit });
        }

        private void addDemandDepositButton_Click(object sender, RoutedEventArgs e)
        {
            var createDemandDepositForm = new NewDemand();
            createDemandDepositForm.ShowDialog();
            _ongoingDeposits.Add(new DepositModel { Id = _ongoingDeposits.Count + 1, Deposit = createDemandDepositForm.Deposit });
        }
    }
}
