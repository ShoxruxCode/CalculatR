using System;
using CalculatR.Classes;
public class Program
{
    private static void Main(string[] args)
    {
        IntelligentRobot intelligentRobot = new IntelligentRobot();
        MagicMarket magicMarket = new MagicMarket();
        TrafficLight trafficLight = new TrafficLight();

        // 1-vazifa. Aqlli robot (switch expressions + ternary operator)
        Console.WriteLine("---1-vazifa---");
        intelligentRobot.SmartRobot();

        // 2-vazifa. Sehrli doʻkon (switch-case)
        Console.WriteLine("---2-vazifa---");
        magicMarket.ShowProductPrice();

        // 3-vazifa. Trafik yoritgich (ternary operator + logical AND(&&)/OR(||)
        Console.WriteLine("---3-vazifa---");
        trafficLight.CheckLight();
        trafficLight.CheckLight();
        trafficLight.CheckLight();
    }
}