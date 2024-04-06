using System;

Console.Write("Enter first number: ");
string asFirstNumber = Console.ReadLine();
int firstNumber = Convert.ToInt32(asFirstNumber);
Console.Write("Enter second number: ");
string asSecondNumber = Console.ReadLine();
int secondNumber = Convert.ToInt32(asSecondNumber);
if(firstNumber > secondNumber)
{
    Console.WriteLine("first number is bigger than second number");
} else if(firstNumber == secondNumber)
{
    Console.WriteLine("first number is equal to second number");
} else 
{
    Console.WriteLine("first number is lower than second number");
}
string message =
    firstNumber >= secondNumber 
        ? "first number is bigger than or equal to second number" 
        : "first number is lower than second number";
Console.WriteLine(message);