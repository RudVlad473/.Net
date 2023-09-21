using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class AppState
    {
        private static readonly AppState _instance = new AppState();

        public static AppState Instance
        {
            get { return _instance; }
        }

        private AppState() { }

        public void Initialize(List<ATM> atms, List<Account> accounts)
        {
            Atms = atms;
            Accounts = accounts;
        }

        public ATM? SelectedAtm { get; private set; }
        public Account? SelectedAccount { get; private set; }
        public List<ATM>? Atms { get; private set; }
        public List<Account>? Accounts { get; private set; }

        //public AppState(List<ATM> atms, List<Account> accounts)
        //{
        //    Atms = atms;
        //    Accounts = accounts;
        //}

        public void SelectAtm(string atmId)
        {
            var atm = Atms?.Where(atm => atm.Id == atmId).FirstOrDefault();

            if (atm == null)
            {
                throw new Exception("ATM not found");
            }

            SelectedAtm = atm;
        }

        public void SelectAccount(string cardNumber)
        {
            var account = Accounts
                ?.Where(account => account.CardNumber == cardNumber)
                .FirstOrDefault();

            if (account == null)
            {
                throw new Exception("Account not found");
            }

            SelectedAccount = account;
        }

        public List<ATM>? GetNearestAtms()
        {
            if (SelectedAtm == null)
            {
                throw new Exception("ATM not selected");
            }

            var nearestAtms = Atms?.Where(atm =>
            {
                if (atm.Id == SelectedAtm.Id)
                {
                    return false;
                }

                bool areAtmsNear = SelectedAtm.LocationAddress.IsNear(atm.LocationAddress);

                return areAtmsNear;
            })
                .ToList();

            return nearestAtms;
        }

        public void Withdraw(decimal amount)
        {
            if (SelectedAccount == null)
            {
                throw new Exception("Account not selected");
            }

            if (SelectedAtm == null)
            {
                throw new Exception("ATM not selected");
            }

            if (SelectedAccount.Balance < amount)
            {
                throw new Exception("Insufficient funds");
            }

            SelectedAccount.Withdraw(amount);
            SelectedAtm.Deposit(amount);
        }

        public void Deposit(decimal amount)
        {
            if (SelectedAccount == null)
            {
                throw new Exception("Account not selected");
            }

            if (SelectedAtm == null)
            {
                throw new Exception("ATM not selected");
            }

            SelectedAccount.Deposit(amount);
            SelectedAtm.Deposit(amount);
        }

        public void Transaction(string cardNumber, decimal amount)
        {
            if (SelectedAccount == null)
            {
                throw new Exception("Account not selected");
            }

            if (SelectedAtm == null)
            {
                throw new Exception("ATM not selected");
            }

            var targetAccount = Accounts
                ?.Where(account => account.CardNumber == cardNumber)
                .FirstOrDefault();

            if (targetAccount == null)
            {
                throw new Exception("Account not found");
            }

            if (SelectedAccount.Balance < amount)
            {
                throw new Exception("Insufficient funds");
            }

            SelectedAccount.Withdraw(amount);
            targetAccount.Deposit(amount);
        }

        public void Exit()
        {
            SelectedAtm = null;
            SelectedAccount = null;
        }
    }
}
