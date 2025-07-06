using System;

namespace CalculatR.Classes
{
    public class ChekLetter
    {
        public void ChekLetterUpperOrLower(string letter)
        {
            if (!string.IsNullOrEmpty(letter) && letter.Length == 1)
            {
                char inputChar = letter[0];
                if (inputChar >= 'A' && inputChar <= 'Z')
                {
                    Console.WriteLine("HA, bu katta harf.");
                }
                else if (inputChar >= 'a' && inputChar <= 'z')
                {
                    Console.WriteLine("YO‘Q, bu katta harf emas.");
                }
                else
                {
                    Console.WriteLine("Bu belgi harf emas.");
                }
            }
            else
            {
                Console.WriteLine("Xatolik: faqat bitta harf kiriting!");
            }
        }
    }
}