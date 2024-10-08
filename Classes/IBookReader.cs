using System;
using System.Collections.Generic;

namespace CalculatR.Classes
{
    public interface IBookReader
    {
        void CheckUser();
        void CreateUser();
        void AddNewUser(List<BookReader> users);
        void GetAllBookReaders();
    }
}