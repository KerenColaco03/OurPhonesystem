using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace PhoneTesting
{
    [TestClass]

    public class tstSupplier
    {
        //good test data
        //create some test data to pass to the mthod
        string SupplierName = "Amazon";
        string SupplierDate = DateTime.Now.Date.ToString();
        string ProductID = "1";

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
        [TestMethod]
        public void ProductIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AProduct = new clsSupplier();
            //create some test data to assign the property
            Int32 TestData = 1;
            //assign the data to the property
            AProduct.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.ProductID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 SupplierID = 2;
            //invoke the method
            Found = ASupplier.Find(SupplierID);
            //test to see that the result is correct 
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestSupplierIDFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (Assume it is)
            Boolean OK = true;
            //create some test data to use with the record
            Int32 SupplierID = 2;
            //invoke teh method
            Found = ASupplier.Find(SupplierID);
            //check the productID
            if (ASupplier.ProductID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierID = 2;
            //invoke the method
            Found = ASupplier.Find(SupplierID);
            //check the property
            if (ASupplier.SupplierName != "Test Supplier Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierDateFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierID = 2;
            //invoke the method
            Found = ASupplier.Find(SupplierID);
            //check the property
            if (ASupplier.SupplierDate != Convert.ToDateTime("16/09/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierID = 2;
            //invoke the method
            Found = ASupplier.Find(SupplierID);
            //check the property
            if (ASupplier.ProductID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //changethe date to whatever teh data is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert teh date variable to a string variable 
            string SupplierDate = TestDate.ToString();
            //invoke the method 
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void SupplierDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //changethe date to whatever teh data is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert teh date variable to a string variable 
            string SupplierDate = TestDate.ToString();
            //invoke the method 
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierDateMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;               
            //convert teh date variable to a string variable 
            string SupplierDate = TestDate.ToString();
            //invoke the method 
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert teh date variable to a string variable 
            string SupplierDate = TestDate.ToString();
            //invoke the method 
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            //create a variable to store the test date data 
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(100);
            //convert teh date variable to a string variable 
            string SupplierDate = TestDate.ToString();
            //invoke the method 
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierDateInvalidData()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            String Error = "";
            //set the SupplierDate to a non date value
            string SupplierDate = "this is not a date";
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = ""; //this should trigger an error 
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "a"; //this should trigger an error 
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "aa"; //this should trigger an error 
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error 
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error 
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierNameMid()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "aaaaaaaaaaaaaaa"; //this should trigger an error 
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductID = ""; //this should trigger an error 
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMin()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "a"; //this should trigger an error 
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "aa"; //this should trigger an error 
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "aaaaaaaaa"; //this should trigger an error 
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "aaaaaaaaaa"; //this should trigger an error 
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ProductIDMid()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "aaaaa"; //this should trigger an error 
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "aaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductID = "";
            ProductID = ProductID.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ASupplier.Valid(SupplierName, SupplierDate, ProductID);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }



    }
}
