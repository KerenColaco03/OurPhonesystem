using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace PhoneTesting
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some etst data too pass the emthod
        string OrderDate = DateTime.Now.Date.ToString();
        string CustomerID = "1";
        string TotalPrice = "Ayisha";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to cerate
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }


        [TestMethod]
        public void OrderDateOK()
        {
            //create an instance of the class we want to cerate
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the propoerty
            AnOrder.OrderDate = TestData;
            //test to see that the two vallus are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);

        }
        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to cerate
            clsOrder AnPayment = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnPayment.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.CustomerID, TestData);
        }
        [TestMethod]
        public void OrderIDOK()
        {
            //create an instance of the class we want to cerate
            clsOrder AnPayment = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnPayment.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.OrderID, TestData);
        }
        [TestMethod]
        public void TotalPriceOK()
        {
            //create an instance of the class we want to cerate
            clsOrder AnPayment = new clsOrder();
            //create some test data to assign to the property
            double TestData = 1.05;
            //assign the data to the property
            AnPayment.TotalPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.TotalPrice, TestData);
        }
        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of validation
            Boolean Found = false;
            //create some test data 
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //TEST TO SE THAT THE REUSLT IS CORRECT
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderIDFoundOK()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            //create some test data 
            Boolean OK = true;
            //create some test data to use with the mehotd
            Int32 OrderID = 2;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the OrderID
            if (AnOrder.OrderID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerIDOK()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            //create some test data 
            Boolean OK = true;
            //create some test data to use with the mehotd
            Int32 OrderID = 13;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the paymentID
            if (AnOrder.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestOrderDate()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 13;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.OrderDate != Convert.ToDateTime("16/09/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTotalPriceID()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            //create some test data 
            Boolean OK = true;
            //create some test data to use with the mehotd
            Int32 OrderID = 13;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the paymentID
            if (AnOrder.TotalPrice != 1.51)
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
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test ata
            DateTime TestDate;
            //set date to todays date
            TestDate = DateTime.Now.Date;
            //chhange the date to whatever the date is less than 10 years
            TestDate = TestDate.AddYears(-100);
            //convert the date to a string variabkle
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test ata
            DateTime TestDate;
            //set date to todays date
            TestDate = DateTime.Now.Date;
            //chhange the date to whatever the date is less than 10 years
            TestDate = TestDate.AddDays(-1);
            //convert the date to a string variabkle
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test ata
            DateTime TestDate;
            //set date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date to a string variabkle
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test ata
            DateTime TestDate;
            //set date to todays date
            TestDate = DateTime.Now.Date;
            // chhange the date to whatever the date is less than 10 years
            TestDate = TestDate.AddDays(1);
            //convert the date to a string variabkle
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test ata
            DateTime TestDate;
            //set date to todays date
            TestDate = DateTime.Now.Date;
            // chhange the date to whatever the date is less than 10 years
            TestDate = TestDate.AddYears(100);
            //convert the date to a string variabkle
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

            
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the OrderDate to a non date Value
            string OrderDate = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CustomerID = "";
                
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMin()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CustomerID = "1";//this should be OK
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CustomerID = "11";//this should faIL
             //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CustomerID = "11111";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMax()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CustomerID = "111111";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMid()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CustomerID = "111";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        public void CustomerIDMaxPlusOne()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CustomerID = "1111111";//this should faIL
            //invoke the method 
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate); 
            //test to see tat the reuslt is correct
            Assert.AreNotEqual(Error, "");
        }
        public void CustomerIDExtremeMax()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(500, '1');//this should faIL
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see tat the reuslt is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMinLessOne()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string TotalPrice = "aaa";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMin()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string TotalPrice = "aaaa";//this should be OK
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMinPlusOne()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string TotalPrice = "6011";//this should faIL
                                     //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMaxLessOne()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string TotalPrice = "11111";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMax()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string TotalPrice = "9999.99";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalPriceMid()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string TotalPrice = "11.00";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        public void TotalPriceMaxPlusOne()
        {
            //create an instance of the class we wnt to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string TotalPrice = "99999.999";//this should faIL
            //invoke the method 
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see tat the reuslt is correct
            Assert.AreNotEqual(Error, "");
        }
        public void TotalPriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string TotalPrice = "";
            TotalPrice = TotalPrice.PadRight(5000000, '1');//this should faIL
            //invoke the method
            Error = AnOrder.Valid(CustomerID, TotalPrice, OrderDate);
            //test to see tat the reuslt is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
