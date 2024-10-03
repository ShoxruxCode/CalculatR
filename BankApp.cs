using System;
using CalculatR.Classes;
namespace CalculatR
{
    class BankApp
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            BankAccountNumber bankAccountNumber= new BankAccountNumber();
            Console.Write("1-Mijoz uchun hisob ochish\n2-Mijozning hisobini yopish\n3-Hisoblar o'rtasida pul o'tkazish\n4-Depozitni olish\n5-Pul yechib olish\n6-Balansni olish\n");
            Console.Write("Amallardan birini tanlang: ");
            int operation = int.Parse(Console.ReadLine());
            switch(operation)
            {
                case 1: bank.CreateAccountCustomer();
                break;
                case 2: bank.DeleteAccountCustomer();
                break;
                case 3: bank.TransferMoneyBetweenAccounts();
                break;
                case 4: bankAccountNumber.GetDeposit();
                break;
                case 5: bankAccountNumber.WithdrawMoney();
                break;
                case 6: bankAccountNumber.GetBalance();
                break;
                default: Console.WriteLine("Operation Not Found!");
                break;
            }
        }
    }
}