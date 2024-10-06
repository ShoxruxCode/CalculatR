using System;
using System.Collections.Generic;

namespace CalculatR.Classes
{
    public class PhoneBookService
    {
        private readonly FileBroker fileBroker;
        private readonly ILoggerBroker logger;
        public PhoneBookService(ILoggerBroker logger)
        {
            this.logger = logger;
            this.fileBroker = new FileBroker(logger);
        }

        public void GetAllMethodsFromFileBroker()
        {
            try
            {
                List<FileBroker> contacts = fileBroker.LoadContacts();

                Console.WriteLine("1-Kontakt qo'shish\n2-Kontaktni o'chirish\n3-Kontaktni tahrirlash\n4-Barcha kontaktlarni ko'rish\n5-Kontaktni nomi bo'yicha ko'rish");
                Console.Write("Amallardan birini tanlang: ");
                int operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        Console.Write("Kontaktga qo'shmoqchi bo'lgan shaxsning ismini kiriting: ");
                        string name = Console.ReadLine();

                        Console.Write("Kontaktga qo'shmoqchi bo'lgan shaxsning familiyasini kiriting: ");
                        string lastName = Console.ReadLine();

                        Console.Write("Kontaktga qo'shmoqchi bo'lgan shaxsning telefon raqamini kiriting: ");
                        string phoneNumber = Console.ReadLine();

                        contacts.Add(new FileBroker
                        {
                            Name = name,
                            LastName = lastName,
                            PhoneNumber = phoneNumber
                        });

                        fileBroker.AddNewContact(contacts);
                        Console.WriteLine("Kontakt muvaffaqiyatli qo'shildi.");
                        break;
                    case 2:
                        fileBroker.DeleteContact();
                        break;
                    case 3:
                        fileBroker.EditContact();
                        break;
                    case 4:
                        fileBroker.GetAllContacts();
                        break;
                    case 5:
                        fileBroker.GetContactByNameAndLastName();
                        break;
                    default:
                        Console.WriteLine("Noto'g'ri amal tanlandi."); 
                        logger.LogGeneralError("Noto'g'ri amal tanlandi.");
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Xato: Kiritilgan ma'lumot noto'g'ri formatda.");
                logger.LogException(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xatolik yuz berdi: " + ex.Message);
                logger.LogException(ex);
            }
        }
    }
}