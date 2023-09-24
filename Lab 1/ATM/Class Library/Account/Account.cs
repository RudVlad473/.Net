using System.Text.RegularExpressions;

namespace Class_Library
{
    public class Account : FinancialEntity
    {
        // Properties
        public Credentials Credentials { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public List<Operation> Operations { get; set; } = new List<Operation>();

        // Constructor
        public Account(
            Credentials credentials,
            string ownerLastName,
            string ownerFirstName,
            decimal balance
        )
        {
            Credentials = credentials;
            OwnerLastName = ownerLastName;
            OwnerFirstName = ownerFirstName;
            Balance = balance;
        }

        public Account()
        {
            Credentials = new Credentials("0000 0000 0000 0000", "0000");
            OwnerLastName = "Doe";
            OwnerFirstName = "John";
            Balance = 0;
        }

        public override bool Withdraw(decimal amount)
        {
            Operations.Add(new Operation(OperationType.Withdraw, amount));

            return base.Withdraw(amount);
        }

        public override void Deposit(decimal amount)
        {
            Operations.Add(new Operation(OperationType.Deposit, amount));

            base.Deposit(amount);
        }
    }
}
