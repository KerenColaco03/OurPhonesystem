using System;
using System.Collections.Generic;
using ClassLibrary;


namespace PhoneClasses
{
    public class clsSupplierCollection
    {
        //private data member for the list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        //private data member thisSupplier
        clsSupplier mThisSupplier = new clsSupplier();

        //public property for the property list
        public List<clsSupplier> SupplierList
        {
            get
            {
                //return the private data
                return mSupplierList;
            }
            set
            {
                //set the private data 
                mSupplierList = value;
            }
        }
        //public property for count 
        public int Count
        {
            get
            {
                //return the count of the list
                return mSupplierList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsSupplier ThisSupplier
        {
            get
            {
                //return the private data
                return mThisSupplier;
            }
            set
            {
                //set the private data 
                mThisSupplier = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisProduct
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@SupplierDate", mThisSupplier.SupplierDate);
            DB.AddParameter("@ProductID", mThisSupplier.ProductID);
            //execute the query returning the priamry key value
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisSupplier
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            //execute the stored procedure 
            DB.Execute("sproc_tblSupplier_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisSupplier
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@SupplierDate", mThisSupplier.SupplierDate);
            DB.AddParameter("@ProductID", mThisSupplier.ProductID);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_Update");
        }

        public void ReportBySupplierName(string SupplierName)
        {
            //filters the records based on a full or partial Supplier name
            //connect to teh database
            clsDataConnection DB = new clsDataConnection();
            //send the SupplierName parameter to the database
            DB.AddParameter("@SupplierName", SupplierName);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierName");
            //populare the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on teh data table in the parameter DB
            //var for the index        
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mSupplierList = new List<clsSupplier>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Supplier
                clsSupplier ASupplier = new clsSupplier();
                //read in the fields from the current record            
                ASupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                ASupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                ASupplier.SupplierDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["SupplierDate"]);
                ASupplier.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                //add the record to the private data member
                mSupplierList.Add(ASupplier);
                //point at the next record
                Index++;
            }
        }

        public clsSupplierCollection()
        {
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

        }
    }
}
