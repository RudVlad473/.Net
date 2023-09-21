using System.Text.RegularExpressions;

namespace Class_Library
{
    public class Account : FinancialEntity
    {
        // Properties
        public string CardNumber { get; set; }
        public string Pin { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public override decimal Balance { get; set; }
        public List<Option> Operations { get; set; } = new List<Option>();

        // Constructor
        public Account(
            string cardNumber,
            string ownerLastName,
            string ownerFirstName,
            decimal balance,
            string pin
        )
        {
            if (!ValidateCardNumber(cardNumber))
            {
                throw new Exception("Invalid card number");
            }
            CardNumber = cardNumber;
            OwnerLastName = ownerLastName;
            OwnerFirstName = ownerFirstName;
            Balance = balance;

            if (!ValidatePin(pin))
            {
                throw new Exception("Invalid PIN");
            }
            Pin = pin;
        }

        public Account()
        {
            CardNumber = "0000 0000 0000 0000";
            OwnerLastName = "Doe";
            OwnerFirstName = "John";
            Balance = 0;
            Pin = "0000";
        }

        public override bool Withdraw(decimal amount)
        {
            Operations.Add(new Option(OperationType.Withdrawal, amount));

            return base.Withdraw(amount);
        }

        public override void Deposit(decimal amount)
        {
            Operations.Add(new Option(OperationType.Deposit, amount));

            base.Deposit(amount);
        }

        public static bool ValidateCardNumber(string cardNumber)
        {
            // Define a regular expression pattern for the desired format "0000 0000 0000 0000"
            string pattern = @"^\d{4} \d{4} \d{4} \d{4}$";

            // Use Regex.IsMatch to check if the input matches the pattern
            if (Regex.IsMatch(cardNumber, pattern))
            {
                // Remove spaces and check if it's a valid numeric string
                string strippedNumber = cardNumber.Replace(" ", "");
                if (long.TryParse(strippedNumber, out long _))
                {
                    return true; // The card number is in the correct format and consists of digits.
                }
            }

            return false; // Invalid format or not a valid numeric string.
        }

        public static bool ValidatePin(string pin)
        {
            // Check if the input is exactly four digits and consists of numeric characters.
            if (pin.Length == 4 && pin.All(Char.IsDigit))
            {
                return true; // Valid 4-digit PIN.
            }

            return false; // Invalid format or not a valid numeric string with 4 digits.
        }
    }
}
