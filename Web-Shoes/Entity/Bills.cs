using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Entity
{
    public class Bills
    {
        public int bill_Id { set; get; }
        public AppUser AppUserB { get; set; }
        public string bill_UserId { set; get; }
        public int bill_Paid { set; get; }

    }
}
