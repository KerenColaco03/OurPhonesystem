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
    }
}
