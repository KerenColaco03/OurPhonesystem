using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace PhoneTesting
{
    [TestClass]
    public class tstProduct
    {
        //good test data
        //create some test data to pass to the mthod
        string Brand = "Apple";
        string ProductType = "Iphone11";
        string Capacity = "128gb";
        string Colour = "Red";
        string Price = "299.99";
        string ProductQuantity = "13";

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
        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign the property
            double TestData = 1.05;
            //assign the data to the property
            AProduct.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Price, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductID = 2;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //test to see that the result is correct 
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok (Assume it is)
            Boolean OK = true;
            //create some test data to use with the record
            Int32 ProductID = 3;
            //invoke teh method
            Found = AProduct.Find(ProductID);
            //check the productID
            if (AProduct.ProductID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestBrandFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 3;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the property
            if (AProduct.Brand != "Huawei")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCapacityFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 3;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the property
            if (AProduct.Capacity != "32gb")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestColourFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 3;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the property
            if (AProduct.Colour != "Black")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductTypeFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 3;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the property
            if (AProduct.ProductType != "Huawei Y6")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductQuantityFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 3;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the property
            if (AProduct.ProductQuantity != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 3;
            //invoke the method
            Found = AProduct.Find(ProductID);
            //check the property
            if (AProduct.Price != 100)
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
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AProduct.Valid(Brand,Capacity,Colour,Price,ProductQuantity,ProductType);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Brand = ""; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BrandMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Brand = "abc"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Brand = "abcd"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Brand = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Brand = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void BrandMid()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Brand = "aaaaaaaaaaaaaaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Brand = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BrandExtremeMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Brand = "";
            Brand = Brand.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductTypeMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductType = ""; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductTypeMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductType = "a"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTypeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductType = "aa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTypeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductType = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTypeMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductType = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ProductTypeMid()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductType = "aaaaaaaaaaaaaaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductTypeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductType = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductTypeExtremeMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductType = "";
            ProductType = ProductType.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CapacityMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Capacity = ""; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CapacityMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Capacity = "a"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CapacityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Capacity = "aa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CapacityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Capacity = "aaaaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CapacityMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Capacity = "aaaaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CapacityMid()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Capacity = "aaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CapacityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Capacity = "aaaaaaa"; //this should fail
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CapacityExtremeMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Capacity = "";
            Capacity = Capacity.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Colour = ""; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Colour = "a"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Colour = "aa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Colour = "aaaaaaaaaaaaaaaaaaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Colour = "aaaaaaaaaaaaaaaaaaaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ColourMid()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Colour = "aaaaaaaaaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Colour = "aaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourExtremeMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Colour = "";
            Colour = Colour.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductQuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductQuantity = ""; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductQuantityMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductQuantity = "a"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductQuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductQuantity = "aa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductQuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductQuantity = "aaaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductQuantityMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductQuantity = "aaaaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ProductQuantityMid()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductQuantity = "aaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductQuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductQuantity = "aaaaaa"; //this should fail
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductQuantityExtremeMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string ProductQuantity = "";
            ProductQuantity = ProductQuantity.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Price = ""; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Price = "aaaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Price = "aaaaa"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Price = "11111"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Price = "9999.99"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Price = "10.00"; //this should trigger an error 
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Price = "99999.99"; //this should fail
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method
            string Price = "";
            Price = Price.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AProduct.Valid(Brand, ProductType, Capacity, Colour, Price, ProductQuantity);
            //test to see that the result is coorect
            Assert.AreNotEqual(Error, "");
        }






    }
}


 