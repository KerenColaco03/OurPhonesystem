using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace PhoneTesting
{
    [TestClass]
    public class tstOrderLine
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to cerate
            clsOrderLine AnOrder = new clsOrderLine();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
    }
}
