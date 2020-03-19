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
    }
}