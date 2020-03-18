using System;
using System.Collections.Generic;
using PhoneClasses;

namespace PhoneClasses
{
    public class clsOrderLineCollection
    {
        //
        //private data member for the list
        List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
        //private data member for the list
        clsOrderLine mThisOrderLine = new clsOrderLine();

        public List<clsOrderLine> OrderLineList
        {
            get
            {
                //return the orivate data
                return mOrderLineList;
            }
            set
            {
                //set the private data 
                mOrderLineList = value;

            }
        }
        //piblib property for the count
        public int Count
        {
            get
            {
                //return the count list
                return mOrderLineList.Count;
            }
            set
            {
                //we shall worry abu this later
            }
        }

        public clsOrderLine ThisOrderLine
        {
            get
            {
                //return the private data
                return mThisOrderLine;
            }
            set
            {
                //set the private data 
                mThisOrderLine = value;
            }
        }



        //concstructor for the class
        public clsOrderLineCollection()

        {




            clsDataConnection DB = new clsDataConnection();
            //EXECUTE THE STORED PROCEDURE
            DB.Execute("sproc_tblOrderLine_SelectAll");
            //get the count of records
            PopulateArray(DB);



        }
        public int Add()
        {
            //adds a new record to the database based on the values of ThismAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrderLine.OrderID);
            DB.AddParameter("@Quantity", mThisOrderLine.Quantity);
            DB.AddParameter("@ProductID", mThisOrderLine.ProductID);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrderLine_Insert");



        }
        public void Delete()
        {
            //deltes the record ponited to by this ThispYamnet
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for th estored procedyre
            DB.AddParameter("@OrderLineID", mThisOrderLine.OrderLineID);
            //EXECUTE THE STORED PROCEDURE
            DB.Execute("sproc_tblOrderLine_Delete");
        }
        public void Update()
        {
            //upate the existtinf ecodd based o the values of the thisOrderline
            //connect oot n=fatabasee
            clsDataConnection DB = new clsDataConnection();
            //set the paremetrs for the soted proceudre
            DB.AddParameter("@OrderLineID", mThisOrderLine.OrderLineID);
            DB.AddParameter("@OrderID", mThisOrderLine.OrderID);
            DB.AddParameter("@Quantity", mThisOrderLine.Quantity);
            DB.AddParameter("@ProductID", mThisOrderLine.ProductID);

            //execute the soted procedure
            DB.Execute("sproc_tblOrderLine_Update");
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
            mOrderLineList = new List<clsOrderLine>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank orderline
                clsOrderLine AnOrderLine = new clsOrderLine();
                //read in the fields from the current record
                AnOrderLine.OrderLineID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineID"]);
                AnOrderLine.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnOrderLine.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrderLine.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                //add the record to private data mamber
                mOrderLineList.Add(AnOrderLine);
                //point at the next record
                Index++;
            }



        }
    }
}