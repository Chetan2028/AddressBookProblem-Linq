using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace AddressBookLinq
{
    public class AddressBookManagement
    {
        /// <summary>
        /// UC2 and UC3
        /// Adds the data to data table.
        /// </summary>
        public void AddDataToDataTable(DataTable table)
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
            table.Rows.Add("Naveen", "Patil", "Sri Nagar", "Belgaum", "Karnataka", 590016, "8951604950", "naveen@gmail.com");
            table.Rows.Add("Abhijit", "Thakur", "Chinchwad", "Pune", "Maharastra", 568916, "7412589635", "abhijitthakur@gmail.com");
            table.Rows.Add("Ibraheem", "Hussain", "Near Wayand park", "Wayand", "Kerala", 595716, "9632147857", "ibraheemhussain@gmail.com");

        }

        /// <summary>
        /// UC4
        /// Updates the contact detail.
        /// </summary>
        public void UpdateContactDetail(DataTable table)
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
        public void ViewContact(DataTable table)
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

        /// <summary>
        /// UC5
        /// Deletes the contact.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <returns></returns>
        public DataTable DeleteContact(DataTable table)
        {
            //getting all the data except the data to be deleted
            //saving them in new data table by copytodatatable method
            //returning the new data table
            //Using Linq u can just query , to delete i am copying into a new datatable
            DataTable dataTableupdated = table.AsEnumerable().Except(table.AsEnumerable().
                Where(r => r.Field<string>("firstName") == "Abhilash" && r.Field<string>("phoneNumber") == "9632145875")).CopyToDataTable();

            return dataTableupdated;
        }

        /// <summary>
        /// UC6
        /// Retrievings the contact details by state or city.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public void RetrievingContactDetailsByStateOrCity(DataTable dataTable)
        {
            //lambda syntax for getting data for particular city
            var recordData = dataTable.AsEnumerable().Where(r => r.Field<string>("city") == "Belgaum");
            //lambda syntax for getting data for particular state
            var recordDataState = dataTable.AsEnumerable().Where(r => r.Field<string>("state") == "Karnataka");
            foreach (var data in recordDataState)
            {
                Console.WriteLine("FirstName:- " + data.Field<string>("firstName"));
                Console.WriteLine("lastName:- " + data.Field<string>("lastName"));
                Console.WriteLine("Address:- " + data.Field<string>("address"));
                Console.WriteLine("City:- " + data.Field<string>("city"));
                Console.WriteLine("State:- " + data.Field<string>("state"));
                Console.WriteLine("zip:- " + data.Field<int>("zip"));
                Console.WriteLine("phoneNumber:- " + data.Field<string>("phoneNumber"));
                Console.WriteLine("eMail:- " + data.Field<string>("email"));
                Console.WriteLine("***************");
            }
        }

        /// <summary>
        /// UC7
        /// Gets the state of the count by city and.
        /// </summary>
        /// <param name="datatable">The datatable.</param>
        public void GetCountByCityAndState(DataTable datatable)
        {
            //getting count for particular state or city
            var recordData = datatable.AsEnumerable().Where(r => r.Field<string>("city") == "Hyderabad" && r.Field<string>("state") == "Telangana").Count();
            //grouping data by city and state
            var recordedData = from data in datatable.AsEnumerable()
                               group data by new { city = data.Field<string>("city"), state = data.Field<string>("state") } into g
                               select new { city = g.Key, count = g.Count() };
            //displaying data for particular city or state
            Console.WriteLine(recordData);
            //displaying total grouped data
            foreach (var data in recordedData.AsEnumerable())
            {
                Console.WriteLine("city:- " + data.city.city);
                Console.WriteLine("state:- " + data.city.state);
                Console.WriteLine("Total Contacts:- " + data.count);
                Console.WriteLine("*******************");

            }
        }
    }
}
