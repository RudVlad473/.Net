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
                new Account("1111 1111 1111 1111", "John", "Doe", 5000, "1234"),
                new Account("2222 2222 2222 2222", "Alice", "Smith", 3500, "1234"),
                new Account("3333 3333 3333 3333", "Bob", "Johnson", 10000, "1234"),
            };
        }
    }
}
