using System;
using CalculatR.Classes;
public class Program
{
    private static void Main(string[] args)
    {
        ChekLetter chekLetter = new ChekLetter();
        PromptService promptService = new PromptService();
        FirstLetterOfName firstLetterOfName = new FirstLetterOfName();

        // 1-vazifa. Katta harf tekshiruvi (Char & Bool)
        Console.WriteLine("---1-vazifa---");
        Console.Write("Iltimos bitta harf kiriting: ");
        string inputLetter = Console.ReadLine();

        chekLetter.ChekLetterUpperOrLower(inputLetter);

        // 2-vazifa. Ha/yoʻq javobini berish (Bool)
        Console.WriteLine("---2-vazifa---");
        promptService.Questions();

        // 3-vazifa. Ismdagi birinchi harf (String & Char)
        Console.WriteLine("---2-vazifa---");
        firstLetterOfName.FirstLetterOfUserName();
    }
}