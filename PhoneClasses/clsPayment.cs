using System;

namespace PhoneClasses
{
    public class clsPayment
    {
        public DateTime CardExpiry { get; set; }
        public string CardHoldersName { get; set; }
        public int CardNo { get; set; }
        public int OrderID { get; set; }
        public int PaymentID { get; set; }
    }
}