using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace PhoneTesting
{
    [TestClass]
    public class tstPayment
    {
        //
        //good test data
        //create some test data too pass the emthod
        string CardExpiry = DateTime.Now.Date.ToString();
        string CardNo = "1";
        string CardHoldersName = "Ayisha";
        string OrderID = "1";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to cerate
            clsPayment AnOrder = new clsPayment();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void CardExpiryOK()
        {
            //create an instance of the class we want to cerate
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the propoerty
            AnPayment.CardExpiry = TestData;
            //test to see that the two vallus are the same
            Assert.AreEqual(AnPayment.CardExpiry, TestData);

        }
        [TestMethod]
        public void CardHoldersNameOK()
        {
            //create an instance of the class we want to cerate
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property
            string TestData = "a";
            //assign the data to the property
            AnPayment.CardHoldersName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.CardHoldersName, TestData);
        }
        [TestMethod]
        public void CardNoOK()
        {
            //create an instance of the class we want to cerate
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property
            Int32 TestData = 1243;
            //assign the data to the property
            AnPayment.CardNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.CardNo, TestData);
        }
        [TestMethod]
        public void OrderIDOK()
        {
            //create an instance of the class we want to cerate
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnPayment.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.OrderID, TestData);
        }
        [TestMethod]
        public void PaymentIDOK()
        {
            //create an instance of the class we want to cerate
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnPayment.PaymentID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPayment.PaymentID, TestData);
        }
        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of validation
            Boolean Found = false;
            //create some test data 
            Int32 PaymentID = 1;
            //invoke the method
            Found = AnPayment.Find(PaymentID);
            //TEST TO SE THAT THE REUSLT IS CORRECT
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestPaymentOK()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            Boolean Found = false;
            //create some test data 
            Boolean OK = true;
            //create some test data to use with the mehotd
            Int32 PaymentID = 13;
            //invoke the method
            Found = AnPayment.Find(PaymentID);
            //check the paymentID
            if (AnPayment.PaymentID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCardExpiryFound()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PaymentID = 13;
            //invoke the method
            Found = AnPayment.Find(PaymentID);
            //check the property
            if (AnPayment.CardExpiry != Convert.ToDateTime("16/09/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCardHoldersNameFound()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            Boolean Found = false;
            //create some test data 
            Boolean OK = true;
            //create some test data to use with the mehotd
            Int32 PaymentID = 13;
            //invoke the method
            Found = AnPayment.Find(PaymentID);
            //check the paymentID
            if (AnPayment.CardHoldersName != "CardHoldersName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCardNoFound()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            Boolean Found = false;
            //create some test data 
            Boolean OK = true;
            //create some test data to use with the mehotd
            Int32 PaymentID = 13;
            //invoke the method
            Found = AnPayment.Find(PaymentID);
            //check the paymentID
            if (AnPayment.CardNo != 1)
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
            clsPayment AnPayment = new clsPayment();
            Boolean Found = false;
            //create some test data 
            Boolean OK = true;
            //create some test data to use with the mehotd
            Int32 PaymentID = 13;
            //invoke the method
            Found = AnPayment.Find(PaymentID);
            //check the paymentID
            if (AnPayment.OrderID != 1)
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
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnPayment.Valid( CardExpiry, CardHoldersName, CardNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CardNoMinLessOne()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CardNo = "128812627632736";
            //invoke the method
            Error = AnPayment.Valid(CardNo,  CardExpiry, CardHoldersName);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CardNoMin()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CardNo = "1288126276327365";//this should be OK
            //invoke the method
            Error = AnPayment.Valid(CardNo,  CardExpiry, CardHoldersName);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CardNoMinPlusOne()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CardNo = "12881262763273656";//this should faIL
            //invoke the method
            Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
            //test to see tat the reuslt is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CardNoMaxLessOne()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CardNo = "128812627632736";//this should faIL
            //invoke the method
            Error = AnPayment.Valid(CardNo,  CardExpiry, CardHoldersName);
            //test to see tat the reuslt is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CardNoMax()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CardNo = "1288126276327365";//this should faIL
            //invoke the method
            Error = AnPayment.Valid(CardNo,  CardExpiry, CardHoldersName);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CardNoMid()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CardNo = "12881262";//this should faIL
            //invoke the method
            Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
            //test to see tat the reuslt is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CardNoMaxPlusOne()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CardNo = "12881262763273656";//this should faIL
            //invoke the method
            Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
            //test to see tat the reuslt is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CardNoExtremeMax()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CardNo = "";
            CardNo = CardNo.PadRight(500, '1');//this should faIL
            //invoke the method
            Error = AnPayment.Valid(CardNo,  CardExpiry, CardHoldersName);
            //test to see tat the reuslt is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CardExpiryDateExtremeMin()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test ata
            DateTime TestDate;
            //set date to todays date
            TestDate = DateTime.Now.Date;
            //chhange the date to whatever the date is less than 10 years
            TestDate = TestDate.AddYears(-100);
            //convert the date to a string variabkle
            string CardExpiry = TestDate.ToString();
            //invoke the method
            Error = AnPayment.Valid(CardNo,  CardExpiry, CardHoldersName);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CardExpiryDateMinLessOne()
        {
            // create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test ata
            DateTime TestDate;
            //set date to todays date
            TestDate = DateTime.Now.Date;
            //chhange the date to whatever the date is less than 10 years
            TestDate = TestDate.AddDays(-1);
            //convert the date to a string variabkle
            string CardExpiry = TestDate.ToString();
            //invoke the method
            Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CardExpiryDateMin()
        {
            /// create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test ata
            DateTime TestDate;
            //set date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date to a string variabkle
            string CardExpiry = TestDate.ToString();
            //invoke the method
            Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CardExpiryDateMinPlusOne()
        {
            /// create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test ata
            DateTime TestDate;
            //set date to todays date
            TestDate = DateTime.Now.Date;
            // chhange the date to whatever the date is less than 10 years
            TestDate = TestDate.AddDays(1);
            //convert the date to a string variabkle
            string CardExpiry = TestDate.ToString();
            //invoke the method
            Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CardExpiryDateExtremeMax()
        {
            // create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test ata
            DateTime TestDate;
            //set date to todays date
            TestDate = DateTime.Now.Date;
            // chhange the date to whatever the date is less than 10 years
            TestDate = TestDate.AddYears(100);
            //convert the date to a string variabkle
            string CardExpiry = TestDate.ToString();
            //invoke the method
            Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CardExpiryDateInvalidData()
        {
            // create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //set the OrderDate to a non date Value
            string CardExpiry = "this is not a date!";
            //invoke the method
            Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CardHoldersNameMinLessOne()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CardHoldersName = "";
            //invoke the method
            Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
            Assert.AreNotEqual(Error, "");
        }
        //[TestMethod]
        //public void CardHoldersNameMin()
        //{
            //create an instance of the class we wnt to create
           // clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
           // String Error = "";
            //create some test adta to pass to the method
            //String CardHoldersName = "a";//this should be OK
            //invoke the method
            //Error = AnPayment.Valid(CardNo, OrderID, CardExpiry, CardHoldersName);
            //test to see tat the reuslt is correct
            //Assert.AreEqual(Error, "");
        //}

        [TestMethod]
        public void CardHoldersNameMin()
        {
            //create an instance of the class we want to cretae
            clsPayment AnPayment = new clsPayment();
            String Error = "";
            String CardHoldersName = "a";
            Error = AnPayment.Valid(CardNo,  CardExpiry, CardHoldersName);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CardHoldersNameMinPlusOne()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CardHoldersName = "aa";//this should faIL
            //invoke the method
            Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CardHoldersNameMaxLessOne()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CardHoldersName = "0123456789012345678901234567890123456789012345678";
          
            //invoke the method
            Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CardHoldersNameMax()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CardHoldersName = "";
           CardHoldersName = CardHoldersName.PadRight(50, '1');
            //invoke the method
            Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CardHoldersNameMid()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CardHoldersName = "0123456789012345678901234";//this should faIL
            //invoke the method
            Error = AnPayment.Valid(CardNo,CardExpiry, CardHoldersName);
            //test to see tat the reuslt is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CardHoldersNameMaxPlusOne()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CardHoldersName = "";//this should faIL
            CardHoldersName = CardHoldersName.PadRight(51, '1');
            //invoke the method
            Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
            //test to see tat the reuslt is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CardHoldersNameExtremeMax()
        {
            //create an instance of the class we wnt to create
            clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test adta to pass to the method
            string CardHoldersName = "";
            CardHoldersName = CardHoldersName.PadRight(500, '1');//this should faIL
            //invoke the method
            Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
            //test to see tat the reuslt is correct
            Assert.AreNotEqual(Error, "");



        }
      //[TestMethod]
      //public void OrderIDMinLessOne()
       //
            //create an instance of the class we wnt to create
          //clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
          //String Error = "";
          //create some test adta to pass to the method
          //string OrderID = "";
            //invoke the method
          //Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
          //Assert.AreNotEqual(Error, "");
       //
       //TestMethod]
      //public void OrderIDMin()
      //{
      //    //create an instance of the class we wnt to create
       //   clsPayment AnPayment = new clsPayment();
       //   //string variable to store any error message
       //   String Error = "";
        //  //create some test adta to pass to the method
         // string OrderID = "a";//this should be OK
        //  //invoke the method
        //  Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
        //  //test to see tat the reuslt is correct
        //  Assert.AreEqual(Error, "");
      //}
       //TestMethod]
      //public void OrderIDMinPlusOne()
    //  {
            //create an instance of the class we wnt to create
      //    clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
         // String Error = "";
            //create some test adta to pass to the method
       //   string OrderID = "11";//this should faIL
            //invoke the method
       //   Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
            //test to see tat the reuslt is correct
     //     Assert.AreEqual(Error, "");
      //}
     // [TestMethod]
      //public void OrderIDMaxLessOne()
     // {
            //create an instance of the class we wnt to create
       //   clsPayment AnPayment = new clsPayment();
       //   //string variable to store any error message
       //   String Error = "";
       //   //create some test adta to pass to the method
       //   string OrderID = "11111";
       //   //invoke the method
      //    Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
       //   //test to see tat the reuslt is correct
       //   Assert.AreEqual(Error, "");
    //  }
     // [TestMethod]
     // public void OrderIDMax()
     // {
            //create an instance of the class we wnt to create
      //    clsPayment AnPayment = new clsPayment();
            //string variable to store any error message
      //    String Error = "";
            //create some test adta to pass to the method
       //   string OrderID = "111111";
            //invoke the method
        //  Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
            //test to see tat the reuslt is correct
      //    Assert.AreEqual(Error, "");
        }
      //[TestMethod]
     // public void OrderIDMid()
     // {
           //create an instance of the class we wnt to create
        //  clsPayment AnPayment = new clsPayment();
        //  //string variable to store any error message
         // String Error = "";
         // //create some test adta to pass to the method
         // string OrderID = "111";
            //invoke the method
         // Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
         // //test to see tat the reuslt is correct
         // Assert.AreEqual(Error, "");
  //    }
   //   [TestMethod]
    //  public void OrderIDMaxPlusOne()
    //  {
     //     //create an instance of the class we wnt to create
     //     clsPayment AnPayment = new clsPayment();
      //    //string variable to store any error message
      //    String Error = "";
      //    //create some test adta to pass to the method
      //    string OrderID = "1111111";//this should faIL
       //                              //invoke the method
       //   Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
       //   //test to see tat the reuslt is correct
      //    Assert.AreNotEqual(Error, "");
     // }
     ///[TestMethod]
     // public void OrderIDExtremeMax()
      //{
       //   //create an instance of the class we wnt to create
       //   clsPayment AnPayment = new clsPayment();
      //    //string variable to store any error message
      //    String Error = "";
       //   //create some test adta to pass to the method
       //   string OrderID = "";
       //   OrderID = OrderID.PadRight(500, '1');//this should faIL
       //   //invoke the method
        //  Error = AnPayment.Valid(CardNo, CardExpiry, CardHoldersName);
        //  //test to see tat the reuslt is correct
        //  Assert.AreNotEqual(Error, "");


        }
    


