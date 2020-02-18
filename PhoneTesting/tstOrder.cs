﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace PhoneTesting
{
    [TestClass]
    public class tstOrder
    {
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
    }

}