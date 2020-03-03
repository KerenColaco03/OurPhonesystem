using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace PhoneTesting
{
    [TestClass]
    public class tstPayment
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to cerate
            clsPayment AnOrder = new clsPayment();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void CardExpiryOK()
        {
            //create an instance of the class we want to cerate
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the propoerty
            AnPayment.CardExpiry = TestData;
            //test to see that the two vallus are the same
            Assert.AreEqual(AnPayment.CardExpiry, TestData);

        }
        [TestMethod]
        public void CardHoldersNameOK()
        {
            //create an instance of the class we want to cerate
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property
            string TestData = "a";
            //assign the data to the property
            AnPayment.CardHoldersName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.CardHoldersName, TestData);
        }
        [TestMethod]
        public void CardNoOK()
        {
            //create an instance of the class we want to cerate
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnPayment.CardNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.CardNo, TestData);
        }
        [TestMethod]
        public void OrderIDOK()
        {
            //create an instance of the class we want to cerate
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnPayment.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.OrderID, TestData);
        }
        [TestMethod]
        public void PaymentIDOK()
        {
            //create an instance of the class we want to cerate
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnPayment.PaymentID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.PaymentID, TestData);
        }
    }
   }
