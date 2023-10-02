using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.LinqToObjects.Classes
{
    public static class App
    {
        public static string[] FindStringsWithDigits(string[] strings)
        {
            return strings.Where(x => x.Any(Char.IsDigit)).ToArray();
        }

        public static int[] FindPositiveNumbers(int[] numbers)
        {
            return numbers.Where(x => x > 0).ToArray();
        }

        public static string[] FindShadesOfRed(string[] colors)
        {
            return colors.Where(x => x.Contains("Red")).ToArray();
        }

        public static List<Car> FindFastCars(List<Car> cars)
        {
            return cars.Where(x => x.MaxSpeed > 200).ToList();
        }

        public static List<Product> FindProductsWithBigStock(List<Product> products)
        {
            return products.Where(x => x.StockQuantity > 50).ToList();
        }

        public static List<string> FindUnique(List<string> list1, List<string> list2)
        {
            return list1.Concat(list2).Distinct().ToList();
        }
    }
}
