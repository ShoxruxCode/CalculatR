using System;
using CalculatR.Classes;

namespace CalculatR
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            string asFirstNumber = Console.ReadLine();
            int firstNumber = Convert.ToInt32(asFirstNumber);
            Console.Write("Enter second number: ");
            string asSecondNumber = Console.ReadLine();
            int secondNumber = Convert.ToInt32(asSecondNumber);
            Console.Write("Enter operations (+, -, *, /, %) : ");
            string operations = Console.ReadLine();

            Operation arithmetic = new Operation(firstNumber, secondNumber);
            
            arithmetic.CompareNumber(firstNumber, secondNumber);
            arithmetic.SwitchOperation(firstNumber, secondNumber, operations);
        }
    }
}