using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace AddressBookLinq
{
    public class AddressBookManagement
    {
        //UC1 - Create a Data Table
        DataTable table = new DataTable();

        /// <summary>
        /// UC2 and UC3
        /// Adds the data to data table.
        /// </summary>
        public void AddDataToDataTable()
        {
            table.Columns.Add("firstName", typeof(string));
            table.Columns.Add("lastName", typeof(string));
            table.Columns.Add("address", typeof(string));
            table.Columns.Add("city", typeof(string));
            table.Columns.Add("state", typeof(string));
            table.Columns.Add("zip", typeof(int));
            table.Columns.Add("phoneNumber", typeof(string));
            table.Columns.Add("email", typeof(string));

            table.Rows.Add("Chetan", "Malagoudar", "Mahantesh Nagar", "Belgaum", "Karnataka", 590016, "8951604950", "bmchetan2028@gmail.com");
            table.Rows.Add("Pranav", "Mare", "Chinchwad", "Pune", "Maharastra", 568916, "7412589635", "pranavmare@gmail.com");
            table.Rows.Add("Ibraheem", "Khaleel", "Near Wayand park", "Wayand", "Kerala", 595716, "9632147857", "ibraheemkhaleel@gmail.com");
            table.Rows.Add("Shiva", "Reddy", "Ameerpet", "Hyderabad", "Telangana", 597516, "963214785", "shivareddy8@gmail.com");
            table.Rows.Add("Abhilash", "Itnal", "Near Chandini Chowk", "Chandini Chowk", "New Delhi", 594316, "9632145875", "abhilashitnal@gmail.com");
            table.Rows.Add("Ameysingh", "Rajput", "MG Road", "Surat", "Gujarat", 518016, "8523691475", "ameyrajput@gmail.com");
        }

        /// <summary>
        /// UC4
        /// Updates the contact detail.
        /// </summary>
        public void UpdateContactDetail()
        {
            var recordData = table.AsEnumerable().Where(x => x.Field<string>("firstName").Equals("Abhilash") && x.Field<string>("phoneNumber").Equals("9632145875")).FirstOrDefault();
            recordData["state"] = "Chennai";
            Console.WriteLine("***********UpdatedData***************");
            Console.WriteLine("FirstName:- " + recordData.Field<string>("firstName"));
            Console.WriteLine("lastName:- " + recordData.Field<string>("lastName"));
            Console.WriteLine("Address:- " + recordData.Field<string>("address"));
            Console.WriteLine("City:- " + recordData.Field<string>("city"));
            Console.WriteLine("State:- " + recordData.Field<string>("state"));
            Console.WriteLine("zip:- " +recordData.Field<int>("zip"));
            Console.WriteLine("phoneNumber:- " + recordData.Field<string>("phoneNumber"));
            Console.WriteLine("eMail:- " + recordData.Field<string>("email"));
            Console.WriteLine("***************");

        }

        /// <summary>
        /// Views the contact.
        /// </summary>
        public void ViewContact()
        {
            foreach (var contact in table.AsEnumerable())
            {
                Console.WriteLine("First Name : " + contact.Field<string>("firstName") + 
                    "  LastName : " + contact.Field<string>("lastName")+
                    "  Address : " + contact.Field<string>("address")+
                    "  City : " + contact.Field<string>("city")+
                    "  State : " + contact.Field<string>("state")+
                    "  Zip : " + contact.Field<int>("zip")+
                    "  Phone Number : " + contact.Field<string>("phoneNumber")+
                    "  Email : " + contact.Field<string>("email"));
            }
        }
    }
}
