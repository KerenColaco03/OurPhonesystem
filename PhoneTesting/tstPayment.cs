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
    }
}
