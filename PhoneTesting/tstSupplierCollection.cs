using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace PhoneTesting
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //test to see that it exists
            Assert.IsNotNull(AllSuppliers);
        }
        [TestMethod]
        public void SupplierListOK()
        {
            //create an instance of the class we want to create 
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.SupplierName = "Amazon";
            TestItem.SupplierID = 1;
            TestItem.SupplierDate = DateTime.Now.Date;
            TestItem.ProductID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSuppliers.SupplierList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            clsSupplier TestSupplier = new clsSupplier();
            //set the properties of the test object
            TestSupplier.SupplierName = "Amazon";
            TestSupplier.ProductID = 1;
            TestSupplier.SupplierID = 1;
            TestSupplier.SupplierDate = DateTime.Now.Date;
            //assign the data to the property
            AllSuppliers.ThisSupplier = TestSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create some test data to assign to the property
            //in this case the data neeeds to be a list of objects 
            List<clsSupplier> TestList = new List<clsSupplier>();
            //add an item to the list
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //set its properties
            TestItem.SupplierName = "Amazon";
            TestItem.ProductID = 1;
            TestItem.SupplierDate = DateTime.Now.Date;
            TestItem.SupplierID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllSuppliers.SupplierList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Amazon";
            TestItem.SupplierDate = DateTime.Now.Date;
            TestItem.ProductID = 1;
            //set ThisProduct to the test data
            AllSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key to test data
            TestItem.SupplierID = PrimaryKey;
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create the item of test data
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Amazon";
            TestItem.SupplierDate = DateTime.Now.Date;
            TestItem.ProductID = 1;
            //set ThisProduct to the test data
            AllSuppliers.ThisSupplier = TestItem;
            //add the record 
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test data 
            TestItem.Find(PrimaryKey);
            //delete the record 
            AllSuppliers.Delete();
            //now find the record 
            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see taht the record was noy found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.SupplierName = "Currys";
            TestItem.SupplierDate = DateTime.Now.Date;
            TestItem.ProductID = 1;
            //set ThisProduct to the test data
            AllSuppliers.ThisSupplier = TestItem;
            //add the record
            PrimaryKey = AllSuppliers.Add();
            //set the primary key of the test data 
            TestItem.SupplierID = PrimaryKey;
            //modify the test data
            TestItem.SupplierName = "Carphone Warehouse";
            TestItem.SupplierDate = DateTime.Now.Date;
            TestItem.ProductID = 2;
            //set the record based on the new test data
            AllSuppliers.ThisSupplier = TestItem;
            //update the record 
            AllSuppliers.Update();
            //find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            //test to see that ThisProduct matches the test data
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void ReportBySupplierNameOK()
        {
            //create an instance of the class contaning unfiltered results 
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            //create an instance of teh filtered data
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            //apply a blank string (should return all records)
            FilteredSuppliers.ReportBySupplierName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count);
        }

        [TestMethod]
        public void ReportBySupplierNameNoneFound()
        {
            //create an instance of the filtered data
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            //apply a supplier name that doesnt exist
            FilteredSuppliers.ReportBySupplierName("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredSuppliers.Count);
        }


        [TestMethod]
        public void ReportBySupplierNameTestDataFound()
        {
            //create an instance of the filtered data
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a supplier name that doesnt exist
            FilteredSuppliers.ReportBySupplierName("yyy yyy");
            //check that the correct number of records are found
            if (FilteredSuppliers.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredSuppliers.SupplierList[0].SupplierID != 37)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredSuppliers.SupplierList[1].SupplierID != 37)
                {
                    OK = false;
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
}
