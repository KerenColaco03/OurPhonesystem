using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneClasses;

namespace PhoneTesting
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceCreated()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.HouseNumber = 1;
            TestItem.StreetName = "Welland";
            TestItem.LastName = "Rayman";
            TestItem.FirstName = "Reman";
            TestItem.County = "Leicestershire";
            TestItem.Password = "Qwerty123";
            TestItem.PostCode = "LE3 4DJ";
            TestItem.Email = "reman_rayman@hotmail.co.uk";
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void CountTest()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Int32 SomeCount = 0;
            AllStaff.Count = SomeCount;
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }

        [TestMethod]
        public void ThisStaff()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.HouseNumber = 1;
            TestStaff.StreetName = "Welland";
            TestStaff.LastName = "Rayman";
            TestStaff.FirstName = "Reman";
            TestStaff.County = "Leicestershire";
            TestStaff.Password = "Qwerty123";
            TestStaff.PostCode = "LE3 4DJ";
            TestStaff.Email = "reman_rayman@hotmail.co.uk";
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
    }
}
