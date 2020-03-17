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
            
                
                }

        public string Valid(string firstname, string lastname, string email, string houseNo, string streetname, string county, string postCode, string dateAdded)
        {
            throw new NotImplementedException();
        }
    }

        }
    