using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Web_Shoes.Entity
{
    public class AppUser :IdentityUser
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DoB { set; get; }
        public List<Wishlists> WishlistsU { get; set; }
        public List<Bills> BillsAU { get; set; }
        public List<Reviews> ReviewsU { get; set; }
        public List<Cart> CartU { get; set; }





    }
}
