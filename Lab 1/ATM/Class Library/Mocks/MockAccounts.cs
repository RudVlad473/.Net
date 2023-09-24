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
                new Account(
                    new Credentials("1111 1111 1111 1111", "1234"),
                    "John",
                    "Doe",
                    5000,
                    "andrejopa387@gmail.com"
                ),
                new Account(
                    new Credentials("2222 2222 2222 2222", "1234"),
                    "Alice",
                    "Smith",
                    3500,
                    "rudenkovladimir2003@gmail.com"
                ),
                new Account(
                    new Credentials("3333 3333 3333 3333", "1234"),
                    "Bob",
                    "Johnson",
                    10000,
                    "andrejopa387@gmail.com"
                ),
            };
        }
    }
}
