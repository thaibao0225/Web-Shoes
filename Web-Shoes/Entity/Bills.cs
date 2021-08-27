using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Entity
{
    public class Bills
    {
        public string bill_Id { set; get; }
        public AppUser AppUserB { get; set; }
        public string bill_UserId { set; get; }
        public int bill_PaidTotal { set; get; }
        public string bill_Country { set; get; }
        public string bill_CompanyName { set; get; }
        public string bill_City { set; get; }
        public string bill_State { set; get; }
        public string bill_PostalCode { set; get; }
        public string bill_Email { set; get; }
        public string bill_PhoneNumber { set; get; }
        public int bill_Shipping { set; get; }
        public string bill_Productlist { set; get; }
    }
}
