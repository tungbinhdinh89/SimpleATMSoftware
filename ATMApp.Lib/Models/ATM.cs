namespace ATMApp.Lib.Models
{
    public class ATM
    {
        public string CardNumber { get; set; } = null!;
        public string Pin { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public decimal Balance { get; set; }    

    }
}
