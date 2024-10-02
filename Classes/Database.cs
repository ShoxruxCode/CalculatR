using System.Collections.Generic;

namespace CalculatR.Classes
{
    public class Database
    {
        public string Name { get; set; }
        public string Marka { get; set; }
        public int Price { get; set; }
        public Database(string name, string marka, int price)
        {
            Name = name;
            Marka = marka;
            Price = price;
        }
        public static List<Database> GetCars()
        {
            return new List<Database>
            {
                new Database("Model S", "Tesla", 79999),
                new Database("Mustang", "Ford", 55999),
                new Database("Civic", "Honda", 23999),
                new Database("Camry", "Toyota", 24999),
                new Database("A6", "Audi", 45999),
                new Database("3 Series", "BMW", 40999),
                new Database("Corolla", "Toyota", 19999),
                new Database("Accord", "Honda", 27999),
                new Database("Charger", "Dodge", 29999),
                new Database("Challenger", "Dodge", 28999),
                new Database("F-150", "Ford", 49999),
                new Database("Altima", "Nissan", 24999),
                new Database("G-Class", "Mercedes-Benz", 130000),
                new Database("Model X", "Tesla", 89999),
                new Database("CX-5", "Mazda", 26999),
                new Database("Outlander", "Mitsubishi", 30999),
                new Database("E-Class", "Mercedes-Benz", 65999),
                new Database("Sierra", "GMC", 52999),
                new Database("Wrangler", "Jeep", 35999),
                new Database("Ram 1500", "Dodge", 43999),
                new Database("Escalade", "Cadillac", 89999),
                new Database("Cherokee", "Jeep", 34999),
                new Database("Tucson", "Hyundai", 25999),
                new Database("Soul", "Kia", 19999),
                new Database("K5", "Kia", 23999),
                new Database("XC90", "Volvo", 58999),
                new Database("Rav4", "Toyota", 30999),
                new Database("Model 3", "Tesla", 39999),
                new Database("Leaf", "Nissan", 31999),
                new Database("Santa Fe", "Hyundai", 31999)
            };
        }
    }
}