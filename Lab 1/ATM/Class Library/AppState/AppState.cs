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
        private Account? SelectedAccount { get; set; }
        private Bank? Bank { get; set; }
        public List<ATM>? Atms
        {
            get
            {
                if (Bank == null)
                {
                    return null;
                }

                return Bank.Atms.OrderByDescending(atm => atm.Balance).ToList();
            }
        }
        public List<Operation> Operations
        {
            get
            {
                return SelectedAccount.Operations
                    .OrderBy(operation => operation.Timestamp)
                    .ToList();
            }
        }

        private static readonly AppState _instance = new AppState();

        public static AppState Instance
        {
            get { return _instance; }
        }

        public Notification Notification { get; private set; }

        public void Initialize(Bank bank, Notification.Notify notify)
        {
            Bank = bank;

            this.Notification = new Notification(notify);
        }

        public string GetCardOwnerName()
        {
            if (SelectedAccount == null)
            {
                throw new Exception("Account not selected");
            }

            return SelectedAccount.OwnerFirstName + " " + SelectedAccount.OwnerLastName;
        }

        public bool IsCardSelected()
        {
            return SelectedAccount != null;
        }

        public void Authenticate(Credentials credentials)
        {
            var account = Bank?.Authenticate(credentials);

            if (account == null)
            {
                Notification.SendNotification(new Message("Not Found", "Account not found"));
            }

            SelectedAccount = account;

            Notification.SendNotification(
                new Message("Success", $"Authenticated as {GetCardOwnerName()}")
            );
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

            Notification.SendNotification(new Message("Success", $"Withdrawn {amount}"));
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

            Notification.SendNotification(new Message("Success", $"Deposited {amount}"));
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

            Notification.SendNotification(
                new Message("Success", $"Transaction {amount} to '{targetCardNumber}'")
            );
        }

        public void Balance()
        {
            Notification.SendNotification(
                new Message("Balance", $"Your balance is: {SelectedAccount?.Balance}")
            );
        }

        public void Exit()
        {
            SelectedAtm = null;
            SelectedAccount = null;
        }
    }
}
