using ATMApp.Lib.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ATMApp.Lib.Services
{
    public class ATMServices
    {
        public List<ATM> GetDataFromJson(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException(nameof(path), "Path should not be empty");
            }

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File not found", path);
            }

            var jsonData = File.ReadAllText(path);

            if (string.IsNullOrWhiteSpace(jsonData))
            {
                return new List<ATM>();
            }

            List<ATM> atm = JsonConvert.DeserializeObject<List<ATM>>(jsonData);

            return atm ?? new List<ATM>();
        }

        public bool ValidationATMCard(string cardNumber, string pin, List<ATM> atm)
        {
            if (string.IsNullOrWhiteSpace(cardNumber) || string.IsNullOrWhiteSpace(pin) || atm == null)
            {
                return false; 
            }
            ATM matchingCard = atm.FirstOrDefault(x => x.CardNumber == cardNumber && x.Pin == pin);

            return matchingCard != null;
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
