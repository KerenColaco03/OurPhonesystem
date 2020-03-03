namespace PhoneTesting
{
    public class clscustomer
    {// <summary>
     /// Summary description for clsAnAddress
     /// </summary>

        private string mFirstname;
        //mFirstname public property
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

        private string mLastname;
        //mLastname public property
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

        private string mEmail;
        //mLastname public property
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

        //houseNo private member variable
        private string mHouseNo;
            //HouseNo public property
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

            //street private member variable
            private string mStreetname;
            //Street public property
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

            //town private member variable
           

            //postCode private member variable
            private string mPostCode;
            //PostCode public property
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
        //postCode private member variable
        private string mCounty;
        //PostCode public property
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
        //countyCode private member variable
        private string mCountry;
            //CountryCode public property
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

            //dateAdded private member variable
            private DateTime mDateAdded;
            //DateAdded public property
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

            //active private member variable
            private Boolean mActive;
            //Active public property
            public Boolean Active
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

            //addressNo private member variable
            private Int32 mCustomerID;
            //AddressNo public property
            public Int32 CustomerID
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
                ErrMsg = ErrMsg + "email must be less than 50 characters. ";
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
                    ErrMsg = ErrMsg + "Street must be less than 50 characters. ";
                }
            
                
                
                //check the min length for the county
            if (county.Length == 0)
                {
                    //set the error messsage
                    ErrMsg = ErrMsg + "county is blank. ";
                }
            //check the max length for the county
            if (county.Length > 6)
                {
                    //set the error messsage
                    ErrMsg = ErrMsg + "county must be less than 50 characters. ";
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
                    DateTime Temp;
                    //assign the date to the temporary var
                    Temp = Convert.ToDateTime(dateAdded);
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

            //function for the find public method
            public Boolean Find(Int32 CustomerID)
            {
                //initialise the DBConnection
                dBConnection = new clsDataConnection();
                //add the address no parameter
                dBConnection.AddParameter("@CustomerID", CustomerID);
                //execute the query
                dBConnection.Execute("sproc_Customers_FilterByCustomerID");
                //if the record was found
                if (dBConnection.Count == 1)
                {
                //get the CustomerID 
                mCustomerID = Convert.ToInt32(dBConnection.DataTable.Rows[0]["CustomerID"]);
                //get the Firstname
                mFirstname = Convert.ToString(dBConnection.DataTable.Rows[0]["Firstname"]);
                //get the Lastname
                mLastname = Convert.ToString(dBConnection.DataTable.Rows[0]["Lastname"]);
                //get the Email
                mEmail = Convert.ToString(dBConnection.DataTable.Rows[0]["Email"]);

                //get the house no
                mHouseNo = Convert.ToString(dBConnection.DataTable.Rows[0]["HouseNo"]);
                //get the Streetname
                mStreetname = Convert.ToString(dBConnection.DataTable.Rows[0]["Streetname"]);
                //get the County
                mCounty = Convert.ToString(dBConnection.DataTable.Rows[0]["County"]);
                    //get the post code
                    mPostCode = Convert.ToString(dBConnection.DataTable.Rows[0]["PostCode"]);
                //get the Country
                mCountry = Convert.ToInt32(dBConnection.DataTable.Rows[0]["Country"]);
                    //get the date added
                    mDateAdded = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["DateAdded"]);
                    //get the acive state
                    try
                    {
                        mActive = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["Active"]);
                    }
                    catch
                    {
                        mActive = true;
                    }
                    //return success
                    return true;
                }
                else
                {
                    //return failure
                    return false;
                }
            }

        }
    }