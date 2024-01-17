using ATMApp.Lib.Models;
using ATMApp.Lib.Services;

namespace SimpleATMSoftware
{
    public partial class TransactionsForm : Form
    {
        public ATMServices ATMServices { get; set; } = new ATMServices();
        public ATM currentCard = new ATM();
        public TransactionsForm(ATM matchingCard)
        {
            InitializeComponent();
            var transactions = ATMServices.ShowLast5Transactions(matchingCard);
            RenderToListView(transactions);
        }

        public void RenderToListView(List<Transaction> transactions)
        {
            lvTransaction.Clear();
            foreach (Transaction transaction in transactions)
            {
                if (transaction is null)
                {
                    throw new ArgumentNullException("Not null");
                }

                ListViewItem item = new ListViewItem(transaction.TransactionDate.ToString());
                item.SubItems.Add(transaction.Amount.ToString());
                item.Tag = transaction;
                lvTransaction.Items.Add(item);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
