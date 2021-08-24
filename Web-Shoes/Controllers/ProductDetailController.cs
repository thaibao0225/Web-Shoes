using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Entity;
using Web_Shoes.Models;

namespace Web_Shoes.Controllers
{
    public class ProductDetailController : Controller
    {

        private readonly ApplicationDbContext _context;

        private readonly SignInManager<AppUser> _SignInManager;
        private readonly UserManager<AppUser> _UserManager;

        public ProductDetailController(ApplicationDbContext context, UserManager<AppUser> UserManager, SignInManager<AppUser> SignInManager)
        {
            _context = context;
            _UserManager = UserManager;
            _SignInManager = SignInManager;
        }




        [Route("/productdetail")]
        [HttpGet("{id}")]
        public IActionResult Index(int id)
        {


            var productDetailQuery = _context.Products.FirstOrDefault(a => a.pd_Id == id);



            return View(productDetailQuery);
        }

        [Route("/productdetailadd")]
        [HttpGet("{productid}&{quantity}")]
        public async Task<IActionResult> Index(int productid, int quantity)
        {

            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var userName = User.FindFirstValue(ClaimTypes.Name);


                int quantityProduct = 1;



                string cartId = Guid.NewGuid().ToString();


                //Create cart
                var cartCreate = new Cart()
                {
                    cart_Id = cartId,
                    cart_UserID = userId
                };

                _context.Cart.Add(cartCreate);

               // await _context.SaveChangesAsync();

                //Create ProductInCart

                var ProductInCartCreate = new ProductInCart()
                {
                    pic_CartId = cartId,
                    pic_ProductId = productid,
                    pic_amount = quantityProduct
                };

                _context.ProductInCart.Add(ProductInCartCreate);

                await _context.SaveChangesAsync();

                //var productDetailQuery = _context.Products.FirstOrDefault(a => a.pd_Id == id);


                return Redirect("/cart");
            }
            catch 
            {


                var productDetailQuery = _context.Products.FirstOrDefault(a => a.pd_Id == productid);



                return View(productDetailQuery);
            }
           
        }

    }
}
