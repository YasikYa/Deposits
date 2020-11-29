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
    /// Interaction logic for NewDemand.xaml
    /// </summary>
    public partial class NewDemand : Window
    {
        public OnDemandDeposit Deposit { get; set; }

        public NewDemand()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            var amount = Convert.ToDouble(initAmountTextBox.Text);
            Deposit = new OnDemandDeposit(amount, DateTime.Now);
            Hide();
        }
    }
}
