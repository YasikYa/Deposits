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
    /// Interaction logic for NewDeposit.xaml
    /// </summary>
    public partial class NewDeposit : Window
    {
        public OnTermDeposit Deposit { get; private set; }

        public NewDeposit()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, RoutedEventArgs e)
        {
            Deposit = new OnTermDeposit(Convert.ToDouble(amountInput.Text), startDateInput.SelectedDate.Value.Date, endDateInput.SelectedDate.Value.Date);
            Hide();
        }
    }
}
