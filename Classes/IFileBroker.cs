using System;
using System.Collections.Generic;

namespace CalculatR.Classes
{
    public interface IFileBroker
    {
        void AddNewContact(List<FileBroker> contacts);
        void DeleteContact();
        void EditContact();
        void GetAllContacts();
        void GetContactByNameAndLastName();
    }
}