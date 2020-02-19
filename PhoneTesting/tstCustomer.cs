using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //test to see that it exists
            Assert.IsNotNull(Acustomer);

        }

        [TestMethod]
        public void CountryPropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "Nigeria";
            //assign the data to the property
            Acustomer.Country = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.Country, TestData);
        }


        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Acustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Acustomer.CountyNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.CountyNo, TestData);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            Acustomer.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.HouseNo, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            Acustomer.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.PostCode, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            Acustomer.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.Street, TestData);
        }

        [TestMethod]
        public void UsernamePropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "Kabzy";
            //assign the data to the property
            Acustomer.Username = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.Username, TestData);

        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "Kabzy100";
            //assign the data to the property
            Acustomer.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.Password, TestData);

        }

        [TestMethod]
        public void FirstnamePropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "Umar";
            //assign the data to the property
            Acustomer.Firstname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.Firstname, TestData);

        }

        [TestMethod]
        public void LastnamePropertyOK()
        {
            //create an instance of the class we want to create
            clscustomer Acustomer = new clscustomer();
            //create some test data to assign to the property
            string TestData = "Farouq";
            //assign the data to the property
            Acustomer.Lastname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Acustomer.Lastname, TestData);
        }
    }
}

       
