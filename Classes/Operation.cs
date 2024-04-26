using System;

namespace CalculatR.Classes
{
    class Operation
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public Operation(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }
        public void CompareNumber(int firstNumber, int secondNumber)
        {
            if(firstNumber > secondNumber)
            {
                Console.WriteLine("first number is bigger than second number");
            }
            else if(firstNumber == secondNumber)
            {
                Console.WriteLine("first number is equal to second number");
            }
            else 
            {
                Console.WriteLine("first number is lower than second number");
            }
        }
        public void SwitchOperation(int firstNumber, int secondNumber, string operations)
        {
            switch(operations)
            {
                case "+" :
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                    break;
                case "-" :
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                    break;
                case "*" :
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    break;
                case "/" :
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    break;
                case "%" :
                    Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
                    break;
                default :
                    Console.WriteLine("Operation not found");
                    break;
            }
        }
    }
}