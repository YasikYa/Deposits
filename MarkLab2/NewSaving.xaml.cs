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
    /// Interaction logic for NewSaving.xaml
    /// </summary>
    public partial class NewSaving : Window
    {
        public SavingDeposit Deposit { get; set; }

        public NewSaving()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            var amount = Convert.ToDouble(initAmountTextBox.Text);
            var monthIncome = Convert.ToDouble(monthIncomeTextBox.Text);
            Deposit = new SavingDeposit(amount, startDatePicker.SelectedDate.Value, endDatePicker.SelectedDate.Value, monthIncome);
            Hide();
        }
    }
}
