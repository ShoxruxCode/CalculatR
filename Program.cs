using System;
using System.Collections.Generic;
using CalculatR.Classes;

namespace CalculatR
{
    class Program
    {
        static void Main(string[] args)
        {
            Boxer boxer = new Boxer();
            List<Database> boxers = Database.GetBoxers();
            boxer.PrintEnteredAgeBoxers(boxers);
        }
    }
}