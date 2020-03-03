using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneTesting
{
    class clsCounty
    {
        private Int32 mCountyNo;
        //public property for CountyNo
        public Int32 CountyNo
        {
            get
            {
                return mCountyNo;
            }
            set
            {
                mCountyNo = value;
            }
        }

        private string mCounty;
        //public property for County
        public string County
        {
            get
            {
                return mCounty;
            }
            set
            {
                mCounty = value;
            }
        }
    }
}
}
