using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class Bank
    {
        public string BankName { get; private set; }
        public List<ATM> ATMs { get; private set; }

        public Bank(string bankName)
        {
            BankName = bankName;
            ATMs = new List<ATM>();
        }

        public void AddATM(ATM atm)
        {
            bool ATMExists = ATMs.Find(currentAtm => currentAtm.Id == atm.Id) != null;

            if (ATMExists)
                return;

            ATMs.Add(atm);
        }

        public void RemoveATM(HasId atmId)
        {
            var atm = ATMs.Find(currentAtm => currentAtm.Id == atmId.Id);

            if (atm == null)
                return;

            ATMs.Remove(atm);
        }
    }
}
