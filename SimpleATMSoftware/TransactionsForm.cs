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
            currentCard = matchingCard;
        }

        public void RenderToListView(List<Transaction> transactions)
        {
            foreach (Transaction transaction in transactions)
            {
                if (transaction == null)
                {
                    throw new ArgumentNullException("Not null");
                }


            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
