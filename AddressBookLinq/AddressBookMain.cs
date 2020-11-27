using System;
using System.Data;

namespace AddressBookLinq
{
    public class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Table");
            AddressBookManagement addressBook = new AddressBookManagement();
            addressBook.AddDataToDataTable();
            addressBook.ViewContact();
            addressBook.UpdateContactDetail();
            addressBook.ViewContact();
        }
    }
}
