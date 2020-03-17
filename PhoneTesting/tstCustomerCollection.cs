using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;


namespace PhoneTesting
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists 
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clscustomer> TestList = new List<clscustomer>();
            //add an item to the list
            //create the item of test data
            clscustomer TestItem = new clscustomer();
            //set its properties
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
            TestItem.Country = "Some country";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllCustomers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }
        [TestMethod]
        public void ThisCustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property

            //create the item of test data
            clscustomer TestCustomer = new clscustomer();
            //set its properties
            TestCustomer.Active = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.Email = "kabir@yahoo.com";
            TestCustomer.PostCode = "LE2 7HY";
            TestCustomer.Streetname = "some street";
            TestCustomer.HouseNo = "123a";
            TestCustomer.Firstname = "kabzy";
            TestCustomer.Lastname = "farouq";
            TestCustomer.DateAdded = DateTime.Now.Date;
            TestCustomer.County = "12h";
            //add the item to the test list

            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.CustomerList, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clscustomer> TestList = new List<clscustomer>();
            //add an item to the list
            //create the item of test data
            clscustomer TestItem = new clscustomer();
            //set its properties
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
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, 2);
        }
          

        }
    }

