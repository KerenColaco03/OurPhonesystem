using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace PhoneTesting
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(ASupplier);
        }
        [TestMethod]
        public void SupplierDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ASupplier.SupplierDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierDate, TestData);
        }
        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign the property
            string TestData = "Some Supplier";
            //assign the data to the property
            ASupplier.SupplierName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierName, TestData);
        }
        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign the property
            Int32 TestData = 1;
            //assign the data to the property
            ASupplier.SupplierID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierID, TestData);
        }
    }
}
