using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class CheckingAccount : Account
    {
        public decimal OverdraftLimit { get; private set; }
        public CheckingAccount(string accountNumber, string accountName, decimal initialBalance, decimal overdraftLimit) :
            base(accountNumber, accountName, initialBalance)
        {
            OverdraftLimit = overdraftLimit;
        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Withdraw amount must be positive.");
            if (amount > Balance + OverdraftLimit) throw new ArgumentException("Overdraft limit exceeded.");
            //Balance -= amount;
            //once again, cant interact with directly becase Balance is private
            this.Withdraw(amount);
        }
    }
}
