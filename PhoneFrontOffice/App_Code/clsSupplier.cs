using ClassLibrary;
using System;

namespace PhoneClasses
{
    public class clsSupplier
    {
        //private data member for the SupplierID property
        private Int32 mSupplierID;
        //private data member for the SupplierName property
        private string mSupplierName;
        //private data member for the SupplierDate property
        private DateTime mSupplierDate;
        //private data member for the productID property
        private Int32 mProductID;


        public clsSupplier()
        {
        }

        public DateTime SupplierDate
        {
            get
            {
                //return the private data
                return mSupplierDate;
            }

            set
            {
                //set the value of teh private data member
                mSupplierDate = value;
            }
        }
        public string SupplierName
        {
            get
            {
                //return the private data
                return mSupplierName;
            }

            set
            {
                //set the value of teh private data member
                mSupplierName = value;
            }
        }

        public int SupplierID
        {
            get
            {
                //return the private data
                return mSupplierID;
            }
            set
            {
                mSupplierID = value;
            }
        }

        public int ProductID
        {
            get
            {
                //return the private data
                return mProductID;
            }

            set
            {
                //set the value of teh private data member
                mProductID = value;
            }
        }

        public bool Find(int supplierID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter fro the productID to search for 
            DB.AddParameter("@SupplierID", SupplierID);
            //execute the stored procedure 
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            //if no record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the databse to the private data members
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mSupplierDate = Convert.ToDateTime(DB.DataTable.Rows[0]["SupplierDate"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);

                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string supplierName, string supplierDate, string productID)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            try
            {


                //copy the SupplierDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(supplierDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date cannot be in the future :";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            if (supplierName.Length == 0)
            {
                //record the error
                Error = Error + "The SupplierName may not be blank : ";
            }
            //if the brand is greater than 30 charatcers 
            if (supplierName.Length > 30)
            {
                //record the error
                Error = Error + "The SupplierName must be less than 30 characters";
            }

            if (productID.Length == 0)
            {
                //record an error
                Error = Error + "The ProductID may not be blank";
            }
            if (productID.Length < 1 | productID.Length > 10)
            {
                //record an error
                Error = Error + "The productID must be between 1 and 10 characters";
            }
            try
            {
                Int32 Temp;
                Temp = Convert.ToInt32(productID);
                if (Temp < 1)
                {
                    Error = Error + "productID too short";
                }
                if (Temp > 10)
                {
                    Error = Error + "productID too long";
                }
            }
            catch
            {
                Error = Error + "please enter a valid productID";
            }


            //return any error messages 
            return Error;
        }
    }
}
