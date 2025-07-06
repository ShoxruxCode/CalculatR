using System;

namespace CalculatR.Classes
{
    public class IntelligentRobot
    {
        public void SmartRobot()
        {
            Console.Write("Buyruq kiriting (yur, tushun, sakra, o‘giril): ");
            string? command = Console.ReadLine();

            string result = command switch
            {
                "yur" => "Robot yurmoqda!",
                "tushun" => "Robot tushunmoqda!",
                "sakra" => "Robot sakrayapti!",
                "o‘giril" => "Robot o‘girildi!",
                _ => "Nomaʼlum buyruq!"
            };

            string log = result != "Nomaʼlum buyruq!" 
                ? $"✅ {result}" 
                : $"#ERROR! {result}";

            Console.WriteLine(log);
        }
    }
}