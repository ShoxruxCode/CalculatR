using System;

namespace CalculatR.Classes
{
    public class TrafficLight
    {
        private string? lastColor = null;

        public void CheckLight()
        {
            Console.Write("Rang kiriting (qizil, sariq, yashil): ");
            string? currentColor = Console.ReadLine();

            string action = currentColor == "qizil" ? "To‘xtang!"
                          : currentColor == "sariq" ? "Tayyorlaning!"
                          : currentColor == "yashil" ? "Yuring!"
                          : "Nomaʼlum rang!";

            if (currentColor == "yashil" && lastColor == "yashil")
            {
                action = "Tez yurmayman!";
            }

            Console.WriteLine(action);

            lastColor = currentColor;
        }
    }
}