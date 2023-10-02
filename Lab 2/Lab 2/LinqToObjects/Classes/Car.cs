using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.LinqToObjects.Classes
{
    public class Car
    {
        // Властивості класу Car
        public int MaxSpeed { get; set; } // Максимальна швидкість
        public string Color { get; set; } // Колір
        public string Manufacturer { get; set; } // Виробник
        public int PassengerCount { get; set; } // Кількість пасажирів

        // Конструктор класу Car
        public Car(int maxSpeed, string color, string manufacturer, int passengerCount)
        {
            MaxSpeed = maxSpeed;
            Color = color;
            Manufacturer = manufacturer;
            PassengerCount = passengerCount;
        }

        // Перевизначений метод ToString()

        public override string ToString()
        {
            return $"Max speed: {MaxSpeed}, Color: {Color}, Manufacturer: {Manufacturer}, Passenger count: {PassengerCount}";
        }
    }
}
