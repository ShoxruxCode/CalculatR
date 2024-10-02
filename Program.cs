using System;
using System.Collections.Generic;
using CalculatR.Classes;

namespace CalculatR
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            List<Database> cars = Database.GetCars();
            Console.WriteLine("Ikkita narx kiriting, shu narxlar oralig'idagi avtomobillar haqida ma'lumot olish uchun:");
            Console.Write("1-narx: ");
            int firstPrice = int.Parse(Console.ReadLine());
            Console.Write("2-narx: ");
            int secondPrice = int.Parse(Console.ReadLine());
            if(firstPrice >=0 && secondPrice >=0)
            {
                car.PrintEnteredPriceCars(cars, firstPrice, secondPrice);
            }
            else
            {
                Console.WriteLine("Notog'ri qiymat kiritildi.");
            }
        }
    }
}