using System;
using System.Collections.Generic;
using ClassLibrary;

namespace PhoneClasses
{
    public class clsProductCollection
    {
        //private data member for the list
        List<clsProduct> mProductList = new List<clsProduct>();
        //private data member thisProduct
        clsProduct mThisProduct = new clsProduct();

        //public property for the property list
        public List<clsProduct> ProductList
        {
            get
            {
                //return the private data
                return mProductList;
            }
            set
            {
                //set the private data 
                mProductList = value;
            }
        }
        //public property for count 
        public int Count
        {
            get
            {
                //return the count of the list
                return mProductList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }


        public clsProduct ThisProduct
        {
            get
            {
                //return the private data
                return mThisProduct;
            }
            set
            {
                //set the private data
                mThisProduct = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisProduct
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@Brand", mThisProduct.Brand);
            DB.AddParameter("@Capacity", mThisProduct.Capacity);
            DB.AddParameter("@Colour", mThisProduct.Colour);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@ProductQuantity", mThisProduct.ProductQuantity);
            DB.AddParameter("@ProductType", mThisProduct.ProductType);
            //execute the query returning the priamry key value
            return DB.Execute("sproc_tblPhones_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisProduct
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            //execute the stored procedure 
            DB.Execute("sproc_tblPhones_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisProduct
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            DB.AddParameter("@Brand", mThisProduct.Brand);
            DB.AddParameter("@Capacity", mThisProduct.Capacity);
            DB.AddParameter("@Colour", mThisProduct.Colour);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@ProductQuantity", mThisProduct.ProductQuantity);
            DB.AddParameter("ProductType", mThisProduct.ProductType);
            //execute the stored procedure
            DB.Execute("sproc_tblPhones_Update");
        }

        public void ReportByProductType(string ProductType)
        {
            //filters the records based on a full or partial code 
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the ProductType parameter to the database 
            DB.AddParameter("@ProductType", ProductType);
            //execute the stored procedure
            DB.Execute("sproc_tblPhones_FilterByProductTypee");
            //populate the array list with the data table
            PopulateArray(DB);
        }


        //constructor for the class
        public clsProductCollection()
        {
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblPhones_SelectAll");
            //populate the array list with the data table 
            PopulateArray(DB);
        }
    
        
  
        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mProductList = new List<clsProduct>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create  a blank product
                clsProduct AProduct = new clsProduct();
                //read in the fields from the current record 
                AProduct.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AProduct.Brand = Convert.ToString(DB.DataTable.Rows[Index]["Brand"]);
                AProduct.Capacity = Convert.ToString(DB.DataTable.Rows[Index]["Capacity"]);
                AProduct.Colour = Convert.ToString(DB.DataTable.Rows[Index]["Colour"]);
                AProduct.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                AProduct.ProductQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductQuantity"]);
                AProduct.ProductType = Convert.ToString(DB.DataTable.Rows[Index]["ProductType"]);
                //add the record to the private data member
                mProductList.Add(AProduct);
                //point at the next record 
                Index++;
            }

        }
    }
}
