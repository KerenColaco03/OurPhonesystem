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
            TestItem.Price = 1.50;
            TestItem.Colour = "Black";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ProductList, TestList);
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
            TestProduct.Price = 1.50;
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
            TestItem.Price = 1.50;
            TestItem.Colour = "Grey";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsProductCollection AllProducts = new clsProductCollection();
            //create the item of the test data
            clsProduct TestItem = new clsProduct();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductID = 1;
            TestItem.Brand = "Samsung";
            TestItem.ProductType = "Iphone 11 pro";
            TestItem.Capacity = "128gb";
            TestItem.ProductQuantity = 1;
            TestItem.Price = 1.50;
            TestItem.Colour = "Grey";
            //set ThisProduct to the test data
            AllProducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProducts.Add();
            //set the primary key to test data
            TestItem.ProductID = PrimaryKey;
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsProductCollection AllProducts = new clsProductCollection();
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductID = 1;
            TestItem.Brand = "Samsung";
            TestItem.ProductType = "Iphone 11 pro";
            TestItem.Capacity = "128gb";
            TestItem.ProductQuantity = 1;
            TestItem.Price = 1.50;
            TestItem.Colour = "Grey";
            //set ThisProduct to the test data
            AllProducts.ThisProduct = TestItem;
            //add the record 
            AllProducts.Add();
            //set the primary key of the test data 
            TestItem.Find(PrimaryKey);
            //delete the record 
            AllProducts.Delete();
            //now find the record 
            Boolean Found = AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see taht the record was noy found
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //create the item of the test data
            clsProduct TestItem = new clsProduct();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Brand = "Samsung";
            TestItem.ProductType = "Iphone 11 pro";
            TestItem.Capacity = "128gb";
            TestItem.ProductQuantity = 1;
            TestItem.Price = 1.50;
            TestItem.Colour = "Grey";
            //set ThisProduct to the test data
            AllProducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProducts.Add();
            //set the primary key of the test data 
            TestItem.ProductID = PrimaryKey;
            //modify the test data
            TestItem.Brand = "Nokia";
            TestItem.ProductType = "Nokia 1";
            TestItem.Capacity = "32gb";
            TestItem.ProductQuantity = 5;
            TestItem.Price = 50.99;
            TestItem.Colour = "Black";
            //set the record based on the new test data
            AllProducts.ThisProduct = TestItem;
            //update the record 
            AllProducts.Update();
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that ThisProduct matches the test data
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }
        [TestMethod]
        public void ReportByProductTypeOK()
        {
            //create an instance of the class contaning unfiltered results
            clsProductCollection AllProducts = new clsProductCollection();
            //create an instance of the filtered data 
            clsProductCollection FilteredProducts = new clsProductCollection();
            //apply a blank string (should return all records);
            FilteredProducts.ReportByProductType("");
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, FilteredProducts.Count);
        }

        [TestMethod]
        public void ReportByProductTypeNoneFound()
        {
            //create an instance of filtered data
            clsProductCollection FilteredProducts = new clsProductCollection();
            //apply a product type that doesnt exist 
            FilteredProducts.ReportByProductType("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredProducts.Count);
        }
        [TestMethod]
        public void ReportByProductTypeTestDataFound()
        {
            //create an instance of the filtered data
            clsProductCollection FilteredProducts = new clsProductCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a product type that doesnt exist 
            FilteredProducts.ReportByProductType("yyy yyy");
            //check that the correct number pf records are found
            if (FilteredProducts.Count == 2)
            {
                //check that teh first record is ID 36
                if (FilteredProducts.ProductList[0].ProductID != 36)
                {
                    OK = false;
                }
                //check taht the first record is ID 37
                if (FilteredProducts.ProductList[1].ProductID != 37)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }

}

