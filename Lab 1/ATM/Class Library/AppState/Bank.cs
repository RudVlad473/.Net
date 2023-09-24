using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class Bank
    {
        public List<ATM>? Atms { get; private set; }
        private List<Account>? Accounts { get; set; }

        public Bank(List<ATM> atms, List<Account> accounts)
        {
            Atms = atms;
            Accounts = accounts;
        }

        public Account Authenticate(Credentials credentials)
        {
            var account = Accounts
                ?.Where(account => account.Credentials == credentials)
                .FirstOrDefault();

            if (account == null)
            {
                throw new Exception("Account not found");
            }

            return account;
        }

        public void Transaction(Account from, string targetCardNumber, decimal amount)
        {
            var accountFrom = Accounts
                ?.Where(account => from.Credentials == account.Credentials)
                .FirstOrDefault();

            var accountTo = Accounts
                ?.Where(account => account.Credentials.CardNumber == targetCardNumber)
                .FirstOrDefault();

            if (accountFrom == null)
            {
                throw new Exception("Sender account doesn't exist");
            }

            if (accountTo == null)
            {
                throw new Exception("Receiver account");
            }

            bool isEnoughMoney = accountFrom.Withdraw(amount);

            if (!isEnoughMoney)
            {
                throw new Exception("Not enough money");
            }

            accountTo.Deposit(amount);
        }
    }
}
