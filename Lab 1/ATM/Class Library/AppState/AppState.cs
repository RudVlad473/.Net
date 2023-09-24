using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_Library;

namespace Class_Library
{
    public class AppState
    {
        public ATM? SelectedAtm { get; private set; }
        public Account? SelectedAccount { get; private set; }
        private Bank? Bank { get; set; }
        public List<ATM>? Atms
        {
            get
            {
                if (Bank == null)
                {
                    return null;
                }

                return Bank.Atms;
            }
        }

        public delegate void Notify(IMessage message);

        private Notify notify;

        private static readonly AppState _instance = new AppState();

        public static AppState Instance
        {
            get { return _instance; }
        }

        public void AddNotify(Notify notify)
        {
            this.notify += notify;
        }

        public void SendNotification(IMessage message)
        {
            notify.Invoke(message);
        }

        public void Initialize(Bank bank, Notify notify)
        {
            Bank = bank;

            AddNotify(notify);
        }

        public void Authenticate(Credentials credentials)
        {
            var account = Bank?.Authenticate(credentials);

            if (account == null)
            {
                SendNotification(new Message("Not Found", "Account not found"));
            }

            SelectedAccount = account;
        }

        public void SelectAtm(string atmId)
        {
            var atm = Bank?.Atms?.Where(atm => atm.Id == atmId).FirstOrDefault();

            if (atm == null)
            {
                throw new Exception("ATM not found");
            }

            SelectedAtm = atm;
        }

        public void SelectAccount(Credentials credentials)
        {
            var account = Bank?.Authenticate(credentials);

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

            var nearestAtms = Bank.Atms
                ?.Where(atm =>
                {
                    bool isSameAtm = atm.Id == SelectedAtm.Id;

                    if (isSameAtm)
                    {
                        return false;
                    }

                    return SelectedAtm.LocationAddress.IsNear(atm.LocationAddress);
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

            bool isEnoughMoney = SelectedAccount.Withdraw(amount);

            if (!isEnoughMoney)
            {
                throw new Exception("Not enough money");
            }
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

        public void Transaction(string targetCardNumber, decimal amount)
        {
            if (SelectedAccount == null)
            {
                throw new Exception("Account not selected");
            }

            if (SelectedAtm == null)
            {
                throw new Exception("ATM not selected");
            }

            Bank.Transaction(SelectedAccount, targetCardNumber, amount);
        }

        public void Exit()
        {
            SelectedAtm = null;
            SelectedAccount = null;
        }
    }
}
