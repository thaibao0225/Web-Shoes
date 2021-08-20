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

        [HttpPost("{id}")]
        public IActionResult Index(int id, int quantity)
        {


            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var userName = User.FindFirstValue(ClaimTypes.Name);


            var query = from a in _context.Products
                        join b in _context.ProductInCart on a.pd_Id equals b.pic_ProductId
                        join c in _context.Cart on b.pic_CartId equals c.cart_Id
                        join d in _context.AppUser on c.cart_UserID equals d.Id
                        select new { a,b, c, d };


            query = query.Where(x => x.d.Id == userId);



            var productInCartModelQuery = query
                .Select(x => new ProductInCartModel()
                {
                    ProductId = x.a.pd_Id,
                    ProductName = x.a.pd_Name,
                    ProductPrice = x.a.pd_Price,
                    Quantity = x.b.pic_amount,
                    UserId = x.d.Id

                });





            //var productDetailQuery = _context.Products.FirstOrDefault(a => a.pd_Id == id);


            return View();
        }

    }
}
