using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;
using System.Collections.Generic;
namespace PhoneTesting
{
    [TestClass]
    public class tstPaymentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want ot create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //test to see that it exists
            Assert.IsNotNull(AllPayments);
        }

        [TestMethod]
        public void PaymentListOK()
        {
            //create an instance of the class we want ot create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some test data to assign ot the property
            //in this case the dtaa needs to be alist of objects
            List<clsPayment> TestList = new List<clsPayment>();
            //Add an item to the list
            //create the item of test data
            clsPayment TestItem = new clsPayment();
            //set its properties
            TestItem.CardExpiry = DateTime.Now.Date;
            TestItem.CardHoldersName = "a";
            TestItem.CardNo = 1;
            TestItem.OrderID = 1;
            TestItem.PaymentID = 1;
            //Add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllPayments.PaymentList = TestList;
            //test to see that the two valuea are the same
            Assert.AreEqual(AllPayments.PaymentList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //Create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to property
            AllPayments.Count = SomeCount;
            //test to see that the two valyues are the same
            Assert.AreEqual(AllPayments.Count, SomeCount);

        }
        [TestMethod]
        public void ThisPaymentPropertyOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //Create some test data to assign to the property
            clsPayment TestPayment = new clsPayment();
            TestPayment.CardExpiry = DateTime.Now.Date;
            TestPayment.CardHoldersName = "a";
            TestPayment.CardNo = 1;
            TestPayment.OrderID = 1;
            TestPayment.PaymentID = 1;
            //add the item to the test list
            //assign the data to the property
            AllPayments.ThisPayment = TestPayment;
            //test to see that the two values rae the same
            Assert.AreEqual(AllPayments.ThisPayment,TestPayment);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //Create some test data to assign to the property
            List<clsPayment> TestList = new List<clsPayment>();
            //add an tiem ot the list
            //create the iten of test data
            clsPayment TestItem = new clsPayment();
            //set its properties
            TestItem.CardExpiry = DateTime.Now.Date;
            TestItem.CardHoldersName = "a";
            TestItem.CardNo = 1;
            TestItem.OrderID = 1;
            TestItem.PaymentID = 1;
            //Add the item to the test list
            TestList.Add(TestItem);
            //asign the data to the property
            AllPayments.PaymentList = TestList;
            //test to see that the two valuea are the same
            Assert.AreEqual(AllPayments.Count, TestList.Count);

        }
    }
}