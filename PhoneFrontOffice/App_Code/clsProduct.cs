using ClassLibrary;
using System;

namespace PhoneClasses
{
    public class clsProduct
    {
        //private data member for the productID property
        private Int32 mProductID;
        //private data member for the brand
        private string mBrand;
        //private data member for the Colour
        private string mColour;
        //private data member for the productType
        private string mProductType;
        //private data member for the product Quanity
        private Int32 mProductQuantity;
        //private data member for the capacity
        private string mCapacity;
        //private data member for price 
        private double mPrice;

        public clsProduct()
        {
        }

        public string Brand
        {
            get
            {
                //return the private data
                return mBrand;
            }

            set
            {
                //set the value of teh private data member
                mBrand = value;
            }
        }

        public string Colour
        {
            get
            {
                //return the private data
                return mColour;
            }

            set
            {
                //set the value of teh private data member
                mColour = value;
            }
        }
        public string ProductType
        {
            get
            {
                //return the private data
                return mProductType;
            }

            set
            {
                //set the value of teh private data member
                mProductType = value;
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
        public int ProductQuantity
        {
            get
            {
                //return the private data
                return mProductQuantity;
            }

            set
            {
                //set the value of teh private data member
                mProductQuantity = value;
            }
        }
        public string Capacity
        {
            get
            {
                //return the private data
                return mCapacity;
            }

            set
            {
                //set the value of teh private data member
                mCapacity = value;
            }
        }
        public double Price
        {
            get
            {
                //return the private data
                return mPrice;
            }

            set
            {
                //set the value of teh private data member
                mPrice = value;
            }
        }

        public bool Find(int productID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter fro the productID to search for 
            DB.AddParameter("@ProductID", ProductID);
            //execute the stored procedure 
            DB.Execute("sproc_tblPhones_FilterByProductID");
            //if no record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the databse to the private data members
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mBrand = Convert.ToString(DB.DataTable.Rows[0]["Brand"]);
                mProductType = Convert.ToString(DB.DataTable.Rows[0]["ProductType"]);
                mCapacity = Convert.ToString(DB.DataTable.Rows[0]["Capacity"]);
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                mProductQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ProductQuantity"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                //return taht everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string brand, string productType, string capacity, string colour, string price, string productQuantity)
        {
            String Error = "";
            //if the Brand is blank
            if (brand.Length == 0)
            {
                //record the error
                Error = Error + "The brand may not be blank : ";
            }
            //if the brand is greater than 30 charatcers 
            if (brand.Length > 30)
            {
                //record the error
                Error = Error + "The brand must be less than 30 characters";
            }

            if (productType.Length == 0)
            {
                //record the error
                Error = Error + "The ProductType may not be blank";
            }
            //if the ProductType is greater than 30 characters
            if (productType.Length > 30)
            {
                Error = Error + "The ProductType must be less than 30 characters";
            }

            if (capacity.Length == 0)
            {
                //record the error
                Error = Error + "The Capacity may not be blank";
            }
            //if the capacity is greater than 6 characters
            if (capacity.Length > 6)
            {
                Error = Error + "The Capacity must be less than 6 characters";
            }


            if (colour.Length == 0)
            {
                //record the error
                Error = Error + "The Colour may not be blank";
            }
            //if the colour is greater than 20 characters
            if (colour.Length > 20)
            {
                Error = Error + "The Colour must be less than 20 characters";
            }

            //if the ProductQuantity is blank 
            if (productQuantity.Length == 0)
            {
                //record an error
                Error = Error + "The quantity may not be blank : ";
            }
            if (productQuantity.Length < 1 | productQuantity.Length > 6)
            {
                //record an error 
                Error = Error + "The product quantity must be between 1 and 6 characters: ";
            }
            try
            {
                Int32 Temp;
                Temp = Convert.ToInt32(productQuantity);
                if (Temp < 1)
                {
                    Error = Error + "Quantity too short";
                }
                if (Temp > 6)
                {
                    Error = Error + "Product Quantity too long";
                }
            }
            catch
            {
                Error = Error + "Please enter a valid Product Quantity";
            }

            //if the price is blank 
            if (price.Length == 0)
            {
                //record an error
                Error = Error + "The price may not be left blank";
            }
            if (price.Length < 1 | price.Length > 7)
            {
                //record an error
                Error = Error + "The price must be between 1 and 7 characters";
            }
            try
            {
                Decimal Temp;
                Temp = Convert.ToDecimal(price);
                if (Temp < 1)
                {
                    Error = Error + "price is too short";
                }
                if (Temp > 7)
                {
                    Error = Error + "price is too long";
                }
            }
            catch
            {
                Error = Error + "Please enter a valid price";
            }


            //return any error messages
            return Error;
        }
    }
}

