using System;

namespace CalculatR.Classes
{
    public class MagicMarket
    {
        public void ShowProductPrice()
        {
            Console.Write("Mahsulot nomini kiriting (olma, banan, anor, gilos): ");
            string? product = Console.ReadLine();

            int price = 0;

            switch (product)
            {
                case "olma":
                    price = 5000;
                    break;

                case "banan":
                    price = 8000;
                    break;

                case "anor":
                    price = 10000;
                    break;

                case "gilos":
                    price = 15000;
                    break;

                default:
                    price = -1;
                    break;
            }
            
            if (price > 0)
            {
                Console.WriteLine($"Narxi: {price} soʻm");
            }
            else
            {
                Console.WriteLine("#ERROR! Kechirasiz, bu mahsulot yoʻq");
            }
        }
    }
}