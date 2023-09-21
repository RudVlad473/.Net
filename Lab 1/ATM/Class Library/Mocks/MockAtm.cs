using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Mocks
{
    public class MockAtm
    {
        public static List<ATM> GetMockAtm()
        {
            return new List<ATM>
            {
                new ATM(new Address("Oak St", "Model City"), 10000),
                new ATM(new Address("Elm St", "Sampletown"), 8000),
                new ATM(new Address("Main St", "Sampletown"), 5000),
                new ATM(new Address("Oak St", "Sampletown"), 2000),
                new ATM(new Address("Elm St", "Exampleville"), 3000),
                new ATM(new Address("Main St", "Exampleville"), 4000),
                new ATM(new Address("Oak St", "Model City"), 9000),
            };
        }
    }
}
