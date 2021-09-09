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


            ViewBag.Id = productDetailQuery.pd_Id;
            ViewBag.Img1 = productDetailQuery.pd_Img1;
            ViewBag.Img2 = productDetailQuery.pd_Img2;
            ViewBag.Img3 = productDetailQuery.pd_Img3;
            ViewBag.Img4 = productDetailQuery.pd_Img4;

            ViewBag.NameProduct = productDetailQuery.pd_Name;
            ViewBag.Price = productDetailQuery.pd_Price;
            ViewBag.Rate = productDetailQuery.pd_Rate;
            ViewBag.ShortDescription = productDetailQuery.pd_ShortDescription;
            ViewBag.Description = productDetailQuery.pd_Description;

            //ViewBag.Size7 = productDetailQuery.pd_Size7;
            //ViewBag.Size7_5 = productDetailQuery.pd_Size7_5;
            //ViewBag.Size8 = productDetailQuery.pd_Size8;
            //ViewBag.Size8_5 = productDetailQuery.pd_Size8_5;
            //ViewBag.Size9 = productDetailQuery.pd_Size9;
            //ViewBag.Size9_5 = productDetailQuery.pd_Size9_5;
            //ViewBag.Size10 = productDetailQuery.pd_Size10;
            //ViewBag.Size10_5 = productDetailQuery.pd_Size10_5;
            //ViewBag.Size11 = productDetailQuery.pd_Size11;
            //ViewBag.Size11_5 = productDetailQuery.pd_Size11_5;
            //ViewBag.Size12 = productDetailQuery.pd_Size12;
            //ViewBag.Size12_5 = productDetailQuery.pd_Size12_5;
            //ViewBag.Size13 = productDetailQuery.pd_Size13;
            //ViewBag.Size13_5 = productDetailQuery.pd_Size13_5;
            //ViewBag.Size14 = productDetailQuery.pd_Size14;
            //ViewBag.Size14_5 = productDetailQuery.pd_Size14_5;

            ViewBag.Size7 = true;
            ViewBag.Size7_5 = true;
            ViewBag.Size8 = true;
            ViewBag.Size8_5 = true;
            ViewBag.Size9 = true;
            ViewBag.Size9_5 = true;
            ViewBag.Size10 = true;
            ViewBag.Size10_5 = true;
            ViewBag.Size11 = true;
            ViewBag.Size11_5 = true;
            ViewBag.Size12 = true;
            ViewBag.Size12_5 = true;
            ViewBag.Size13 = true;
            ViewBag.Size13_5 = true;
            ViewBag.Size14 = true;
            ViewBag.Size14_5 = true;

            var review = from a in _context.AppUser
                         join b in _context.Reviews on a.Id equals b.review_UserId
                         join c in _context.ReviewInproduct on b.review_id equals c.rip_ReviewId
                         join d in _context.Products on c.rip_ProductId equals d.pd_Id
                         select new { a, b, c, d };

            review = review.Where(x => x.d.pd_Id == id);

            var reviewQuery = review.Select(x => new ReviewModel()
            {
                review_id = x.b.review_id,
                review_UserId = x.a.Id,
                review_ProductId = x.d.pd_Id,
                review_Comment = x.b.review_Comment,
                review_UserName = x.a.UserName,
                review_UploadTime = x.b.review_UploadTime
            });

            return View(reviewQuery);
        }

        [Route("/productdetailadd")]
        [HttpGet("{productid}&{quantity}&{color}&{size}")]
        public async Task<IActionResult> Index(int productid, string quantity,string color,string size)
        {

            try
            {

                string a = quantity;
                string a2 = color;
                string a3 = size;

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
                    pic_amount = quantityProduct,
                    pic_size = size,
                    pic_color = color
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

        [Route("/productcomment")]
        [HttpPost]
        public async Task<IActionResult> Comment()
        {
            
            try
            {

                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var userName = User.FindFirstValue(ClaimTypes.Name);

                string reviewId = Guid.NewGuid().ToString();

                var reviews = new Reviews()
                {
                    review_id = reviewId,
                    review_Comment = Request.Form["comment"],
                    review_UserId = userId,
                    review_UploadTime = DateTime.Now
                };



                string idproduct = Request.Form["idproduct"];
                
                int idProductInt = Int32.Parse(idproduct);

                _context.Reviews.Add(reviews);

                var reviewInProduct = new ReviewInproduct()
                {
                    rip_ProductId = idProductInt,
                    rip_ReviewId = reviewId
                };
                _context.ReviewInproduct.Add(reviewInProduct);

                
                await _context.SaveChangesAsync();

                return Redirect("/productdetail?id=" + idproduct);
            }
            catch
            {
                ViewBag.thongbao = "Cann't create";
                return View();
            }








        }


    }
}
