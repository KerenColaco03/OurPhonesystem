
using System;
using System.Collections.Generic;

namespace PhoneClasses
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member for the list
        clsOrder mThisOrder = new clsOrder();
        public List<clsOrder> OrderList
        {
            get
            {
                //return the orivate data
                return mOrderList;
            }
            set
            {
                //set the private data 
                mOrderList = value;

            }
        }
        //piblib property for the count
        public int Count
        {
            get
            {
                //return the count list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry abu this later
            }
        }

        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data 
                mThisOrder = value;
            }
        }


        //concstructor for the class
        public clsOrderCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            //EXECUTE THE STORED PROCEDURE
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            PopulateArray(DB);

        }


        public int Add()
        {
            //adds a new record to the database based on the values of ThismOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");



        }

        public void Delete()
        {
            //deltes the record ponited to by this ThispYamnet
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for th estored procedyre
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //EXECUTE THE STORED PROCEDURE
            DB.Execute("sproc_tblOrder_Delete");
        }
        public void ReportByCustomerID(int CustomerID)
        {
            //filters the records based ona full or partial post code 
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByCustomerID");
            //POPULATE THE ARRAY LIST WITH THE DATA TABLE
            PopulateArray(DB);
        }



        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter
            //var for the index
            Int32 Index = 0;
            //var to store the record count'
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //get the count of records
            RecordCount = DB.Count;
            //lear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank orderline
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.TotalPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["TotalPrice"]);
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                //add the record to private data mamber
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }
    }
}


