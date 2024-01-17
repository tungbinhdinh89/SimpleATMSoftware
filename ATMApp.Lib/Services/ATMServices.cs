using ATMApp.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.Lib.Services
{
    public class ATMServices
    {
        public List<ATM> GetDataFromJson(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException("path not empty");
            }
            return [];
        }

        public bool ValidationATMCard(string cardNumber, string pin)
        {
            return true;
        }

        public decimal ShowBalance ()
        { 
            return 0;
        }

        public decimal Withdraw(int amount)
        {
            return 0;
        }

        public List<ATM> ShowLast5Transactions (int amount)
        {
            return new List<ATM> ();
        }
    }
}
