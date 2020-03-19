  using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneTesting;


namespace PhoneTesting
{
    /// <summary>
    /// Summary description for tstCustomer
    /// </summary>
    [TestClass]
    public class tstCustomer
    {
        // good test data 
        //create some test data to pass to the method 
        string Firstname = "kabir";
        string Lastname = "Farouq";
        string Email = "kabir@yahoo.com";
        string HouseNo = "12s";
        string Streetname = "some street";
        string County = "Leicestershire";
        string PostCode = "LE2 7HY";
        string DateAdded = DateTime.Now.Date.ToString();


        public tstCustomer()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clscustomer ACustomer = new clscustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }
        [TestMethod]
        public void FirstnamePropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "kabir";
            //assign the data to the property
            ACustomer.Firstname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Firstname, TestData);
        }
        public void LastnamePropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "Farouq";
            //assign the data to the property
            ACustomer.Lastname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Lastname, TestData);
        }
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "kabir@yahoo.com";
            //assign the data to the property
            ACustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }
        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            ACustomer.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.HouseNo, TestData);
        }
        [TestMethod]
        public void StreetnamePropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            ACustomer.Streetname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Streetname, TestData);
        }

        [TestMethod]
        public void CountyPropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "Leicestershire";
            //assign the data to the property
            ACustomer.County = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.County, TestData);
        }
        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            ACustomer.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PostCode, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //ASSIGN the data to the property
            ACustomer.DateAdded = TestData;
            //Test to see that the two values are the same 
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }


        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create 
            clscustomer ACustomer = new clscustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //Assign the data to the property
            ACustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void CountryPropertyOK()
        {
            //create an instance of the class we want to create 
            clscustomer ACustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "Nigeria";
            //Assign the data to the property
            ACustomer.Country = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Country, TestData);
        }






        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create instance of the class we wnat to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of the test data
            clscustomer TestItem = new clscustomer();
            Int32 Primarykey = 0;
            //set its properyties 
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.Email = "kabir@yahoo.com";
            TestItem.PostCode = "LE2 7HY";
            TestItem.Streetname = "some street";
            TestItem.HouseNo = "123a";
            TestItem.Firstname = "kabzy";
            TestItem.Lastname = "farouq";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.County = "12h";
            TestItem.Country = "some county";
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            Primarykey = AllCustomers.Add();
            //set the primary key of the test data 
            TestItem.CustomerID = Primarykey;
            //find the record
            AllCustomers.ThisCustomer.Find(Primarykey);
            //Delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(Primarykey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);
            // 
            //
        }
        [TestMethod]
        public void AddMethodOK()
        {
            // Create instance of the class we wnat to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of the test data
            clscustomer TestItem = new clscustomer();
            Int32 Primarykey = 0;
            //set its properyties 
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.Email = "kabir@yahoo.com";
            TestItem.PostCode = "LE2 7HY";
            TestItem.Streetname = "some street";
            TestItem.HouseNo = "123a";
            TestItem.Firstname = "kabzy";
            TestItem.Lastname = "farouq";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.County = "12h";
            TestItem.Country = "some country";
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            Primarykey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = Primarykey;
            //find the record
            AllCustomers.ThisCustomer.Find(Primarykey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

            // 
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            // Create instance of the class we wnat to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of the test data
            clscustomer TestItem = new clscustomer();
            Int32 Primarykey = 0;
            //set its properyties 

            TestItem.Firstname = "kabzy";
            TestItem.Lastname = "farouq";
            TestItem.Email = "kabir@yahoo.com";
           
            TestItem.HouseNo = "123a";
            TestItem.Streetname = "some street";
            TestItem.County = "12h";
            TestItem.PostCode = "LE2 7HY";
            TestItem.Country = "Nigeria";
            TestItem.DateAdded = DateTime.Now.Date;
            
           
            TestItem.Active = true;
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            Primarykey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = Primarykey;
            //modify the test data
            TestItem.Firstname = "kabzy";
            TestItem.Lastname = "farouq";
            TestItem.Email = "kabir@yahoo.com";

            TestItem.HouseNo = "123a";
            TestItem.Streetname = "some street";
            TestItem.County = "12h";
            TestItem.PostCode = "LE2 7HY";
            TestItem.Country = "Nigeria";
            TestItem.DateAdded = DateTime.Now.Date;


            TestItem.Active = true;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(Primarykey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

            // 
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            string Error = "";
            //invoke the method 
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            //create an instance of the class containing unfiltere results 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtere data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredCustomers.ReportByPostCode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);

        }
        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            //create an instance of the class containing unfiltere results 
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredCustomers.ReportByPostCode("");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredCustomers.Count);

        }
        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            //create an instance of the class containing unfiltere results 
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //Var to store outcome 
            Boolean OK = true;
            //apply a postcode that doesn't exist
            FilteredCustomers.ReportByPostCode("yyy yyy");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredCustomers.CustomerList[0].CustomerID != 36)
                    {
                    OK = false;
                }
                //CHECK THAT THE FIRST RECORD IS aID 37
                if (FilteredCustomers.CustomerList[1].CustomerID != 37)
                    {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //TEST TO SEE THAT THERE ARE NO RECORDS 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE 
            clscustomer ACustomer = new clscustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some text data to use with the method
            Int32 CustomerID =1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);


        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE 
            clscustomer ACustomer = new clscustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;

            //create some text data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStreetnameFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE 
            clscustomer ACustomer = new clscustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;

            //create some text data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the Streetname
            if (ACustomer.Streetname != "streetname")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestCountyFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE 
            clscustomer ACustomer = new clscustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;

            //create some text data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the County 
            if (ACustomer.County != "Test County")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestPostCodeFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE 
            clscustomer ACustomer = new clscustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;

            //create some text data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the PostCode 
            if (ACustomer.PostCode != "xxx xxx")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestCountryFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE 
            clscustomer ACustomer = new clscustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;

            //create some text data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the Country 
            if (ACustomer.Country != "Test Country")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestDateAddedFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE 
            clscustomer ACustomer = new clscustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;

            //create some text data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the DateAdded 
            if (ACustomer.DateAdded != Convert.ToDateTime("17/04/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestActiveFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE 
            clscustomer ACustomer = new clscustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;

            //create some text data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the Active 
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestFirstnameFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE 
            clscustomer ACustomer = new clscustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;

            //create some text data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the Firstname 
            if (ACustomer.Firstname != "Test Firstname")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestLastnameFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE 
            clscustomer ACustomer = new clscustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;

            //create some text data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the Lastname 
            if (ACustomer.Lastname != "Test Lastname")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestEmailFound()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE 
            clscustomer ACustomer = new clscustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;

            //create some text data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the Email 
            if (ACustomer.Email != "Test Email")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }
       
        [TestMethod]
        public void FirstnameMinLessOne()
        {
            //create an instance of the class we want to create 
            clscustomer ACustomer = new clscustomer();
            // string variable to store any error message
            string Error = "";
            //create some test data to pass the method
            string Firstname = ""; //this should trigger an error 
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //TEST TO SEE THAT THE RESULT IS CORRECT
            Assert.AreNotEqual(Error, "");

        }
        public void FirstnameMin()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Firstname = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Firstname = "aa"; //is should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Firstname = ""; //this should be ok
            Firstname = Firstname.PadRight(30, 'a');
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstnameMax()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Firstname = ""; //this should be ok
            //invoke the method
            Firstname = Firstname.PadRight(31, 'a');
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMid()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Firstname = ""; //this should be ok
            //invoke the method

            Firstname = Firstname.PadRight(16, 'a');
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Firstname = ""; //this should be ok
            //invoke the method
            Firstname = Firstname.PadRight(32, 'a');
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstnameExtremeMax()

        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Firstname = "";
            Firstname = Firstname.PadRight(500, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastnameMinLessOne()
        {
            //create an instance of the class we want to create 
            clscustomer ACustomer = new clscustomer();
            // string variable to store any error message
            string Error = "";
            //create some test data to pass the method
            string Lastname = ""; //this should trigger an error 
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //TEST TO SEE THAT THE RESULT IS CORRECT
            Assert.AreNotEqual(Error, "");

        }
        public void LastnameMin()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Lastname = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Lastname = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Lastname = "aaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastnameMax()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Lastname = "aaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMid()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Lastname = "aaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Lastname = "aaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastnameExtremeMax()

        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Lastname = "aaaaaa";
            Firstname = Lastname.PadRight(500, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create 
            clscustomer ACustomer = new clscustomer();
            // string variable to store any error message
            string Error = "";
            //create some test data to pass the method
            string Email = ""; //this should trigger an error 
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //TEST TO SEE THAT THE RESULT IS CORRECT
            Assert.AreNotEqual(Error, "");

        }
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(100, 'a');
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(40, 'a');
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should be ok
            Email = Email.PadRight(81, 'a');
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailExtremeMax()

        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(600, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void HouseNoMinLessOne()
        {
            //create an instance of the class we want to create 
            clscustomer ACustomer = new clscustomer();
            // string variable to store any error message
            string Error = "";
            //create some test data to pass the method
            string HouseNo = ""; //this should trigger an error 
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //TEST TO SEE THAT THE RESULT IS CORRECT
            Assert.AreNotEqual(Error, "");

        }
        public void HouseNoMin()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoMax()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMid()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoExtremeMax()

        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaaa";
            HouseNo = HouseNo.PadRight(500, 'A');//this should be ok
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

       
        
        [TestMethod]
        public void StreetnameMinLessOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Streetname = "";
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetnameMin()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Streetname = "a";
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Streetname = "aa";
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Streetname = "";
            Streetname = Streetname.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetnameMax()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Streetname = "";
            Streetname = Streetname.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Streetname = "";
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetnameMid()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Streetname = "";
            Streetname = Streetname.PadRight(10, 'a');
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMinLessOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string County = "";
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CountyMin()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string County = "a";
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMinPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string County = "aa";
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CountyMaxLessOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string County = "AAAA";
           
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMax()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string County = "AAAAA";
   
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CountyMaxPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string County = "";
            County = County.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CountyMid()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string County = "AAA";
           
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "";
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "a";
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aa";
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "aaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaa";
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the data to whatever the data is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clscustomer ACustomer = new clscustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date";
            //invoke the method
            Error = ACustomer.Valid(Firstname, Lastname, Email, HouseNo, Streetname, County, PostCode, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}