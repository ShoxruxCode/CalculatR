using System;

Console.Write("Enter first number: ");
string asFirstNumber = Console.ReadLine();
int firstNumber = Convert.ToInt32(asFirstNumber);
Console.Write("Enter second number: ");
string asSecondNumber = Console.ReadLine();
int secondNumber = Convert.ToInt32(asSecondNumber);

Console.WriteLine($"Adding: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
Console.WriteLine($"Substructing: {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
Console.WriteLine($"Multipling: {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
Console.WriteLine($"Deviding: {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
Console.WriteLine($"asDeviding: {firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
