using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace PhoneTesting
{
    [TestClass]
    public class tstOrderLine
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to cerate
            clsOrderLine AnOrder = new clsOrderLine();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
        public void OrderIDOK()
        {
            //create an instance of the class we want to cerate
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.OrderID, TestData);
        }
        [TestMethod]
        public void OrderLineIDOK()
        {
            //create an instance of the class we want to cerate
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.OrderLineID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.OrderLineID, TestData);
        }
        [TestMethod]
        public void ProductIDOK()
        {
            //create an instance of the class we want to cerate
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.ProductID, TestData);
        }
        [TestMethod]
        public void QuantityOK()
        {
            //create an instance of the class we want to cerate
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.Quantity, TestData);
        }
        
    }
}
