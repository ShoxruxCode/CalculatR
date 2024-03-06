using System;

Console.Write("Enter first number: ");
string asFirstNumber = Console.ReadLine();
int firstNumber = Convert.ToInt32(asFirstNumber);
Console.Write("Enter second number: ");
string asSecondNumber = Console.ReadLine();
int secondNumber = Convert.ToInt32(asSecondNumber);

Console.WriteLine($"first number is greater than second number: {firstNumber > secondNumber}");
Console.WriteLine($"first number is lower than second number: {firstNumber < secondNumber}");
Console.WriteLine($"first number is greater or equal to second number: {firstNumber >= secondNumber}");
Console.WriteLine($"first number is lower or equal to second number: {firstNumber <= secondNumber}");
Console.WriteLine($"first number is not equal to second number: {firstNumber != secondNumber}");
Console.WriteLine($"first number must be equal to second number: {firstNumber == secondNumber}");