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
        public ATMServices ATMServices = new ATMServices();
        public ViewDetailForm()
        {
            InitializeComponent();
            lbGreeting.Text = $"Hi! Tung";
        }

        private void btnViewBalance_Click(object sender, EventArgs e)
        {
            var formBalance = new BalanceForm();
            formBalance.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            var formWithdraw = new WithdrawForm();
            formWithdraw.ShowDialog();
        }

        private void btnLast5Transactions_Click(object sender, EventArgs e)
        {
            var formTransaction = new TransactionsForm();
            formTransaction.ShowDialog();
        }
    }
}
