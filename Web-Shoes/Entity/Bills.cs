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
        public int bill_Shipping { set; get; }
        public int bill_Discount { set; get; }

        public bool bill_WaitForConfirmation { set; get; }
        public bool bill_WaitPickup { set; get; }
        public bool bill_Delivering { set; get; }
        public bool bill_Delivered { set; get; }
        public bool bill_Cancelled { set; get; }

    }
}
