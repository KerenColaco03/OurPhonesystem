using System;

namespace PhoneClasses
{
    public class clsOrder
    {
        //
        private Int32 mOrderID;
        //private data member for the areder date property
        private DateTime mOrderDate;
        //private data member for the Customer ID property
        private Int32 mCustomerID;
        //private data member for the areder date property
        private double mTotalPrice;




        public clsOrder()
        {
        }

        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }
        public int OrderID
        {
            get
            {
                //return the private data
                return mOrderID;
            }
            set
            {
                //SET THE VALUE OF THE PRVATE DATA MEMBER
                mOrderID = value;
            }
        }
        public double TotalPrice
        {
            get
            {
                return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }
        }

        public bool Find(int orderID)
        {
            //create an intance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //ADD THE PAAREMTER FOR THE PAYEMNT id TPO SEARCH FOR
            DB.AddParameter("@OrderID", OrderID);
            //EXECUTE THE STORED PROCEDURE
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if no one record isfund (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the xdta rom the dtabase to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mTotalPrice = Convert.ToDouble(DB.DataTable.Rows[0]["TotalPrice"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);

                //always reutnr tuire
                return true;
            }


            //if no record was found
            else
            {
                //return false indicating a problme
                return false;
            }



        }

        public string Valid(string customerID, string totalPrice, string orderDate)
        {
            //cretae a string variable to store the rror
            String Error = "";
            //create temporary varibale to store the date values
            DateTime DateTemp;
            //if the OrderDate is balnk
            try
            {


                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //Record the error
                    Error = Error + "The date cannot be in the past : ";

                }
                if (DateTemp < DateTime.Now.Date)

                {
                    //record the error
                    Error = Error + "The date cannot be in the future :";
                }
            }
            catch
            {
                Error = Error + "Please enter a valid OrderDate";
            }
            //if the Order ID is blank
            if (customerID.Length == 0)
            {
                //record an error
                Error = Error + "The CardNo may not be blank : ";
                try
                {
                    Int32 Temp;
                    Temp = Convert.ToInt32(customerID);
                    if (Temp < 1)
                    {
                        Error = Error + "customerID Too short ";
                    }
                    if (Temp > 50)
                    {
                        Error = Error + "customerID Too long ";
                    }
                }
                catch
                {
                    Error = Error + "Please enter a valid customerID";
                }
            }
         
            //if the price is blank
            if (totalPrice.Length == 0)
            {
                //record an error
                Error = Error + "The totalPrice may not be blank : ";
            }
            if (totalPrice.Length <  3| totalPrice.Length > 7)
            {
                //record an error
                Error = Error + "The totalPrice must be between 1 and 1000 integers: ";
            }
            try
            {
                Decimal Temp;
                Temp = Convert.ToDecimal(totalPrice);
                if (Temp < 1 )
                {
                    Error = Error + "totalPrice Too short ";
                }
                if (Temp > 10000000)
                {
                    Error = Error + "totalPrice Too long ";
                }
            }
            catch
            {
                Error = Error + "Please enter a valid totalPrice";
            }


            //return any error messages
            return "";
        }
    }
}