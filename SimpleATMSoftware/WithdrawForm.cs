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
    public partial class WithdrawForm : Form
    {
        public ATMServices ATMServices { get; set; } = new ATMServices();
        public ATM currentCard = new ATM();
        public WithdrawForm(ATM matchingCard)
        {
            InitializeComponent();
            currentCard = matchingCard;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Amount should not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtAmount.Text.All(char.IsDigit))
            {
                MessageBox.Show("Amount should be a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var amount = Convert.ToInt32(txtAmount.Text);
            ATMServices.Withdraw(amount, currentCard);
            lbBalance.Text = $"Your balance is {currentCard.Balance} $";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
