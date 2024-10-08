using System;
using System.Collections.Generic;
namespace CalculatR.Classes
{
    public interface IBook
    {
        void FindBooksReadByUsers(List<BookReader> users);
        void GetCountBooksInLibrary();
        void GetAllBooks();
        void GetBooksById();
        void AddBookToUserFile();
        void DeleteBookFromUser();
    }
}