using System.Collections.Generic;

namespace PhoneClasses
{
    public class clsProductCollection
    {
        //private data member for the list
        List<clsProduct> mProductList = new List<clsProduct>();
        
        //public property for the property list
        public List<clsProduct> ProductList
        {
            get
            {
                //return the private data
                return mProductList;
            }
            set
            {
                //set the private data 
                mProductList = value;
            }
        }
        //public property for count 
        public int Count
        {
            get
            {
                //return the count of the list
                return mProductList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
 
       
        public clsProduct ThisProduct { get; set; }
    }
}