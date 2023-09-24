using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace Class_Library
{
    public class Account : FinancialEntity
    {
        // Properties
        public Credentials Credentials { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public List<Operation> Operations { get; set; } = new List<Operation>();
        public string Email { get; set; }

        // Constructor
        public Account(
            Credentials credentials,
            string ownerLastName,
            string ownerFirstName,
            decimal balance,
            string email
        )
        {
            var emailValidator = new EmailAddressAttribute();
            if (!emailValidator.IsValid(email))
            {
                throw new Exception("Invalid email address");
            }
            Email = email;
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
            bool isEnoughMoney = base.Withdraw(amount);

            if (!isEnoughMoney)
            {
                return false;
            }

            Operations.Add(new Operation(OperationType.Withdraw, amount));

            return true;
        }

        public override void Deposit(decimal amount)
        {
            Operations.Add(new Operation(OperationType.Deposit, amount));

            base.Deposit(amount);
        }
    }
}
