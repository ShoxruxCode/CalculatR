using System;
using System.Collections.Generic;

namespace CalculatR.Classes
{
    public class Bank
    {
        public Bank()
        {

        }
        Customer customerObject = new Customer();
        List<Customer> customers = Customer.GetCustomers();
        BankAccountNumber bankAccountNumber = new BankAccountNumber();
        public void CreateAccountCustomer()
        {
            string wordYesOrNot;
            do
            {
                Console.Write("Mijoz va hisob yaratmoqchimisiz (ha yoki yo'q amalini kiriting) : ");
                wordYesOrNot = Console.ReadLine().ToLower();
                if(wordYesOrNot == "ha")
                {
                    Console.Write("Eslatma hisob raqam 27 ta raqamdan iborat bo'lishi kerak.\nNamuna: 4008 1086 0262 6670 9410 0078 022\nMijoz hisob raqamini kiriting: ");
                    string customerAccount = Console.ReadLine();
                    Console.Write("Mijoz ismini kiriting: ");
                    string name = Console.ReadLine();
                    Console.Write("Mijoz familiyasini kiriting: ");
                    string surname = Console.ReadLine();
                    Console.Write("Mijoz hisobiga qancha miqdorda pul o'tkazmoqchisiz (dollarda/$): ");
                    decimal customerBalance;
                    do
                    {
                        customerBalance = decimal.Parse(Console.ReadLine());
                        bankAccountNumber.BankBalance -= customerBalance;
                        if(customerBalance < 0 || customerBalance > bankAccountNumber.BankBalance)
                        {
                            Console.WriteLine($"Noto'g'ri qiymat kiritildi, qiymat 0 $ dan {bankAccountNumber.BankBalance} $ gacha kiritilishi kerak");
                        }
                    }while(customerBalance < 0 || customerBalance > bankAccountNumber.BankBalance);
                    Customer newCustomer = new Customer(customerAccount, name, surname, customerBalance);
                    customers.Add(newCustomer);
                }
            }while(wordYesOrNot != "yo'q");
            Console.WriteLine($"Bank balansi {bankAccountNumber.BankBalance} $");
            foreach(var customer in customers)
            {
                Console.WriteLine($"Mijozning ism familiyasi {customer.Name} {customer.SurName}, mijozning hisobidagi pul mablag'lari {customer.CustomerBalance} $");
            }
        }
        public void DeleteAccountCustomer()
        {
            Console.WriteLine($"Bank balansi {bankAccountNumber.BankBalance} $");
            foreach(var customer in customers)
            {
                Console.WriteLine($"Mijozning ism familiyasi {customer.Name} {customer.SurName}, mijozning hisob raqami {customer.CustomerAccount} $");
            }
            string wordYesOrNot;
            do
            {
                Console.Write("Biron bir mijozning hisobini yopishni xohlaysizmi? (ha yoki yo'q amalini kiriting): ");
                wordYesOrNot = Console.ReadLine().ToLower();
                if(wordYesOrNot == "ha")
                {
                    Console.Write("O'chirmoqchi bo'lgan mijoz hisob raqamini kiriting: ");
                    string customerAccount = Console.ReadLine();

                    Customer customerToDelete = customers.Find(c => c.CustomerAccount == customerAccount);

                    if (customerToDelete != null)
                    {
                        customers.Remove(customerToDelete);
                        Console.WriteLine($"{customerToDelete.Name} {customerToDelete.SurName} ismli mijozning hisobi muvaffaqiyatli o'chirildi.");
                    }
                    else
                    {
                        Console.WriteLine("Bunday hisob raqamiga ega mijoz topilmadi.");
                    }
                }
            }while(wordYesOrNot != "yo'q");
        }
        public void TransferMoneyBetweenAccounts()
        {
            Console.WriteLine($"Bank balansi {bankAccountNumber.BankBalance} $");
            foreach(var customer in customers)
            {
                Console.WriteLine($"Mijozning ism familiyasi {customer.Name} {customer.SurName}, mijozning hisob raqami {customer.CustomerAccount}, mijozning hisobidagi pul mablag'lari {customer.CustomerBalance} $");
            }
            string wordYesOrNot;
            do
            {
                Console.Write("Pul o'tkazmasini amalga oshirmoqchimisiz (ha yoki yo'q amalini kiriting): ");
                wordYesOrNot = Console.ReadLine().ToLower();

                if (wordYesOrNot == "ha")
                {
                    Console.Write("Pul o'tkazmoqchi bo'lgan mijozning hisob raqamini kiriting: ");
                    string senderAccount = Console.ReadLine();

                    Console.Write("Pul qabul qiluvchi mijozning hisob raqamini kiriting: ");
                    string receiverAccount = Console.ReadLine();

                    Customer sender = customers.Find(c => c.CustomerAccount == senderAccount);
                    Customer receiver = customers.Find(c => c.CustomerAccount == receiverAccount);

                    if (sender != null && receiver != null)
                    {
                        Console.WriteLine($"Yuboruvchining hozirgi balansi: {sender.CustomerBalance}$");
                        Console.WriteLine($"Qabul qiluvchining hozirgi balansi: {receiver.CustomerBalance}$");
                        Console.Write($"Qancha miqdorda pul o'tkazmoqchisiz: ");
                        decimal transferAmount = decimal.Parse(Console.ReadLine());

                        if (sender.CustomerBalance >= transferAmount)
                        {
                            sender.CustomerBalance -= transferAmount;
                            receiver.CustomerBalance += transferAmount;

                            Console.WriteLine($"{transferAmount}$ miqdorida pul muvaffaqiyatli o'tkazildi.");
                            Console.WriteLine($"{sender.Name} {sender.SurName} yangi balans: {sender.CustomerBalance}$");
                            Console.WriteLine($"{receiver.Name} {receiver.SurName} yangi balans: {receiver.CustomerBalance}$");
                        }
                        else
                        {
                            Console.WriteLine("Balans yetarli emas.");
                        }
                    }
                    else
                    {
                        if (sender == null) Console.WriteLine("Pul o'tkazuvchi mijoz topilmadi.");
                        if (receiver == null) Console.WriteLine("Pul qabul qiluvchi mijoz topilmadi.");
                    }
                }
            }while (wordYesOrNot != "yo'q");
        }
    }
}