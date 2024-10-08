using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatR.Classes
{
    public class LibraryService : ILibraryService
    {
        private readonly ILoggerBroker logger;
        public LibraryService(ILoggerBroker _logger)
        {
            logger = _logger;
        }
        IBook book = new Book();
        IBookReader bookReader = new BookReader();
        public void GetAllMethods()
        {
            try
            {
                bookReader.CheckUser();
                Console.Write("Menu so'zini kiriting: ");
                string getWordForMenu = Console.ReadLine().ToLower();
                if(getWordForMenu == "menu")
                {
                    Console.Write("1-Kitoblar ro'yxatini ko'rish.\n2-Kitob tanlab u haqida ma'lumot olish.\n3-Kitob tanlab o'zingizning kitoblar ro'yxatingizga qo'shib qo'yish.\n4-Kitobni kutubxonaga qaytarib berish.\n");
                    Console.Write("Menulardan birini tanlang: ");
                    int operation = int.Parse(Console.ReadLine());
                    switch(operation)
                    {
                        case 1:
                            book.GetAllBooks();
                            break;
                        case 2:
                            book.GetBooksById();
                            break;
                        case 3:
                            book.AddBookToUserFile();
                            break;
                        case 4:
                            book.DeleteBookFromUser();
                            break;
                        default:
                            Console.WriteLine("Menu Not Found!");
                            break;
                    }
                }
                else
                {
                    logger.LogFileNotFound("FilePath");
                    Console.WriteLine("Operation Not Found!");
                }
            }
            catch(Exception ex)
            {
                logger.LogException(ex);
                Console.WriteLine("Xatolik yuz berdi: " + ex.Message);
            }
        }
    }
}