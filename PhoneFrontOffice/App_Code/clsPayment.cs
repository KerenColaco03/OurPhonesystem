using System;
using PhoneClasses;
using System.Linq;
using System.Text;



namespace PhoneClasses
{
    public class clsPayment
    {
        //
        //private data member for the Pyament Id property
        private Int32 mPaymentID;
        //private data member for the CARD eXPIRY PROPERTY
        private DateTime mCardExpiry;
        //private data member for the CardholdersName property
        private string mCardHoldersName;
        //private data member for the CardNo property
        private Int32 mCardNo;
        //private data member for the OrderID property
        private Int32 mOrderID;
        //private data member for the ProductID property





        //public clsPayment()

        //{

        //}

        public DateTime CardExpiry
        {
            get
            {
                //return the private data
                return mCardExpiry;
            }
            set
            {
                //set he value of the private data member
                mCardExpiry = value;
            }
        }

        public string CardHoldersName
        {
            get
            {
                //return the private data
                return mCardHoldersName;
            }
            set
            {
                //set he value of the private data member
                mCardHoldersName = value;
            }
        }

        public int CardNo
        {
            get
            {
                //return the private data
                return mCardNo;
            }
            set
            {
                //set he value of the private data member
                mCardNo = value;
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
                //set he value of the private data member
                mOrderID = value;
            }
        }

        public int PaymentID
        {
            get
            {
                //return the private data
                return mPaymentID;
            }
            set
            {
                //set he value of the private data member
                mPaymentID = value;
            }
        }



        public bool Find(int paymentID)
        {
            //create an intance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //ADD THE PAAREMTER FOR THE PAYEMNT id TPO SEARCH FOR
            DB.AddParameter("@PaymentID", PaymentID);
            //EXECUTE THE STORED PROCEDURE
            DB.Execute("sproc_tblPayment_FilterByPaymentID");
            //if no one record isfund (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the xdta rom the dtabase to the private data members
                mPaymentID = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCardExpiry = Convert.ToDateTime(DB.DataTable.Rows[0]["CardExpiry"]);
                mCardNo = Convert.ToInt32(DB.DataTable.Rows[0]["CardNo"]);
                mCardHoldersName = Convert.ToString(DB.DataTable.Rows[0]["CardHolersName"]);
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

        public string Valid( string cardExpiry, string cardHoldersName, string cardNo)
        {
            //create a string to variable toostore the rror 
            String Error = "";
            DateTime DateTemp;

            //if the cardNo is blank
            if (cardNo.Length == 0)
            {
                //record an error
                Error = Error + "The CardNo may not be blank : ";
            }
            if (cardNo.Length < 16 | cardNo.Length > 16)
            {
                //record an error
                Error = Error + "The CardNo must be 16 characters: ";

                try
                {
                    Int32 Temp;
                    Temp = Convert.ToInt32(cardNo);
                    if (Temp < 16)
                    {
                        Error = Error + "CardNo Too short ";
                    }
                    if (Temp > 16)
                    {
                        Error = Error + "CardNo Too long ";
                    }
                }
                catch
                {
                    Error = Error + "Please enter a valid cardNo";
                }
            }


            //create
            try
            {


                DateTemp = Convert.ToDateTime(CardExpiry);
                if (DateTemp < DateTime.Now.Date)
                {
                    //Record the error
                    Error = Error + "The date cannot be in the past : ";

                }

            }
            catch
            {
                Error = Error + "Please enter a valid OrderDate";
            }

            //if the card holders name is left blank

            //if the cardNo is blank
            if (cardHoldersName.Length == 0)
            {
                //record an error
                Error = Error + "The Card Holders Name may not be blank : ";
            }
            if (cardHoldersName.Length > 50)
            {
                //record an error
                Error = Error + "The Card Holders Name must be less than 50 characters : ";
            }

           

            //return any error messages
            return Error;
        }
    }
}