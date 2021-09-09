using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Entity
{
    public class ProductInCartDevices
    {
        public CartsDevice CartsDevicePICD { get; set; }
        public int picd_CartId { get; set; }
        public Products ProductsPICD { get; set; }

        public int picd_ProductId { get; set; }

        public int picd_amount { get; set; }

    }
}
