using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatR.Classes
{
    class Car
    {
        private string name;
        private string marka;
        private int price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public void PrintEnteredPriceCars(List<Database> cars, int firstPrice, int secondPrice)
        {
            var filteredCars = cars.Where(s => s.Price >= firstPrice && s.Price <= secondPrice).ToList();
            if(filteredCars.Any())
            {
                Console.WriteLine($"{firstPrice} dollardan {secondPrice} dollargacha bo'lgan avtomobillar haqida ma'lumot:");
                foreach(var car in filteredCars)
                {
                    Console.WriteLine($"Mashina nomi {car.Name}, mashina markasi {car.Marka}, mashina narxi {car.Price} $");
                }
            }
        }
    }
}