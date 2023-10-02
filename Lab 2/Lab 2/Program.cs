using ConsoleTables;
using Lab_2.LinqToObjects.Classes;
using static System.Console;

String[] A = { "Falluot 3", "Daxter 2", "System Shok 2", "Morrowind", "Pes 2013" };
int[] B = { 2, -7, -10, 6, 7, 9, 3 };
String[] C =
{
    "Light Green",
    "Red",
    "Green",
    "Yellow",
    "Purple",
    "Dark Green",
    "Light Red",
    "Dark Red",
    "Dark Yellow",
    "Light Yellow"
};

var manufacturers = new List<string>() { "Yugo", "Aztec", "BMW", "Saab" };

// 1.1

var onlyNumbers = App.FindStringsWithDigits(A);

WriteLine("Only numbers\n");
WriteLine(string.Join(", ", onlyNumbers.ToList()));

WriteLine();

// 1.2

var onlyPositiveNumbers = App.FindPositiveNumbers(B);

WriteLine("Only positive numbers\n");
WriteLine(string.Join(", ", onlyPositiveNumbers.ToList()));

WriteLine();

// 1.3

var shadesOfRed = App.FindShadesOfRed(C);

WriteLine("Shades of red\n");
WriteLine(string.Join(", ", shadesOfRed.ToList()));

WriteLine();

//

var random = new Random();

var cars = C.Select(
        color =>
            new Car(
                random.Next(50, 501),
                color,
                manufacturers[random.Next(0, manufacturers.Count)],
                random.Next(2, 4)
            )
    )
    .ToList();

// 1.4

var fastCars = App.FindFastCars(cars);

WriteLine("Fast cars\n");
WriteLine(String.Join("\n", fastCars));

WriteLine();

//

var products = new List<Product>()
{
    new Product("Laptop", 2, "A cool laptop"),
    new Product("Phone", 500, "A cool phone"),
    new Product("PC", 15, "A cool PC"),
    new Product("Tablet", 80, "A cool tablet"),
    new Product("TV", 2000, "A cool TV"),
    new Product("Headphones", 100, "A cool headphones"),
    new Product("Keyboard", 50, "A cool keyboard"),
    new Product("Mouse", 30, "A cool mouse"),
};

//1.5

var productsWithStockQuantityMoreThan50 = App.FindProductsWithBigStock(products);

WriteLine("Products with stock quantity more than 50");
WriteLine(string.Join("\n", productsWithStockQuantityMoreThan50.ToList()));

WriteLine();

//1.6

List<string> myCars = new List<String> { "Yugo", "Aztec", "BMW" };
List<string> yourCars = new List<String> { "BMW", "Saab", "Aztec" };

var carIntersect = App.FindUnique(myCars, yourCars);

WriteLine("Unique car brands");
WriteLine(string.Join("\n", carIntersect.ToList()));
