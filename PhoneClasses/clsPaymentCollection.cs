using System;
using System.Collections.Generic;
namespace PhoneClasses
{
    public class clsPaymentCollection
    {
        //private data member for the list
        List<clsPayment> mPaymentList = new List<clsPayment>();
        clsPayment mThisPayment = new clsPayment();
            
        public List<clsPayment> PaymentList
        {
            get
            {
                //return the orivate data
                return mPaymentList;
            }
            set
            {
                //set the private data 
                mPaymentList = value;

            }
        }
        //piblib property for the count
        public int Count
        {
            get
            {
                //return the count list
                return mPaymentList.Count;
            }
            set
            {
                //we shall worry abu this later
            }
        }

        public clsPayment ThisPayment
        {
            get
            {
                //retrurn the private data 
                return mThisPayment;
            }
            set
            {
                //set the private data
                mThisPayment = value;
            }
           
        }
        public int Add()
        {
            //adds a new record to the database based on the values of ThismAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisPayment.OrderID);
            DB.AddParameter("@CardExpiry", mThisPayment.CardExpiry);
            DB.AddParameter("@CardNo", mThisPayment.CardNo);
            DB.AddParameter("@CardHoldersName", mThisPayment.CardHoldersName);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblPaymentt_Insert");



        }
        public void Delete()
        {
            //deltes the record ponited to by this ThispYamnet
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for th estored procedyre
            DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            //EXECUTE THE STORED PROCEDURE
            DB.Execute("sproc_tblPayments_Delete");
        }

        //concstructor for the class
        public clsPaymentCollection()
        {
           
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //EXECUTE THE STORED PROCEDURE
            DB.Execute("sproc_tblPayment_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
           



        }

        
        public void ReportByCardHoldersName(string CardHoldersName)
        {
            //filters the records based ona full or partial post code 
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@CardHoldersName", CardHoldersName);
            //execute the stored procedure
            DB.Execute("sproc_tblPayment_FilterByCardHoldersName");
            //POPULATE THE ARRAY LIST WITH THE DATA TABLE
            PopulateArray(DB);
        }

        public void Update()
        {
            //upate the existtinf ecodd based o the values of the thispayment
            //connect oot n=fatabasee
            clsDataConnection DB = new clsDataConnection();
            //set the paremetrs for the soted proceudre
            DB.AddParameter("@PaymentID", mThisPayment.PaymentID);
            DB.AddParameter("@OrderID", mThisPayment.OrderID);
            DB.AddParameter("@CardExpiry", mThisPayment.CardExpiry);
            DB.AddParameter("@CardNo", mThisPayment.CardNo);
            DB.AddParameter("@CardHoldersName", mThisPayment.CardHoldersName);
            //execute the soted procedure
            DB.Execute("sproc_tblPayment_Update");
        }

      void PopulateArray (clsDataConnection DB)
        {
            //populates the array list based on the dta table in th parameter DB
            //var for the Index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mPaymentList = new List<clsPayment>();
            //WHILE THERE ARE RECORDS TO PROCESS
            while (Index < RecordCount)
            {
                //create a blank payment
                clsPayment AnPayment = new clsPayment();
                //read in the fields from the current record
                AnPayment.PaymentID = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentID"]);
                AnPayment.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnPayment.CardExpiry = Convert.ToDateTime(DB.DataTable.Rows[Index]["CardExpiry"]);
                AnPayment.CardHoldersName = Convert.ToString(DB.DataTable.Rows[Index]["CardHoldersName"]);
                AnPayment.CardNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CardNo"]);
                //add the record to the private data mamber
                mPaymentList.Add(AnPayment);
                //point at the next record
                Index++;
            }
        }
    }
}
