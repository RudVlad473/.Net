using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Utils
{
    public static class TextFormatter
    {
        public static string SplitCamelCase(string input)
        {
            return string.Concat(input.Select(x => Char.IsUpper(x) ? " " + x : x.ToString()))
                .TrimStart(' ');
        }

        public static string UnsplitCamelCase(string input)
        {
            return input.Replace(" ", "");
        }
    }
}
