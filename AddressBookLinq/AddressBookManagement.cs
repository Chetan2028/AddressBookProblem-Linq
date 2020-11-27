using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

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
            table.Columns.Add("lasttName", typeof(string));
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
    }
}
