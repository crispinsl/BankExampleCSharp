using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class SavingsAccount : Account
    {
        public decimal InterestRate { get; private set; }
        public SavingsAccount(string accountNumber, string accountName, decimal initialBalance, decimal interestRate) :
            base(accountNumber, accountName, initialBalance)
        {
            InterestRate = interestRate;
        }
        public void ApplyInterest()
        {
            //Balance += Balance * InterestRate;
            //cant access because balance is set to private
            decimal interestPayment = Balance * InterestRate;
            this.Deposit(interestPayment);
            //this allows you to perform the same action but without directly seeing/interacting 
        }
    }
}
