using System;

namespace CalculatR.Classes
{
    public class PromptService
    {
        public void Questions()
        {
            Console.Write("Dasturlashni yoqtirasizmi? (Ha/H yoki Yo'q/Y deb kiriting): ");
            string firstQuestion = Console.ReadLine();
            string getFirstAnswer = QuestionAsker(firstQuestion);
            Console.WriteLine(getFirstAnswer);

            Console.Write("Matematikani yoqtirasizmi? (Ha/H yoki Yo'q/Y deb kiriting): ");
            string secondQuestion = Console.ReadLine();
            string getSecondAnswer = QuestionAsker(secondQuestion);
            Console.WriteLine(getSecondAnswer);

            Console.Write("Fizikani yoqtirasizmi? (Ha/H yoki Yo'q/Y deb kiriting): ");
            string thirdQuestion = Console.ReadLine();
            string getThirdAnswer = QuestionAsker(thirdQuestion);
            Console.WriteLine(getThirdAnswer);
        }

        public string QuestionAsker(string questionAsker)
        {
            return questionAsker switch
            {
                "Ha" or "H" => "Ajoyib!",
                "Yo'q" or "Y" => "Afsus!",
                _ => throw new ArgumentException("Noto‘g‘ri tanlov!")
            };
        }
    }
}