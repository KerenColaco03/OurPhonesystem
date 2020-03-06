using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace PhoneTesting
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //test to see that it exists
            Assert.IsNotNull(AProduct);
        }
        [TestMethod]
        public void BrandPropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign the property
            string TestData = "Apple";
            //assign the data to the property
            AProduct.Brand = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Brand, TestData);
        }
        [TestMethod]
        public void CapacityPropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign the property
            string TestData = "64gb";
            //assign the data to the property
            AProduct.Capacity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Capacity, TestData);

        }
        [TestMethod]
        public void ColourPropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign the property
            string TestData = "Grey";
            //assign the data to the property
            AProduct.Colour = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Colour, TestData);
        }
        [TestMethod]
        public void ProductTypePropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign the property
            string TestData = "Iphone 11";
            //assign the data to the property
            AProduct.ProductType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.ProductType, TestData);
        }
        [TestMethod]
        public void ProductIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign the property
            Int32 TestData = 1;
            //assign the data to the property
            AProduct.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.ProductID, TestData);
        }
        [TestMethod]
        public void ProductQuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign the property
            Int32 TestData = 1;
            //assign the data to the property
            AProduct.ProductQuantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.ProductQuantity, TestData);
        }

    }
    }

 