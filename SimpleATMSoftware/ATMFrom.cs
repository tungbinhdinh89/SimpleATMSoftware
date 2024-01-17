using ATMApp.Lib.Models;
using ATMApp.Lib.Services;

namespace SimpleATMSoftware
{
    public partial class Form1 : Form
    {
        public ATMServices ATMServices = new ATMServices();
        public ATM matchingCard;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var cardNumber = txtCardNumber.Text;
                var pin = txtPinNumber.Text;

                var jsonData = ATMServices.GetDataFromJson("bank.json");

                if (string.IsNullOrWhiteSpace(cardNumber) || string.IsNullOrWhiteSpace(pin))
                {
                    throw new ArgumentException("Card Number or Pin is empty");
                }

                if (!ATMServices.ValidationATMCard(cardNumber, pin, jsonData))
                {
                    //MessageBox.Show("Card Number or Pin is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbMessage.Text = "Card Number or Pin is invalid";
                    var all = ATMServices.ValidationATMCard(cardNumber, pin, jsonData);
                }
                else
                {
                    matchingCard = jsonData.FirstOrDefault(x => x.CardNumber == cardNumber && x.Pin == pin);
                    var detailForm = new ViewDetailForm(matchingCard);
                    this.Hide();
                    detailForm.ShowDialog();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
