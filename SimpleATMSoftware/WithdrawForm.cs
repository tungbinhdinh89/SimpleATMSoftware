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
        public WithdrawForm()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(btnAccept.Text))
            {
                MessageBox.Show("Amount should not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (!IsNumeric(txtAmount.Text))
            //{
            //    MessageBox.Show("Amount should be a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            var amount = Convert.ToInt32(btnAccept.Text);
            ATMServices.Withdraw(amount);
        }
    }
}
