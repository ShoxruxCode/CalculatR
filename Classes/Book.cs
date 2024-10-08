using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace CalculatR.Classes
{
    public class Book : IBook
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookGenre { get; set; }
        public string BookAutor { get; set; }
        public override string ToString()
        {
            return $"{BookId}, {BookName}, {BookGenre}, {BookAutor}";
        }
        public readonly string bookFilePath = "File/books.txt";
        public readonly string userFilePath = "File/user.txt";
        private readonly ILoggerBroker logger;
        BookReader bookReader = new BookReader();
        public Book()
        {

        }
        public Book(ILoggerBroker _logger)
        {
            logger = _logger;
        }
        public List<Book> LoadBooks()
        {
            List<Book> books = new List<Book>();
            try
            {
                if (File.Exists(bookFilePath))
                {
                    var lines = File.ReadAllLines(bookFilePath);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length == 4)
                        {
                            var book = new Book(logger)
                            {
                                BookId = int.Parse(parts[0].Trim()),
                                BookName = parts[1].Trim(),
                                BookGenre = parts[2].Trim(),
                                BookAutor = parts[3].Trim()
                            };
                            books.Add(book);
                        }
                    }
                }
                else
                {
                    logger.LogFileNotFound(bookFilePath);
                }
            }
            catch(Exception ex)
            {
                logger.LogException(ex);
            }

            return books;
        }
        public void FindBooksReadByUsers(List<BookReader> users)
        {
            try
            {
                Console.WriteLine("Kutubxonadagi kitoblarni o'qiyotgan shaxslar ro'yxati.");
                var books = LoadBooks();
                foreach (var user in users)
                {
                    Console.WriteLine($"{user.UserName} {user.UserLastName} o'qiyotgan kitoblar:");
                    
                    foreach (var userBook in user.UserGetBooks)
                    {
                        var bookMatch = books.FirstOrDefault(b => b.BookName.Trim().ToLower() == userBook.Trim().ToLower());
                        
                        if (bookMatch != null)
                        {
                            Console.WriteLine($"- {bookMatch.BookName} (Janri: {bookMatch.BookGenre}, Muallif: {bookMatch.BookAutor})");
                        }
                        else
                        {
                            Console.WriteLine($"- {userBook} (bu kitob kutubxonada topilmadi)");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
            }
        }
        public void GetCountBooksInLibrary()
        {
            try
            {
                List<Book> books = LoadBooks();
                Console.WriteLine($"Kutubxonada {books.Count} dona kitob bor");
            }
            catch(Exception ex)
            {
                logger.LogFileAccessError(bookFilePath, ex);
                Console.WriteLine("Kutobxonada 0 dona kitob bor");
            }
        }
        public void GetAllBooks()
        {
            try
            {
                if (File.Exists(bookFilePath))
                {
                    var lines = File.ReadAllLines(bookFilePath);
                    foreach (var line in lines)
                    {
                        Console.WriteLine(line.Trim());
                    }
                }
                else
                {
                    logger.LogFileNotFound(bookFilePath);
                    Console.WriteLine("Fayl topilmadi: " + bookFilePath);
                } 
            }
            catch(Exception ex)
            {
                logger.LogException(ex);
            }
        }
        public void GetBooksById()
        {
            try
            {
                List<BookReader> bookReaders = bookReader.LoadBookReaders();
                GetCountBooksInLibrary();
                GetAllBooks();
                FindBooksReadByUsers(bookReaders);
                var books = LoadBooks();
                Console.Write("Ma'lumot olmoqchi bo'lgan kitobingizning Id, ya'ni tartib raqamini kiriting: ");
                
                if (int.TryParse(Console.ReadLine(), out int getBooksById))
                {
                    var getBook = books.FirstOrDefault(b => b.BookId == getBooksById);
                    
                    if (getBook != null)
                    {
                        Console.WriteLine($"{getBook.BookId}, {getBook.BookName}, {getBook.BookGenre}, {getBook.BookAutor}");
                    }
                    else
                    {
                        Console.WriteLine("Bu Idga ega kitob topilmadi.");
                        logger.LogFileNotFound(bookFilePath);
                    }
                }
                else
                {
                    logger.LogFileNotFound(bookFilePath);
                    Console.WriteLine("Kiritilgan qiymat kitob ID raqami emas.");
                }
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
            }
        }
        public void AddBookToUserFile()
        {
            try
            {
                List<BookReader> bookReaders = bookReader.LoadBookReaders();
                GetCountBooksInLibrary();
                GetAllBooks();
                FindBooksReadByUsers(bookReaders);
                var books = LoadBooks();
                Console.Write("Olmoqchi bo'lgan kitobingizning Id raqamini kiriting: ");
                int bookId;
                while (!int.TryParse(Console.ReadLine(), out bookId))
                {
                    Console.Write("Kitob Id raqamini to'g'ri kiriting (raqam bo'lishi kerak): ");
                }

                var selectedBook = books.FirstOrDefault(b => b.BookId == bookId);

                if (selectedBook != null)
                {
                    string bookData = $"{selectedBook.BookId}, {selectedBook.BookName}, {selectedBook.BookGenre}, {selectedBook.BookAutor}";
                    File.AppendAllText(userFilePath, bookData + Environment.NewLine);

                    books.Remove(selectedBook);
                    var updatedBooks = books.Select(b => $"{b.BookId}, {b.BookName}, {b.BookGenre}, {b.BookAutor}");
                    File.WriteAllLines(bookFilePath, updatedBooks);

                    Console.WriteLine($"Kitob muvaffaqiyatli qo'shildi: {bookData}");
                }
                else
                {
                    Console.WriteLine("Bu IDga ega kitob topilmadi.");
                }
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
                Console.WriteLine("Xatolik yuz berdi: " + ex.Message);
            }
        }
        public void DeleteBookFromUser()
        {
            try
            {
                List<BookReader> bookReaders = bookReader.LoadBookReaders();
                GetCountBooksInLibrary();
                GetAllBooks();
                FindBooksReadByUsers(bookReaders);
                var userBooks = File.ReadAllLines(userFilePath).ToList();
                
                Console.Write("Kutubxonaga topshirmoqchi bo'lgan kitobingizning Id raqamini kiriting: ");
                int bookId;
                while (!int.TryParse(Console.ReadLine(), out bookId))
                {
                    Console.Write("Kitob Id raqamini to'g'ri kiriting (raqam bo'lishi kerak): ");
                }

                var selectedBook = userBooks.FirstOrDefault(b => int.Parse(b.Split(',')[0].Trim()) == bookId);

                if (selectedBook != null)
                {
                    userBooks.Remove(selectedBook);
                    File.WriteAllLines(userFilePath, userBooks);

                    File.AppendAllText(bookFilePath, selectedBook + Environment.NewLine);

                    Console.WriteLine($"Kitob muvaffaqiyatli o'chirildi va kutubxonaga qaytarildi: {selectedBook}");
                }
                else
                {
                    Console.WriteLine("Bu IDga ega kitob user faylidan topilmadi.");
                }
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
                Console.WriteLine("Xatolik yuz berdi: " + ex.Message);
            }
        }
    }
}