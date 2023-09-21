using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public enum OperationType
    {
        Deposit,
        Withdrawal,
        Transaction
    }

    public class Option
    {
        public DateTime Timestamp { get; private set; }
        public OperationType Type { get; private set; }
        public decimal Payload { get; private set; }

        public Option(OperationType type, decimal payload)
        {
            Timestamp = DateTime.Now;
            Type = type;
            Payload = payload;
        }
    }
}
