using System;

namespace PhoneClasses
{

    public class clsOrderLine


        //
    {
        private Int32 mOrderLineID;
        //private data member for the Order property
        private Int32 mOrderID;
        //private data member for the ProductID property
        private Int32 mProductID;
        //private data member for the ProductID property
        private Int32 mQuantity;
        public clsOrderLine()
        {
        }
        public int OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }
        public int OrderLineID
        {
            get
            {
                return mOrderLineID;
            }
            set
            {
                mOrderLineID = value;
            }
        }
        public int ProductID
        {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        }
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        public bool Find(int orderLineID)
        {
            //create an intance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //ADD THE PAAREMTER FOR THE PAYEMNT id TPO SEARCH FOR
            DB.AddParameter("@OrderLineID", OrderLineID);
            //EXECUTE THE STORED PROCEDURE
            DB.Execute("sproc_tblOrderLine_FilterByOrderLineID");
            //if no one record isfund (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the xdta rom the dtabase to the private data members
                mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);


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

        public string Valid( string quantity)
        {
            //create a string to variable toostore the rror 
            String Error = "";
            
            //if the quantity is blank
            if (quantity.Length == 0)
            {
                //record an error
                Error = Error + "The quantity may not be blank : ";
            }
            if (quantity.Length < 1 | quantity.Length > 50)
            {
                //record an error
                Error = Error + "The quantity must be between 1 and 50 : ";
            }
            try
            {
                Int32 Temp;
                Temp = Convert.ToInt32(quantity);
                if (Temp < 1)
                {
                    Error = Error + "quantity Too short ";
                }
                if (Temp > 50)
                {
                    Error = Error + "quantity Too long ";
                }
            }
            catch
            {
                Error = Error + "Please enter a valid quantity";
            }

            return "";
        }

    }
}