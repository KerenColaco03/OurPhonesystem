using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace PhoneTesting
{
    [TestClass]
    public class tstOrderLine
    {
        //
        //good test data
        //create some test data too pass the method

      
        string Quantity = "Ayisha";
        

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to cerate
            clsOrderLine AnOrder = new clsOrderLine();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
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
        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we wnt to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of validation
            Boolean Found = false;
            //create some test data 
            Int32 OrderLineID = 1;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //TEST TO SE THAT THE REUSLT IS CORRECT
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderLineIDFound()
        {
            //create an instance of the class we wnt to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            //create some test data 
            Boolean OK = true;
            //create some test data to use with the mehotd
            Int32 OrderLineID = 2;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //check the OrderLineID
            if (AnOrderLine.OrderLineID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we wnt to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            //create some test data 
            Boolean OK = true;
            //create some test data to use with the mehotd
            Int32 OrderLineID = 13;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //check the paymentID
            if (AnOrderLine.OrderID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we wnt to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            //create some test data 
            Boolean OK = true;
            //create some test data to use with the mehotd
            Int32 OrderLineID = 13;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //check the paymentID
            if (AnOrderLine.ProductID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestQuanityFound()
        {
            //create an instance of the class we wnt to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            //create some test data 
            Boolean OK = true;
            //create some test data to use with the mehotd
            Int32 OrderLineID = 13;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //check the paymentID
            if (AnOrderLine.Quantity != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we wnt to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrderLine.Valid(Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class we wnt to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string Quantity = "";
            //invoke the method
            Error = AnOrderLine.Valid( Quantity);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityIDMin()
        {
            //create an instance of the class we wnt to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string Quantity = "1";//this should be OK
            //invoke the method
            Error = AnOrderLine.Valid( Quantity);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we wnt to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string Quantity = "11";//this should faIL
            //invoke the method
            Error = AnOrderLine.Valid( Quantity);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we wnt to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string Quantity = "";
            Quantity = Quantity.PadRight(49, '1');
            //invoke the method
            Error = AnOrderLine.Valid( Quantity);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we wnt to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string Quantity = "";
            Quantity = Quantity.PadRight(50, '1');
            //invoke the method
            Error = AnOrderLine.Valid(Quantity);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we wnt to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string Quantity = "012345678901234567891234";
            //invoke the method
            Error = AnOrderLine.Valid(Quantity);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we wnt to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string Quantity = "";//this should faIL
            Quantity = Quantity.PadRight(51, '1');
            //invoke the method
            Error = AnOrderLine.Valid(Quantity);
            //test to see tat the reuslt is correct
            Assert.AreNotEqual(Error, "");
        }
        public void QuantityExtremeMax()
        {
            //create an instance of the class we wnt to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string Quantity = "";
            Quantity = Quantity.PadRight(500, '1');//this should faIL
             //invoke the method
            Error = AnOrderLine.Valid(Quantity);
            //test to see tat the reuslt is correct
            Assert.AreNotEqual(Error, "");

        }
    }
}
              