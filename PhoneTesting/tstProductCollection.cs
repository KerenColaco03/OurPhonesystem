using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace PhoneTesting
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //test to see that it exists
            Assert.IsNotNull(AllProducts);
        }
        [TestMethod]
        public void ProductListOK()
        {
            //create an instance of the class we want to create 
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsProduct> TestList = new List<clsProduct>();
            //add an item to the list
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.Brand = "Apple";
            TestItem.ProductID = 1;
            TestItem.ProductType = "Iphone X";
            TestItem.Capacity = "64gb";
            TestItem.ProductQuantity = 1;
            //TestItem.Price
            TestItem.Colour = "Black";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ProductList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllProducts.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, SomeCount);

        }
        [TestMethod]
        public void ThisProductPropertyOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            clsProduct TestProduct = new clsProduct();
            //set the properties of the test object
            TestProduct.Brand = "Apple";
            TestProduct.ProductID = 1;
            TestProduct.ProductType = "Iphone 11 pro";
            TestProduct.Capacity = "128gb";
            TestProduct.ProductQuantity = 1;
            //TestProduct.Price
            TestProduct.Colour = "Grey";
            //assign the data to the property
            AllProducts.ThisProduct = TestProduct;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsProductCollection AllProducts = new clsProductCollection();
            //create some test data to assign to the property
            //in this case the data neeeds to be a list of objects 
            List<clsProduct> TestList = new List<clsProduct>();
            //add an item to the list
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.Brand = "Apple";
            TestItem.ProductID = 1;
            TestItem.ProductType = "Iphone 11 pro";
            TestItem.Capacity = "128gb";
            TestItem.ProductQuantity = 1;
            //TestProduct.Price
            TestItem.Colour = "Grey";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }


        }
    }
