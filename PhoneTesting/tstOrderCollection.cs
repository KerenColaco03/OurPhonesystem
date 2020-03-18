using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace PhoneTesting
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //
            //create an instance of the class we want ot create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want ot create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign ot the property
            //in this case the dtaa needs to be alist of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 1.50;
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            //Add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two valuea are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }
        //[TestMethod]
        // public void CountPropertyOK()
        //{
        //create an instance of the class we want to create
        // clsOrderCollection AllOrders = new clsOrderCollection();
        //Create some test data to assign to the property
        // Int32 SomeCount = 2;
        //assign the data to property
        // AllOrders.Count = SomeCount;
        //test to see that the two valyues are the same
        // Assert.AreEqual(AllOrders.Count, SomeCount);

        //}
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.TotalPrice = 1.50;
            TestOrder.OrderID = 1;
            TestOrder.CustomerID = 1;
            //add the item to the test list
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values rae the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create some test data to assign to the property
            List<clsOrder> TestList = new List<clsOrder>();
            //add an tiem ot the list
            //create the iten of test data
            clsOrder TestItem = new clsOrder();
            //set its properties 
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 1.50;
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            //Add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two valuea are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an insarnce of the clas we want ot create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 1.50;
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            //set thispayment to test the data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an insatnce of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properies
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalPrice = 1.50;
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            //set ThisAddress to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the record was nor found
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void ReportByCustomerID()
        {
            //create a instance of the class containing unfilitered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            //cretae an imtance of the filitered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //aplt the nalcn stirnf should erturn al cors
            FilteredOrders.ReportByCustomerID(1);
            //tets to see that th two value ara ehe same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByCustomerIDNoneFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //apply a name that doesnt exist
            FilteredOrders.ReportByCustomerID(123456);
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }
        [TestMethod]
        public void ReportByCustomerIDTestDataFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //var to store outcome
            Boolean OK = true;
            //apply A CARDHOLDERSNAME that doesnt exist
            FilteredOrders.ReportByCustomerID(1);
            //check that the correct number of recors re found
            if (FilteredOrders.Count == 2)
            {
                //CHECK THAT THE FIRST RCORD id IS 37
                if (FilteredOrders.OrderList[0].OrderID != 36)

                {
                    OK = false;
                }
                //CHECK THAT THE ADDRESS IF 37
                if (FilteredOrders.OrderList[1].OrderID != 37)
                {
                    OK = false;

                }

            }


            else
            {
                OK = false;
            }
            //test to see that there sre nor ecprds
            Assert.IsTrue(OK);
        }
    }
}