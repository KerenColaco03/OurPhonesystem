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
            //
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
        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //create an instance of the class we want to create
        // clsPaymentCollection AllPayments = new clsPaymentCollection();
        //Create some test data to assign to the property
        // Int32 SomeCount = 2;
        // //assign the data to property
        // AllPayments.Count = SomeCount;
        // //test to see that the two valyues are the same
        // Assert.AreEqual(AllPayments.Count, SomeCount);

        // }
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
            Assert.AreEqual(AllPayments.ThisPayment, TestPayment);

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
        //clsPaymentCollection AllPayments = new clsPaymentCollection();
        // AllPayments.ThisPayment.Find(); !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!



        [TestMethod]
        public void AddMethodOK()
        {
            //create an insarnce of the clas we want ot create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create the item of the test data
            clsPayment TestItem = new clsPayment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CardExpiry = DateTime.Now.Date;
            TestItem.CardHoldersName = "a";
            TestItem.CardNo = 1;
            TestItem.OrderID = 1;
            TestItem.PaymentID = 1;
            //set thispayment to test the data
            AllPayments.ThisPayment = TestItem;
            //add the record
            PrimaryKey = AllPayments.Add();
            //set the primary key of the test data
            TestItem.PaymentID = PrimaryKey;
            //find the record
            AllPayments.ThisPayment.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.ThisPayment, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an insatnce of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create the item of test data
            clsPayment TestItem = new clsPayment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properies
            TestItem.CardExpiry = DateTime.Now.Date;
            TestItem.CardHoldersName = "a";
            TestItem.CardNo = 1;
            TestItem.OrderID = 1;
            TestItem.PaymentID = 1;
            //set ThisAddress to the test data
            AllPayments.ThisPayment = TestItem;
            //add the record
            PrimaryKey = AllPayments.Add();
            //set the primary key of the test data
            TestItem.PaymentID = PrimaryKey;
            //find the record
            AllPayments.ThisPayment.Find(PrimaryKey);
            AllPayments.Delete();
            //now find the record
            Boolean Found = AllPayments.ThisPayment.Find(PrimaryKey);
            //test to see that the record was nor found
            Assert.IsFalse(Found);


        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an insatnce of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            /// /create the item of the test data
            clsPayment TestItem = new clsPayment();
            //var to stoe the primary key
            Int32 PrimaryKey = 0;
            //set its propeties 
            TestItem.CardExpiry = DateTime.Now.Date;
            TestItem.CardHoldersName = "a";
            TestItem.CardNo = 1;
            TestItem.OrderID = 1;
            //set ThisPayment to the tets data
            AllPayments.ThisPayment = TestItem;
            //add the record
            PrimaryKey = AllPayments.Add();
            //set the primary key if the test data 
            TestItem.PaymentID = PrimaryKey;
            //modify the test data
            TestItem.CardExpiry = DateTime.Now.Date;
            TestItem.CardHoldersName = "aa";
            TestItem.CardNo = 3;
            TestItem.OrderID = 3;
            //set the record based on the new test data
            AllPayments.ThisPayment = TestItem;
            //updtae the record
            AllPayments.Update();
            //find the record
            AllPayments.ThisPayment.Find(PrimaryKey);
            //test to see ThisPayment matches th etest data
            Assert.AreEqual(AllPayments.ThisPayment, TestItem);


        }
        [TestMethod]
        public void ReportByCardHoldersName()
        {
            //create a instance of the class containing unfilitered results
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //cretae an imtance of the filitered data
            clsPaymentCollection FilteredPayments = new clsPaymentCollection();
            //aplt the nalcn stirnf should erturn al cors
            FilteredPayments.ReportByCardHoldersName("");
            //tets to see that th two value ara ehe same
            Assert.AreEqual(AllPayments.Count, FilteredPayments.Count);
        }
        [TestMethod]
        public void ReportByCardHoldersNameNoneFound()
        {
            //create an instance of the filtered data
            clsPaymentCollection FilteredPayments = new clsPaymentCollection();
            //apply a name that doesnt exist
            FilteredPayments.ReportByCardHoldersName("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredPayments.Count);
        }
        [TestMethod]
        public void ReportByCardHoldersNameTestDataFound()
        {
            //create an instance of the filtered data
            clsPaymentCollection FilteredPayments = new clsPaymentCollection();
            //var to store outcome
            Boolean OK = true;
            //apply A CARDHOLDERSNAME that doesnt exist
            FilteredPayments.ReportByCardHoldersName("a");
            //check that the correct number of recors re found
            if (FilteredPayments.Count == 2)
            {
                //CHECK THAT THE FIRST RCORD id IS 37
                if (FilteredPayments.PaymentList[0].PaymentID != 36)

                {
                    OK = false;
                }
                //CHECK THAT THE ADDRESS IF 37
                if (FilteredPayments.PaymentList[1].PaymentID != 37)
                {
                    OK = false;

                }

            }


            else
            {
                OK = false;
            }
            //test to see that there are nor records
            Assert.IsTrue(OK);
        }
    }
}


