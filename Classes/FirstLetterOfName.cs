using System;

namespace CalculatR.Classes
{
    public class FirstLetterOfName
    {
        public void FirstLetterOfUserName()
        {
            Console.Write("Iltimos ismingizni kiriting: ");
            string name = Console.ReadLine();
            
            char[] firstLetter = name.ToCharArray();
            Console.WriteLine($"Ismingizning birinchi harfi: {firstLetter[0]}");
        }
    }
}