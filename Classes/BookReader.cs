using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace CalculatR.Classes
{
    public class BookReader : IBookReader
    {
        public int UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public int UserAge { get; set; }
        public int UserGetBooksCount { get; set; }
        public List<string> UserGetBooks { get; set; }
        public BookReader()
        {

        }
        public override string ToString()
        {
            string books = string.Join(",", UserGetBooks);
            return $"{UserId}, {UserLogin}, {UserPassword}, {UserName}, {UserLastName}, {UserAge}, {UserGetBooksCount}, {books}";
        }
        public readonly string usersFilePath = "File/users.txt";
        private readonly ILoggerBroker logger;
        public BookReader(ILoggerBroker _logger)
        {
            logger = _logger;
        }
        public List<BookReader> LoadBookReaders()
        {
            List<BookReader> users = new List<BookReader>();
            try
            {
                if (File.Exists(usersFilePath))
                {
                    var lines = File.ReadAllLines(usersFilePath);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length >= 8)
                        {
                            int userGetBooksCount = int.Parse(parts[6].Trim());
                            var books = parts.Skip(7).Take(userGetBooksCount).ToList();
                            var user = new BookReader(logger)
                            {
                                UserId = int.Parse(parts[0].Trim()),
                                UserLogin = parts[1].Trim(),
                                UserPassword = parts[2].Trim(),
                                UserName = parts[3].Trim(),
                                UserLastName = parts[4].Trim(),
                                UserAge = int.Parse(parts[5].Trim()),
                                UserGetBooksCount = userGetBooksCount,
                                UserGetBooks = books
                            };
                            users.Add(user);
                        }
                    }
                }
                else
                {
                    logger.LogFileNotFound(usersFilePath);
                }
            }
            catch(Exception ex)
            {
                logger.LogFileAccessError(usersFilePath, ex);
            }

            return users;
        }
        public void CheckUser()
        {
            try
            {
                var users = LoadBookReaders();
                Console.Write("Kutubxona tizimiga kirish uchun loginingizni kiriting: ");
                string login = Console.ReadLine();

                Console.Write("Kutubxona tizimiga kirish uchun parolingizni kiriting: ");
                string password = Console.ReadLine();

                var user = users.FirstOrDefault(c => c.UserLogin == login && c.UserPassword == password);
                if(user != null)
                {
                    Console.WriteLine("Siz tizimga muvaffaqiyatli kirdingiz.");
                }
                else
                {
                    CreateUser();
                }
            }
            catch(Exception ex)
            {
                logger.LogException(ex);
            }
        }
        public void CreateUser()
        {
            try
            {
                var users = LoadBookReaders();
                Console.WriteLine("User Not Found!");
                Console.WriteLine("Sizning ma'lumotlaringiz kutubxona tizimidan topilmadi, shuning uchun registratsiyadan o'ting.");
                Console.Write("Kutubxona tizimiga kirish uchun ismingizni kiriting: ");
                string name = Console.ReadLine();

                Console.Write("Kutubxona tizimiga kirish uchun familiyangizni kiriting: ");
                string lastName = Console.ReadLine();

                Console.Write("Kutubxona tizimiga kirish uchun yoshingizni kiriting: ");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Yoshingizni to'g'ri kiriting (raqam bo'lishi kerak): ");
                }

                Console.Write("Kutubxona tizimiga kirish uchun yangi login kiriting: ");
                string login = Console.ReadLine();

                Console.Write("Kutubxona tizimiga kirish uchun yangi parol kiriting: ");
                string password = Console.ReadLine();

                string booksInput = "";

                List<string> books = booksInput.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(b => b.Trim()).ToList();
                users.Add(new BookReader
                {
                    UserId = users.Max(u => u.UserId) + 1,
                    UserLogin = login,
                    UserPassword = password,
                    UserName = name,
                    UserLastName = lastName,
                    UserAge = age,
                    UserGetBooksCount = books.Count,
                    UserGetBooks = books
                });

                AddNewUser(users);
                Console.WriteLine("User muvaffaqiyatli qo'shildi."); 
            }
            catch(Exception ex)
            {
                logger.LogGeneralError($"{ex.Message}");
                Console.WriteLine($"LogException, Message: {ex.Message}");
            }
        }
        public void AddNewUser(List<BookReader> users)
        {
            try
            {
                var lines = users.Select(p => p.ToString()).ToArray();
                File.WriteAllLines(usersFilePath, lines);
            }
            catch(Exception ex)
            {
                logger.LogFileAccessError(usersFilePath, ex);
            }
        }
        public void GetAllBookReaders()
        {
            try
            {
                if (File.Exists(usersFilePath))
                {
                    var lines = File.ReadAllLines(usersFilePath);
                    foreach (var line in lines)
                    {
                        Console.WriteLine(line.Trim());
                    }
                }
                else
                {
                    logger.LogFileNotFound(usersFilePath);
                    Console.WriteLine("Fayl topilmadi: " + usersFilePath);
                } 
            }
            catch(Exception ex)
            {
                logger.LogException(ex);
            }
        }
    }
}