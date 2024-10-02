using System.Collections.Generic;

namespace CalculatR.Classes
{
    public class Database
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public Database(int id, string name, string surName, int age, double weight)
        {
            Id = id;
            Name = name;
            SurName = surName;
            Age = age;
            Weight = weight;
        }
        public static List<Database> GetBoxers()
        {
            return new List<Database>
            {
                new Database(1, "Muhammad", "Ali", 74, 107.5),
                new Database(2, "Mike", "Tyson", 54, 100.2),
                new Database(3, "Floyd", "Mayweather", 44, 49.1),
                new Database(4, "Manny", "Pacquiao", 42, 66.2),
                new Database(5, "Evander", "Holyfield", 59, 97.5),
                new Database(6, "Lennox", "Lewis", 56, 115.0),
                new Database(7, "Vasyl", "Lomachenko", 33, 44.0),
                new Database(8, "Gennady", "Golovkin", 39, 72.5),
                new Database(9, "Anthony", "Joshua", 32, 108.9),
                new Database(10, "Tyson", "Fury", 33, 123.5),
                new Database(11, "Deontay", "Wilder", 36, 104.8),
                new Database(12, "Canelo", "Alvarez", 31, 79.4),
                new Database(13, "Joe", "Frazier", 67, 104.5),
                new Database(14, "Rocky", "Marciano", 45, 88.9),
                new Database(15, "George", "Foreman", 72, 110.4)
            };
        }
    }
}