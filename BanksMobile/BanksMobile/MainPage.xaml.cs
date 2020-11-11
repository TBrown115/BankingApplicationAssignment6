using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Banking;

namespace BanksMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Bank fnb = new Bank("First National Bank", 4324, "Zevenwacht"); //new instance

            Customer bob = new Customer("7766445424", "10 me at home", "Bob", "Sanders");
            fnb.AddCustomer(bob);
        }

        private void DepositButton(object sender, EventArgs e)
        {

        }

        private void WithdrawButton(object sender, EventArgs e)
        {

        }

        private void HistoryButton(object sender, EventArgs e)
        {

        }
    }
}
