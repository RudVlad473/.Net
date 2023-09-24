using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class ATM : FinancialEntity, HasId
    {
        public string Id { get; private set; }
        public Address LocationAddress { get; private set; }

        // Constructor
        public ATM(Address locationAddress, decimal balance = 0)
        {
            Id = System.Guid.NewGuid().ToString();
            LocationAddress = locationAddress;
            Balance = balance;
        }
    }
}
