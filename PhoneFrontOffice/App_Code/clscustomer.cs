using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PhoneTesting
{
    public class clscustomer
    {
        //private data member for the customerid property
        private Int32 mCustomerID;
        //Private data member for Firstname
        private string mFirstname;
        //Private data member for Lastname
        private string mLastname;
        //Private data member for Email
        private string mEmail;
        //Private data member for HouseNo
        private string mHouseNo;
        //private data member for streetname
        private string mStreetname;
        //private data member for County
        private string mCounty;
        //private data member for post code
        private string mPostCode;
        //private data member for country
        private string mCountry;
        //private date added data member
        private DateTime mDateAdded;
        //private data member for active
        private Boolean mActive;





        public string Firstname
        {
            get
            {
                return mFirstname;
            }
            set
            {
                mFirstname = value;
            }
        }


        public string Lastname
        {
            get
            {
                return mLastname;
            }
            set
            {
                mLastname = value;
            }
        }


        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }


        public string HouseNo
        {
            get
            {
                return mHouseNo;
            }
            set
            {
                mHouseNo = value;
            }
        }


        public string Streetname
        {
            get
            {
                return mStreetname;
            }
            set
            {
                mStreetname = value;
            }
        }


        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                mPostCode = value;
            }
        }

        public string County
        {
            get
            {
                return mCounty;
            }
            set
            {
                mCounty = value;
            }
        }

        public string Country
        {
            get
            {
                return mCountry;
            }
            set
            {
                mCountry = value;
            }
        }


        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }



        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }


        public int CustomerID
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }



        //function for the find public method
        public bool Find(int CustomerID)
        {
            clsDataConnection dBConnection = new clsDataConnection();
            // add the parameter for the customer id to search for
            dBConnection.AddParameter("@CustomerID", CustomerID);
            dBConnection.Execute("sproc_Customers_FilterByCustomerID");
            //IF ONE RECORD IS FOUND (THERE SHOULD BE EITHER ONE OR ZERO)
            if (dBConnection.Count == 1)

            {


                mFirstname = Convert.ToString(dBConnection.DataTable.Rows[0]["Firstname"]);
                //get the Lastname from the query results
                mLastname = Convert.ToString(dBConnection.DataTable.Rows[0]["Lastname"]);
                //get the Email from the query results
                mEmail = Convert.ToString(dBConnection.DataTable.Rows[0]["Email"]);
                //get the house no from the query results
                mHouseNo = Convert.ToString(dBConnection.DataTable.Rows[0]["HouseNo"]);
                //get the street from the query results
                mStreetname = Convert.ToString(dBConnection.DataTable.Rows[0]["Streetname"]);
                //get the post code from the query results
                mPostCode = Convert.ToString(dBConnection.DataTable.Rows[0]["PostCode"]);
                //get the address no from the query results
                mCustomerID = Convert.ToInt32(dBConnection.DataTable.Rows[0]["CustomerID"]);

                mDateAdded = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["DateAdded"]);

                mCountry = Convert.ToString(dBConnection.DataTable.Rows[0]["Country"]);

                mActive = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["Active"]);


                //always return true
                return true;
            }
            else
            {
                return false;
            }


        }
        //data member for data connection
        private clsDataConnection dBConnection = new clsDataConnection();



        //function for the public validation method
        public string Valid(string firstname,
                            string lastname,
                            string email,
                            string houseNo,
                            string streetname,
                            string county,
                            string postCode,
                            string dateAdded)
        ///this function accepts 5 parameters for validation
        ///the function returns a string containing any error message
        ///if no errors found then a blank string is returned
        {
            //var to store the error message
            string ErrMsg = "";
            DateTime DateTempt;

            //check the min length of the firstname
            if (firstname.Length == 0)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "firstname is blank. ";
            }
            //check the max length of the street
            if (firstname.Length > 50)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "firstname must be less than 50 characters. ";
            }

            //check the min length of the lastname
            if (lastname.Length == 0)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "lastname is blank. ";
            }
            //check the max length of the lastname
            if (lastname.Length > 50)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "lastname must be less than 50 characters. ";
            }

            //check the min length of the email
            if (email.Length == 0)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "email is blank. ";
            }
            //check the max length of the street
            if (email.Length > 50)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "email must be less than 20 characters. ";
            }






            //check the min length of the house no
            if (houseNo.Length == 0)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "House no is blank. ";
            }
            //check the max length of the house no
            if (houseNo.Length > 6)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "House no must be less than 6 characters. ";
            }


            //check the min length of the street
            if (streetname.Length == 0)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Street is blank. ";
            }
            //check the max length of the street
            if (streetname.Length > 50)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Street must be less than 10 characters. ";
            }



            //check the min length for the county
            if (county.Length == 0)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "county is blank. ";
            }
            //check the max length for the county
            if (county.Length > 10)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "county must be less than 10 characters. ";
            }


            //check the min length for the post code
            if (postCode.Length == 0)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Post Code is blank. ";
            }
            //check the max length for the post code
            if (postCode.Length > 9)
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Post Code must be less than 9 characters. ";
            }


            //test if the date is valid
            try//try the operation
            {
                //var to store the date

                //assign the date to the temporary var
                DateTempt = Convert.ToDateTime(dateAdded);
                if (DateTempt < DateTime.Now.Date)
                {
                    ErrMsg = ErrMsg + "The date cannot be in the future : ";
                }
            }
            catch//if it failed report an error
            {
                //set the error messsage
                ErrMsg = ErrMsg + "Date added is not valid. ";
            }
            //if there were no errors
            if (ErrMsg == "")
            {
                //return a blank string
                return "";
            }
            else//otherwise
            {
                //return the errors string value
                return "There were the following errors : " + ErrMsg;
            }
        }
    }

}
    