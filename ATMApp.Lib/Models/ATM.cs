namespace ATMApp.Lib.Models
{
   
    public class ATM
    {
        public string CardNumber { get; set; } = null!;
        public string Pin { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public decimal Balance { get; set; }   
        public Transaction Transaction { get; set; } = new Transaction();

    }

    public class Transaction
    {
        DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
    }
}
