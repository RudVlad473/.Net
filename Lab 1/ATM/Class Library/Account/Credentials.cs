using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Class_Library
{
    public class Credentials : IComparable<Credentials>
    {
        public string CardNumber { get; set; }
        private string Pin { get; set; }

        public Credentials(string cardNumber, string pin)
        {
            if (!ValidateCredentials(cardNumber, pin))
            {
                throw new Exception("Invalid credentials");
            }

            CardNumber = cardNumber;
            Pin = pin;
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

        public bool ValidateCredentials(string cardNumber, string pin)
        {
            return ValidateCardNumber(cardNumber) && ValidatePin(pin);
        }

        public int CompareTo(Credentials? other)
        {
            if (other == null)
            {
                return 1;
            }

            var cardNumberMatches = CardNumber == other.CardNumber;
            var pinMatches = Pin == other.Pin;

            if (cardNumberMatches && pinMatches)
            {
                return 0;
            }

            return -1;
        }
    }
}
