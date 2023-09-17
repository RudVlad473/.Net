using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public class MockAccounts
    {
        public static List<Account> GetMockAccounts()
        {
            return new List<Account>
                {
                    new Account("1", "John", "Doe", 5000, "1234"),
                    new Account("2", "Alice", "Smith", 3500, "1234"),
                    new Account("3", "Bob", "Johnson", 10000, "1234"),
                };
        }
    }
}
