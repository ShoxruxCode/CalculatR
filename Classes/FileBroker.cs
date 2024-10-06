using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace CalculatR.Classes
{
    public class FileBroker : IFileBroker
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public override string ToString()
        {
            return $"{Name}, {LastName}, {PhoneNumber}";
        }
        private readonly string filePath = "File/contacts.txt";
        private readonly ILoggerBroker logger;
        public FileBroker()
        {
            
        }
        public FileBroker(ILoggerBroker _logger)
        {
            logger = _logger;
        }

        public List<FileBroker> LoadContacts()
        {
            List<FileBroker> contacts = new List<FileBroker>();
            try
            {
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length == 3)
                        {
                            var contact = new FileBroker(logger)
                            {
                                Name = parts[0].Trim(),
                                LastName = parts[1].Trim(),
                                PhoneNumber = parts[2].Trim()
                            };
                            contacts.Add(contact);
                        }
                    }
                }
                else
                {
                    logger.LogFileNotFound(filePath);
                }
            }
            catch(Exception ex)
            {
                logger.LogFileAccessError(filePath, ex);
            }

            return contacts;
        }

        public void AddNewContact(List<FileBroker> contacts)
        {
            try
            {
                var lines = contacts.Select(p => p.ToString()).ToArray();
                File.WriteAllLines(filePath, lines);
            }
            catch(Exception ex)
            {
                logger.LogFileAccessError(filePath, ex);
            }
        }
        public void DeleteContact()
        {
            try
            {
                GetAllContacts();
                var contacts = LoadContacts();

                Console.Write("Kontakt ma'lumotlarini o'chirmoqchi bo'lgan shaxsning ismini kiriting: ");
                string name = Console.ReadLine();

                Console.Write("Kontakt ma'lumotlarini o'chirmoqchi bo'lgan shaxsning familiyasini kiriting: ");
                string lastName = Console.ReadLine();

                var contact = contacts.FirstOrDefault(c => c.Name == name && c.LastName == lastName);
                if (contact != null)
                {
                    contacts.Remove(contact);
                    AddNewContact(contacts);
                    Console.WriteLine("Kontakt muvaffaqiyatli o'chirildi.");
                }
                else
                {
                    logger.LogDataNotFound(name, lastName);
                    Console.WriteLine("Kontakt topilmadi.");
                }
            }
            catch(Exception ex)
            {
                logger.LogException(ex);
            }
        }
        public void EditContact()
        {
            try
            {
                GetAllContacts();
                var contacts = LoadContacts();

                Console.Write("Tahrir qilmoqchi bo'lgan shaxsning ismini kiriting: ");
                string name = Console.ReadLine();

                Console.Write("Tahrir qilmoqchi bo'lgan shaxsning familiyasini kiriting: ");
                string lastName = Console.ReadLine();

                var contact = contacts.FirstOrDefault(c => c.Name == name && c.LastName == lastName);

                if (contact != null)
                {
                    Console.Write("Yangi ismni kiriting: ");
                    contact.Name = Console.ReadLine();

                    Console.Write("Yangi familiyani kiriting: ");
                    contact.LastName = Console.ReadLine();

                    Console.Write("Yangi telefon raqamini kiriting: ");
                    contact.PhoneNumber = Console.ReadLine();

                    AddNewContact(contacts);
                    
                    Console.WriteLine("Kontakt muvaffaqiyatli tahrirlandi.");
                }
                else
                {
                    logger.LogDataNotFound(name, lastName);
                    Console.WriteLine("Kontakt topilmadi.");
                }
            }
            catch(Exception ex)
            {
                logger.LogException(ex);
            }
        }

        public void GetAllContacts()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);
                    foreach (var line in lines)
                    {
                        Console.WriteLine(line.Trim());
                    }
                }
                else
                {
                    logger.LogFileNotFound(filePath);
                    Console.WriteLine("Fayl topilmadi: " + filePath);
                } 
            }
            catch(Exception ex)
            {
                logger.LogException(ex);
            }
        }
        public void GetContactByNameAndLastName()
        {
            try
            {
                GetAllContacts();
                var contacts = LoadContacts();

                Console.Write("Kontakt ma'lumotlarini ko'rmoqchi bo'lgan shaxsning ismini kiriting: ");
                string name = Console.ReadLine();

                Console.Write("Kontakt ma'lumotlarini ko'rmoqchi bo'lgan shaxsning familiyasini kiriting: ");
                string lastName = Console.ReadLine();

                var contact = contacts.FirstOrDefault(c => c.Name == name && c.LastName == lastName);
                if (contact != null)
                {
                    Console.WriteLine("Kontakt topildi.");
                    Console.WriteLine($"{contact.Name}, {contact.LastName}, {contact.PhoneNumber}");
                    
                    string company = GetPhoneCompany(contact.PhoneNumber);
                    Console.WriteLine($"Bu shaxsning raqami {company} kompaniyasiga tegishli.");
                }
                else
                {
                    logger.LogDataNotFound(name, lastName);
                    Console.WriteLine("Kontakt topilmadi.");
                }
            }
            catch(Exception ex)
            {
                logger.LogException(ex);
            }
        }
        private string GetPhoneCompany(string phoneNumber)
        {
            if (phoneNumber.StartsWith("+99890"))
            {
                return "Beeline";
            }
            else if (phoneNumber.StartsWith("+99891"))
            {
                return "Beeline";
            }
            else if (phoneNumber.StartsWith("+99893"))
            {
                return "Ucell";
            }
            else if (phoneNumber.StartsWith("+99894"))
            {
                return "Ucell";
            }
            else if (phoneNumber.StartsWith("+99850"))
            {
                return "Ucell";
            }
            else if (phoneNumber.StartsWith("+99899"))
            {
                return "Uzmobile";
            }
            else if (phoneNumber.StartsWith("+99833"))
            {
                return "Humans";
            }
            else
            {
                return "Noma'lum kompaniya";
            }
        }
    }
}