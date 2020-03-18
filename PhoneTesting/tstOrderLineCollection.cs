using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace PhoneTesting
{
    [TestClass]
    public class tstOrderLineCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //
            //create an instance of the class we want ot create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrderLines);
        }

        [TestMethod]
        public void OrderLineListOK()
        {
            //create an instance of the class we want ot create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create some test data to assign ot the property
            //in this case the dtaa needs to be alist of objects
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            //Add an item to the list
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //set its properties
            TestItem.ProductID = 1;
            TestItem.Quantity = 1;
            TestItem.OrderID = 1;
            TestItem.OrderLineID = 1;
            //Add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllOrderLines.OrderLineList = TestList;
            //test to see that the two valuea are the same
            Assert.AreEqual(AllOrderLines.OrderLineList, TestList);
        }
        //[TestMethod]
        //public void CountPropertyOK()
        //{
            //create an instance of the class we want to create
            //clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            ////Create some test data to assign to the property
            //Int32 SomeCount = 2;
            ////assign the data to property
           // AllOrderLines.Count = SomeCount;
            //test to see that the two valyues are the same
           // Assert.AreEqual(AllOrderLines.Count, SomeCount);

        //}
        [TestMethod]
        public void ThisOrderLinePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //Create some test data to assign to the property
            clsOrderLine TestOrderLine = new clsOrderLine();
            TestOrderLine.ProductID = 1;
            TestOrderLine.Quantity = 1;
            TestOrderLine.OrderID = 1;
            TestOrderLine.OrderLineID = 1;
            //add the item to the test list
            //assign the data to the property
            AllOrderLines.ThisOrderLine = TestOrderLine;
            //test to see that the two values rae the same
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestOrderLine);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //Create some test data to assign to the property
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            //add an tiem ot the list
            //create the iten of test data
            clsOrderLine TestItem = new clsOrderLine();
            //set its properties 
            TestItem.ProductID = 1;
            TestItem.Quantity = 1;
            TestItem.OrderID = 1;
            TestItem.OrderLineID = 1;
            //Add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllOrderLines.OrderLineList = TestList;
            //test to see that the two valuea are the same
            Assert.AreEqual(AllOrderLines.Count, TestList.Count);

        }
        //[TestMethod]
        // public void TwoRecordPresent()
        //{
        ////create an instacne of the clas we want it cREATE
        //clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
        // //test to see that thew two values ra ethe same
        // Assert.AreEqual(AllOrderLines.Count, 2);
        //}
        [TestMethod]
        public void AddMethodOK()
        {
            //create an insarnce of the clas we want ot create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create the item of the test data
            clsOrderLine TestItem = new clsOrderLine();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductID = 1;
            TestItem.Quantity = 1;
            TestItem.OrderID = 1;
            TestItem.OrderLineID = 1;
            //set thispayment to test the data
            AllOrderLines.ThisOrderLine = TestItem;
            //add the record
            PrimaryKey = AllOrderLines.Add();
            //set the primary key of the test data
            TestItem.OrderLineID = PrimaryKey;
            //find the record
            AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an insatnce of the class we want to create
            clsOrderLineCollection AllPayments = new clsOrderLineCollection();
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properies
            TestItem.ProductID = 1;
            TestItem.Quantity = 1;
            TestItem.OrderID = 1;
            TestItem.OrderLineID = 1;
            //set ThisAddress to the test data
            AllPayments.ThisOrderLine = TestItem;
            //add the record
            PrimaryKey = AllPayments.Add();
            //set the primary key of the test data
            TestItem.OrderLineID = PrimaryKey;
            //find the record
            AllPayments.ThisOrderLine.Find(PrimaryKey);
            AllPayments.Delete();
            //now find the record
            Boolean Found = AllPayments.ThisOrderLine.Find(PrimaryKey);
            //test to see that the record was nor found
            Assert.IsFalse(Found);


        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an insatnce of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            /// /create the item of the test data
            clsOrderLine TestItem = new clsOrderLine();
            //var to stoe the primary key
            Int32 PrimaryKey = 0;
            //set its propeties 
            TestItem.ProductID = 1;
            TestItem.Quantity = 1;
            TestItem.OrderID = 1;

            //set ThisPayment to the tets data
            AllOrderLines.ThisOrderLine = TestItem;
            //add the record
            PrimaryKey = AllOrderLines.Add();
            //set the primary key if the test data 
            TestItem.OrderLineID = PrimaryKey;
            //modify the test data
            TestItem.ProductID = 1;
            TestItem.Quantity = 1;
            TestItem.OrderID = 1;

            //set the record based on the new test data
            AllOrderLines.ThisOrderLine = TestItem;
            //updtae the record
            AllOrderLines.Update();
            //find the record
            AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            //test to see ThisPayment matches th etest data
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestItem);


        }
    }
}
