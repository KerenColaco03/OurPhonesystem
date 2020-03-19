using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace PhoneClasses
{
    public class clsStaffCollection
    {
        public List<clsStaff> StaffList { get; set; }
        public int Count { get; set; }
        public clsStaff ThisStaff { get; set; }

        public class clsProductCollection

        {


            List<clsStaff> mStaffList = new List<clsStaff>();
            clsStaff mThisStaff = new clsStaff();

            public List<clsStaff> StafftList
            {
                get
                {
                    return mStaffList;
                }
                set
                {
                    mStaffList = value;

                }

            }

            //public property for count 

            public int Count
            {
                get
                {
                    return mStaffList.Count;
                }
                set
                {

                }

            }

            public clsStaff ThisStaff
            {

                get

                {
                    return mThisStaff;
                }

                set

                {

                    mThisStaff = value;
                }
            }
            

        }
    }
}