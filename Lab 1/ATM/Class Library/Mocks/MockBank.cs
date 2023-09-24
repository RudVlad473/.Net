using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    public static class MockBank
    {
        public static Bank GetMockBank()
        {
            var mockAtms = MockAtm.GetMockAtms();
            var mockAccounts = MockAccounts.GetMockAccounts();

            var bank = new Bank(mockAtms, mockAccounts);

            return bank;
        }
    }
}
