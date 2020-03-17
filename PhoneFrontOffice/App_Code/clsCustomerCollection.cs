using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ClassLibrary;

namespace PhoneTesting
{
    public class clsCustomerCollection
    {


        ///this class contains code allowing us to manipulate address

        //private data members
        //create a null instance of the class clsDataConnection with class level scope
        //clsDataConnection dBConnection = new clsDataConnection();
        //private data member for the current address
        List<clscustomer> mCustomerList = new List<clscustomer>();
        //private data member thiscustomer
        clscustomer mThisCustomer = new clscustomer();

        //public clascUSTOMER Thiscustomer


            //constructor for the class

        public clsCustomerCollection()
        {


            //object for data connection
            clsDataConnection dBConnection = new clsDataConnection();
            //execute the stored procedure 
            dBConnection.Execute("sproc_Customers_SelectAll");
            //populate the array list with the data table
            PopulateArray(dBConnection);
        }
        
        //public property for the customer list
        public List<clscustomer> CustomerList
        {
            get
            {
               
                //return the private data
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }

        }

        public clscustomer ThisCustomer
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
        public int Add()
        {
            //add a new record to the database based on the values of thiscustomer
            //connect to the database
            
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
             return NewCustomer.Execute("sproc_Customers_Insert");
            
            
        }

        //function for the public Update method
        public void Update()
        {
          
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
            clsDataConnection dBConnection = new clsDataConnection();
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
            clsDataConnection dBConnection = new clsDataConnection();
            //add the parameter data used by the stored procedure
            dBConnection.AddParameter("@PostCode", PostCode);
            //execute the stored procedure to delete the address
            dBConnection.Execute("sproc_Customers_FilterByPostCode");
            //populate the array list with the data table
            PopulateArray(dBConnection);
        }

        ///this function defines the public property Count
        public int Count
        ///it returns the count of records currently in QueryResults
        {
            get
            {
                clsDataConnection dBConnection = new clsDataConnection();
                //send a postcode filter to the query
                dBConnection.AddParameter("@PostCode", "");
                //execute the query
                dBConnection.Execute("sproc_Customers_FilterByPostCode");
                //return the count of records
                return dBConnection.Count;
            }
            set
            {
                //we shall worry about this later
            
            }
        }

        
        void PopulateArray(clsDataConnection dBConnection)
        {
            //VAR FOR THE INDEX
            Int32 Index = 0;
            //Var to store the recordCount 
            Int32 RecordCount;
            //object for data connection
            RecordCount = dBConnection.Count;
            //clear the private array list
            mCustomerList = new List<clscustomer>();
            //while there are records to process
            while (Index < RecordCount)


            {
                //create a black address
                clscustomer NewCustomer = new clscustomer();
                //get the Firstname from the query results
                NewCustomer.Firstname = Convert.ToString(dBConnection.DataTable.Rows[Index]["Firstname"]);
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
                NewCustomer.CustomerID = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["CustomerID"]);
                //add the address to the list
                mCustomerList.Add(NewCustomer);
                //increment the index
                Index++;


            }
       
             

            }
        
    }
}

