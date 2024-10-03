using System;
using System.Collections.Generic;

namespace CalculatR.Classes
{
    class Customer
    {
        public string CustomerAccount { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public decimal CustomerBalance { get; set; }
        public Customer(string customerAccount, string name, string surname, decimal customerBalance)
        {
            CustomerAccount = customerAccount;
            Name = name;
            SurName = surname;
            CustomerBalance = customerBalance;
        }

        public Customer()
        {

        }
        public static List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer("4008 1086 0262 6670 9410 0078 008", "Bekzod", "Rahmonov", 79999),
                new Customer("4008 1086 0262 6670 9410 0078 009", "Shahzod", "Usmonov", 55999),
                new Customer("4008 1086 0262 6670 9410 0078 010", "Jasur", "Bozorov", 24999),
                new Customer("4008 1086 0262 6670 9410 0078 011", "Otabek", "Yusupov", 45999),
                new Customer("4008 1086 0262 6670 9410 0078 012", "Xurshid", "Tojiev", 40999),
                new Customer("4008 1086 0262 6670 9410 0078 013", "Aziz", "Xudoyberdiev", 28999),
                new Customer("4008 1086 0262 6670 9410 0078 014", "Omon", "Mamurov", 130000),
                new Customer("4008 1086 0262 6670 9410 0078 015", "Shoxrux", "Odilov", 30999),
                new Customer("4008 1086 0262 6670 9410 0078 016", "Farrux", "Tursunov", 65999),
                new Customer("4008 1086 0262 6670 9410 0078 017", "Diyor", "Jumaboev", 52999),
                new Customer("4008 1086 0262 6670 9410 0078 018", "Begzod", "Holikov", 35999),
                new Customer("4008 1086 0262 6670 9410 0078 019", "Dilshod", "Rahimov", 34999),
                new Customer("4008 1086 0262 6670 9410 0078 020", "Timur", "Axmedov", 25999),
                new Customer("4008 1086 0262 6670 9410 0078 021", "Olim", "Sobirov", 19999),
                new Customer("4008 1086 0262 6670 9410 0078 022", "Javohir", "Xolmatov", 23999)
            };
        }
    }
}