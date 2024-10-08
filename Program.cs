using System;
using System.Collections.Generic;
using CalculatR.Classes;

namespace CalculatR
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerBroker logger = new LoggerBroker();
            ILibraryService libraryService= new LibraryService(logger);
            libraryService.GetAllMethods();
        }
    }
}