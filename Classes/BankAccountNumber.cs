using System;
using System.Collections.Generic;

namespace CalculatR.Classes
{
    public class BankAccountNumber
    {
        private string accountNumber;
        private decimal bankBalance;
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public decimal BankBalance
        {
            get { return bankBalance; }
            set { bankBalance = value; }
        }
        public BankAccountNumber()
        {
            AccountNumber = "4001 1086 0262 6670 9410 0078 001";
            BankBalance = 1_000_000_000;
        }
        public BankAccountNumber(string accountNumber, decimal bankBalance)
        {
            AccountNumber = accountNumber;
            BankBalance = bankBalance;
        }
        List<Customer> customers = Customer.GetCustomers();
        public void GetDeposit()
        {
            Console.WriteLine($"Bankning balansi {BankBalance} $");
            foreach(var customer in customers)
            {
                Console.WriteLine($"Mijozning ism familiyasi {customer.Name} {customer.SurName}, mijozning balansi: {customer.CustomerBalance} $");
            }
            string wordYesOrNot;
            decimal totalDeposit = 0;
            do
            {
                Console.Write("Barcha mijozlardan depozit (foiz) olishni xohlaysizmi? (ha yoki yo'q amalini kiriting): ");
                wordYesOrNot = Console.ReadLine().ToLower();

                if (wordYesOrNot == "ha")
                {
                    decimal depositPercentage;
                    do
                    {
                        Console.Write("Depozit olish uchun foizni kiriting (1% dan 100% gacha): ");
                        depositPercentage = decimal.Parse(Console.ReadLine());

                        if (depositPercentage < 1 || depositPercentage > 100)
                        {
                            Console.WriteLine("Noto'g'ri foiz kiritildi. 1% dan 100% gacha foiz kiriting.");
                        }

                    } while (depositPercentage < 1 || depositPercentage > 100);

                    for (int iteration = 0; iteration < customers.Count; iteration++)
                    {
                        decimal depositAmount = customers[iteration].CustomerBalance * (depositPercentage / 100);
                        customers[iteration].CustomerBalance -= depositAmount;
                        totalDeposit += depositAmount;

                        Console.WriteLine($"{customers[iteration].Name} {customers[iteration].SurName} ismli mijozning balansidan {depositAmount}$ yechildi. Yangi balans: {customers[iteration].CustomerBalance}$");
                    }

                    BankBalance += totalDeposit;
                }
            } while (wordYesOrNot != "yo'q");
            Console.WriteLine($"Umumiy {totalDeposit}$ miqdoridagi depozit bank balansiga qo'shildi. Bankning yangi balansi: {BankBalance}$");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine($"Bankning balansi {BankBalance} $");
            foreach(var customer in customers)
            {
                Console.WriteLine($"Mijozning ism familiyasi {customer.Name} {customer.SurName}, mijozning hisob raqami {customer.CustomerAccount}, mijozning hisobidagi pul mablag'lari {customer.CustomerBalance} $");
            }
            string wordYesOrNot;
            do
            {
                Console.Write("Biron bir mijozning hisobidan pul yechib olmoqchimisiz (ha yoki yo'q amalini kiriting) : ");
                wordYesOrNot = Console.ReadLine().ToLower();
                if(wordYesOrNot == "ha")
                {
                    Console.Write("Pul yechib olmoqchi bo'lgan mijozning hisob raqamini kiriting: ");
                    string customerAccount = Console.ReadLine();
                    Customer customerToWithdrawMoney = customers.Find(c => c.CustomerAccount == customerAccount);
                    if (customerToWithdrawMoney != null)
                    {
                        decimal enteredBalance;
                        do
                        {
                            Console.Write("Pul yechib olmoqchi bo'lgan summangizni kiriting (dollarda/$): ");
                            enteredBalance = decimal.Parse(Console.ReadLine());
                            if (enteredBalance < 1 || enteredBalance > customerToWithdrawMoney.CustomerBalance)
                            {
                                Console.WriteLine($"Noto'g'ri foiz qiymat. 1 $ dan {customerToWithdrawMoney.CustomerBalance} $ gacha qiymat kiriting.");
                            }
                            
                        }while(enteredBalance < 1 || enteredBalance > customerToWithdrawMoney.CustomerBalance);
                        customerToWithdrawMoney.CustomerBalance -= enteredBalance;
                        BankBalance += enteredBalance;
                        Console.WriteLine($"{customerToWithdrawMoney.Name} {customerToWithdrawMoney.SurName} ismli mijozning balansidan {enteredBalance}$ yechildi. Yangi balans: {customerToWithdrawMoney.CustomerBalance}$");
                        Console.WriteLine($"Umumiy {enteredBalance}$ miqdoridagi pul mablag'i bank balansiga qo'shildi. Bankning yangi balansi: {BankBalance}$");
                    }
                    else
                    {
                        Console.WriteLine("Bunday hisob raqamiga ega mijoz topilmadi.");
                    }
                }
            }while(wordYesOrNot != "yo'q");
        }
        public void GetBalance()
        {
            Console.WriteLine($"Bankning balansi {BankBalance} $");
            Console.WriteLine("Barcha mijozlarning balansidagi pul mablag'lari:");
            foreach(var customer in customers)
            {
                Console.WriteLine($"Mijozning ism familiyasi {customer.Name} {customer.SurName}, mijozning hisobidagi pul mablag'lari {customer.CustomerBalance} $");
            }
        }
    }
}