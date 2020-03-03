using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PhoneTesting
{
    class clsCustomerCollection
    {
        ///this class contains code allowing us to manipulate address

        //private data members
        //create a null instance of the class clsDataConnection with class level scope
        clsDataConnection dBConnection;
        //private data member for the current address
        clscustomer mThisCustomer = new clscustomer();



        public clscustomer ThisAddress
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        //function for the public Add method
        public Int32 Add()
        {
            //this function adds a new record to the database returning the primary key value of the new record

            //var to store the primary key value of the new record
            Int32 PrimaryKey;
            //create a connection to the database
            clsDataConnection NewCustomer = new clsDataConnection();
            //add the Firstname parameter
            NewCustomer.AddParameter("@Firstname", mThisCustomer.Firstname);
            //add the Lastname parameter
            NewCustomer.AddParameter("@Lastname", mThisCustomer.Lastname);
            //add the Email parameter
            NewCustomer.AddParameter("@Email", mThisCustomer.Email);
            //add the house number parameter
            NewCustomer.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            //add the streetname parameter
            NewCustomer.AddParameter("@Streetname", mThisCustomer.Streetname);
            //add the town parameter
            NewCustomer.AddParameter("@County", mThisCustomer.County);
            //add the post code parameter
            NewCustomer.AddParameter("@PostCode", mThisCustomer.PostCode);
            //add the county code parameter
            NewCustomer.AddParameter("@Country", mThisCustomer.Country);
            //add the data added parameter
            NewCustomer.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            //add the active parameter
            NewCustomer.AddParameter("@Active", mThisCustomer.Active);
            //execute the query to add the record - it will return the primary key value of the new record
            PrimaryKey = NewCustomer.Execute("sproc_Customers_Insert");
            //return the primary key value of the new record
            return PrimaryKey;
        }

        //function for the public Update method
        public void Update()
        {
            //this function updates an existing record specified by the class level variable addressNo
            //it returns no value

            //create a connection to the database
            clsDataConnection NewCustomer = new clsDataConnection();
            //add the Firstname parameter
            NewCustomer.AddParameter("@Firstname", mThisCustomer.Firstname);
            //add the Lastname parameter
            NewCustomer.AddParameter("@Lastname", mThisCustomer.Lastname);
            //add the Email parameter
            NewCustomer.AddParameter("@Email", mThisCustomer.Email);
            //add the house number parameter
            NewCustomer.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            //add the streetname parameter
            NewCustomer.AddParameter("@Streetname", mThisCustomer.Streetname);
            //add the town parameter
            NewCustomer.AddParameter("@County", mThisCustomer.County);
            //add the post code parameter
            NewCustomer.AddParameter("@PostCode", mThisCustomer.PostCode);
            //add the county code parameter
            NewCustomer.AddParameter("@Country", mThisCustomer.Country);
            //add the data added parameter
            NewCustomer.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            //add the active parameter
            NewCustomer.AddParameter("@Active", mThisCustomer.Active);
            //execute the query
            NewCustomer.Execute("sproc_Customers_Update");
        }

        ///this function deletes a record in the database based on the value of the addressNo var
        public void Delete()
        ///it is a void function and returns no value
        {
            //initialise the DBConnection
            dBConnection = new clsDataConnection();
            //add the parameter data used by the stored procedure
            dBConnection.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure to delete the address
            dBConnection.Execute("sproc_tblCustomer_Delete");
        }


        ///this function defines the ReportByPostCode method
        public void ReportByPostCode(string PostCode)
        ///it accepts a single parameter PostCode and returns no value
        {
            //initialise the DBConnection
            dBConnection = new clsDataConnection();
            //add the parameter data used by the stored procedure
            dBConnection.AddParameter("@PostCode", PostCode);
            //execute the stored procedure to delete the address
            dBConnection.Execute("sproc_Customers_FilterByPostCode");
        }

        ///this function defines the public property Count
        public Int32 Count
        ///it returns the count of records currently in QueryResults
        {
            get
            {
                //return the count of records
                return dBConnection.Count;
            }
        }

        ///this function exposes the DataTable via the public collection AllCustomers
        public List<clscustomer> CustomerList
        {
            get
            {
                List<clscustomer> mCustomerList = new List<clscustomer>();
                Int32 Index = 0;
                while (Index < dBConnection.Count)
                {
                    clscustomer NewCustomer = new clscustomer();
                    //get the Firstname from the query results
                    NewCustomer.Firstname = Convert.ToString(dBConnection.DataTable.Rows[Index]["Streetname"]);
                    //get the Lastname from the query results
                    NewCustomer.Lastname = Convert.ToString(dBConnection.DataTable.Rows[Index]["Lastname"]);
                    //get the Email from the query results
                    NewCustomer.Email = Convert.ToString(dBConnection.DataTable.Rows[Index]["Email"]);
                    //get the house no from the query results
                    NewCustomer.HouseNo = Convert.ToString(dBConnection.DataTable.Rows[Index]["HouseNo"]);
                    //get the street from the query results
                    NewCustomer.Streetname = Convert.ToString(dBConnection.DataTable.Rows[Index]["Streetname"]);
                    //get the post code from the query results
                    NewCustomer.PostCode = Convert.ToString(dBConnection.DataTable.Rows[Index]["PostCode"]);
                    //get the address no from the query results
                    NewCustomer.CustomerID = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["AddressNo"]);
                    //increment the index
                    Index++;
                    //add the address to the list
                    mCustomerList.Add(NewCustomer);
                }
                //return the list of addresses
                return mCustomerList;
            }
        }

    }
}

