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
             var matchingCard = atm.FirstOrDefault(x => x.CardNumber == cardNumber && x.Pin == pin);

            return matchingCard != null;
        }

        public decimal ShowBalance (ATM matchingCard)
        {
            if (matchingCard is null)
            {
                throw new ArgumentNullException(nameof(matchingCard), "Matching card cannot be null");
            }
            return matchingCard.Balance;
        }

        public decimal Withdraw(int amount, ATM matchingCard)
        {
            if (matchingCard is null)
            {
                throw new ArgumentNullException(nameof(matchingCard), "Matching card cannot be null");
            }

            if (amount < 0)
            {
                throw new ArgumentException("Amount must be a non-negative value", nameof(amount));
            }

            if (amount > matchingCard.Balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            matchingCard.Transactions.Add(new Transaction
            {
                TransactionDate = DateTime.Now,
                Amount = amount
            });
            return matchingCard.Balance -= amount;
        }

        public List<Transaction> ShowLast5Transactions (ATM matchingCard)
        {
            if (matchingCard == null)
            {
                throw new ArgumentNullException(nameof(matchingCard));
            }

            var transactions = matchingCard.Transactions?.Take(5).ToList();
            return transactions ?? new List<Transaction>();
        }
    }
}
