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
    public partial class BalanceForm : Form
    {
        public ATMServices ATMServices { get; set; } = new ATMServices();
        public BalanceForm()
        {
            InitializeComponent();

            var balance = ATMServices.ShowBalance();
            lbBalance.Text = $"Your balance is .........";
        }
    }
}
