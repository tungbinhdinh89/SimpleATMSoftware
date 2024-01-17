using ATMApp.Lib.Models;
using ATMApp.Lib.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleATMSoftware
{
    public partial class ViewDetailForm : Form
    {
        public ATM matching;
        public ATMServices ATMServices = new ATMServices();
        public ViewDetailForm(ATM matchingCard)
        {
            InitializeComponent();
            lbGreeting.Text = $"Hi! {matchingCard.FullName}";
            matching = matchingCard;
        }

        private void btnViewBalance_Click(object sender, EventArgs e)
        {
            var formBalance = new BalanceForm(matching);
            formBalance.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            var formWithdraw = new WithdrawForm(matching);
            formWithdraw.ShowDialog();
        }

        private void btnLast5Transactions_Click(object sender, EventArgs e)
        {
            var formTransaction = new TransactionsForm(matching);
            formTransaction.ShowDialog();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
