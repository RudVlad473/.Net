using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public abstract class FinancialEntity
    {
        public decimal Balance { get; protected set; }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        // Method to withdraw money from the ATM
        public virtual bool Withdraw(decimal amount)
        {
            bool IsEnoughMoney = Balance >= amount;

            if (!IsEnoughMoney)
            {
                return false;
            }

            Balance -= amount;

            return true;
        }
    }
}
