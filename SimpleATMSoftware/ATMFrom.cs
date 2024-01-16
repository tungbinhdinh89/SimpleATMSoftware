using ATMApp.Lib.Services;

namespace SimpleATMSoftware
{
    public partial class Form1 : Form
    {
        public ATMServices ATMServices = new ATMServices();
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

                if (string.IsNullOrWhiteSpace(cardNumber) || string.IsNullOrWhiteSpace(pin))
                {
                    throw new ArgumentException("Card Number or Pin is empty");
                }

                if (!ATMServices.ValidationATMCard(cardNumber, pin))
                {
                    MessageBox.Show("Card Number or Pin is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var detailForm = new ViewDetailForm();
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
    }
}
