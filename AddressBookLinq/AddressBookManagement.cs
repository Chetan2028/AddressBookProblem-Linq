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
        /// UC2
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
        }
    }
}
