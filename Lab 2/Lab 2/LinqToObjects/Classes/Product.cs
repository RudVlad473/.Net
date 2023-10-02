using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.LinqToObjects.Classes
{
    public class Product
    {
        public string Name { get; set; } // Назва продукта
        public int StockQuantity { get; set; } // Кількість упаковок на складі
        public string Description { get; set; } // Опис продукта

        // Конструктор класу Product
        public Product(string name, int stockQuantity, string description)
        {
            Name = name;
            StockQuantity = stockQuantity;
            Description = description;
        }

        // Перевизначений метод ToString()

        public override string ToString()
        {
            return $"Name: {Name}, Stock quantity: {StockQuantity}, Description: {Description}";
        }
    }
}
