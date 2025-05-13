using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Accounts_Application
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }
        public string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return "You cannot depost $" + amount;
            }
            if (amount > 20_000)
            {
                return "AML Deposit Limit.";
            }
            Balance += amount;
            return "Deposit completed sucessfully.";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return "You cannot deposit $" + amount;
            }
            if(amount > Balance)
            {
                return "You don't have enough money.";
            }
            Balance -= amount;
            return "Withdraw completed sucessfully.";
        }
    }
}
