using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Extensions
{
    public static class ArrayExtension
    {
        public static int CountValue<T>(this T[] arr, T value)
        {
            return arr.Count(x =>
            {
                bool isNullable = Nullable.GetUnderlyingType(typeof(T)) == null;

                if (isNullable && x == null)
                    return true;

                return x.Equals(value);
            });
        }

        public static T[] GetCopyWithUniqueValues<T>(this T[] arr)
        {
            return arr.Distinct().ToArray();
        }
    }
}
