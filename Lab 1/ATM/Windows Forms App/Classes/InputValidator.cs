using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_App.Classes
{
    public static class InputValidator
    {
        public static bool IsNumber(char input)
        {
            bool isControlKey = char.IsControl(input);
            bool isDigit = char.IsDigit(input);

            // Check if the pressed key is a numeric character or a control key (e.g., Backspace)
            if (!isControlKey && !isDigit)
            {
                return false;
            }

            return true;
        }
    }
}
