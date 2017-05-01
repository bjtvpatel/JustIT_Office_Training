using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class BankAccount
    {
        protected decimal _balance;

        public BankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        public decimal Balance
        {
            get { return _balance; }
        }

        public virtual decimal Withdraw(decimal amount)
        {
            Console.WriteLine("In BankAccount.Withdraw() for £{0} ... ", amount);
            decimal amountToWithdraw = amount;
            if (amountToWithdraw > Balance)
            {
                amountToWithdraw = Balance;
            }
            _balance -= amountToWithdraw;
            return _balance;
        }
    }

    public class SavingsAccount : BankAccount
    {
        public decimal _interestRate;

        public SavingsAccount(decimal initialBalance, decimal interestRate) : base(initialBalance)
        {
            _interestRate = interestRate / 100;
        }

        public void AccumulateInterest()
        {
            _balance = Balance + (Balance * _interestRate);
        }

        public override decimal Withdraw(decimal withdrawal)
        {
            Console.WriteLine("In SavingsAccount.Withdrawal() ...");
            //take off £1.50 fee
            base.Withdraw(1.5M);
            return base.Withdraw(withdrawal);
        }
    }
}
