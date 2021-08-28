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
        public string bill_Productlist { set; get; }
        public string bill_Shipping { set; get; }
        public string bill_Discount { set; get; }

    }
}
