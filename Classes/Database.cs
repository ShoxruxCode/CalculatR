using System.Collections.Generic;
using CalculatR.Enums;

namespace CalculatR.Classes
{
    public class Database
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Classes { get; set; }
        public StudentType Grades { get; set; }
        public Database(int id, string name, string surName, int classes, int grades)
        {
            Id = id;
            Name = name;
            SurName = surName;
            Classes = classes;
            Grades = (StudentType)grades;
        }
        public static List<Database> GetStudents()
        {
            return new List<Database>
            {
                new Database(1, "Ali", "Karimov", 6, 0),
                new Database(2, "Vali", "Saidov", 6, 0),
                new Database(3, "Sami", "Murodov", 6, 0),
                new Database(4, "Guli", "Abdulayeva", 7, 0),
                new Database(5, "Zebo", "Qodirova", 7, 0),
                new Database(6, "Madina", "Rustamova", 7, 1),
                new Database(7, "Bekzod", "Rahmonov", 7, 1),
                new Database(8, "Shahzod", "Usmonov", 7, 1),
                new Database(9, "Dilnoza", "Bekmurodova", 8, 1),
                new Database(10, "Jasur", "Bozorov", 8, 1),
                new Database(11, "Otabek", "Yusupov", 8, 2),
                new Database(12, "Nigina", "Raxmatullaeva", 8, 2),
                new Database(13, "Xurshid", "Tojiev", 8, 2),
                new Database(14, "Malika", "Ismoilova", 9, 2),
                new Database(15, "Aziz", "Xudoyberdiev", 9, 2),
                new Database(16, "Omon", "Mamurov", 9, 3),
                new Database(17, "Nodira", "Salimova", 9, 3),
                new Database(18, "Shoxrux", "Odilov", 9, 3),
                new Database(19, "Zilola", "Saydullaeva", 10, 3),
                new Database(20, "Farrux", "Tursunov", 10, 3),
                new Database(21, "Diyor", "Jumaboev", 10, 4),
                new Database(22, "Aziza", "Shermurodova", 10, 4),
                new Database(23, "Begzod", "Holikov", 10, 4),
                new Database(24, "Dilshod", "Rahimov", 11, 4),
                new Database(25, "Shahlo", "Mamatova", 11, 4),
                new Database(26, "Timur", "Axmedov", 11, 5),
                new Database(27, "Olim", "Sobirov", 11, 5),
                new Database(28, "Saida", "Narzullaeva", 11, 5),
                new Database(29, "Javohir", "Xolmatov", 6, 5),
                new Database(30, "Sardor", "Aliev", 6, 5)
            }; 
        }
    }
}