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

            DataTable table = new DataTable();

            addressBook.AddDataToDataTable(table);
            addressBook.ViewContact(table);
        }
    }
}
