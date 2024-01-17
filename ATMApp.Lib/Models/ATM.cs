namespace ATMApp.Lib.Models
{
   
    public class ATM
    {
        public string CardNumber { get; set; } = null!;
        public string Pin { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public decimal Balance { get; set; }   
        public List<Transaction> Transactions { get; set; } = new  List<Transaction>();

    }

    public class Transaction
    {
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
    }
}
