using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphysim
{
    internal abstract class BankAccount
    {
        private int AccountNumber;
        public double Balance;
        public  BankAccount(int AccountNumber, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
        }
        public abstract void Withdraw(double amount);
    }
    internal class SavingsAccount : BankAccount
    {
        public double savingbalance;
        public SavingsAccount(int AccountNumber, double Balance,double savingbalance) : base(AccountNumber, Balance)
        {
            this.savingbalance = savingbalance;
        }

        public override void Withdraw(double amount)
        {

            Console.WriteLine($"You have in saving accaount {this.savingbalance} after withdrawing you have {this.savingbalance-amount}");
        }
    }
    internal class CheckingAccount : BankAccount
    {
        
        public CheckingAccount(int AccountNumber, double Balance) : base(AccountNumber, Balance)
        {
            
        }

        public override void Withdraw(double amount)
        {
            Console.WriteLine($"You have in  accaount {this.Balance} after withdrawing you have {this.Balance - amount}");

        }
    }
}
