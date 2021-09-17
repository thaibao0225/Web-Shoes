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

            ViewBag.Size7 = productDetailQuery.pd_Size7;
            ViewBag.Size7_5 = productDetailQuery.pd_Size7_5;
            ViewBag.Size8 = productDetailQuery.pd_Size8;
            ViewBag.Size8_5 = productDetailQuery.pd_Size8_5;
            ViewBag.Size9 = productDetailQuery.pd_Size9;
            ViewBag.Size9_5 = productDetailQuery.pd_Size9_5;
            ViewBag.Size10 = productDetailQuery.pd_Size10;
            ViewBag.Size10_5 = productDetailQuery.pd_Size10_5;
            ViewBag.Size11 = productDetailQuery.pd_Size11;
            ViewBag.Size11_5 = productDetailQuery.pd_Size11_5;
            ViewBag.Size12 = productDetailQuery.pd_Size12;
            ViewBag.Size12_5 = productDetailQuery.pd_Size12_5;
            ViewBag.Size13 = productDetailQuery.pd_Size13;
            ViewBag.Size13_5 = productDetailQuery.pd_Size13_5;
            ViewBag.Size14 = productDetailQuery.pd_Size14;
            ViewBag.Size14_5 = productDetailQuery.pd_Size14_5;



            var review = from a in _context.AppUser
                         join b in _context.Reviews on a.Id equals b.review_UserId
                         join c in _context.ReviewInproduct on b.review_id equals c.rip_ReviewId
                         join d in _context.Products on c.rip_ProductId equals d.pd_Id
                         select new { a, b, c, d };

            var SubReview = from a in _context.AppUser
                            join b in _context.SubReview on a.Id equals b.subReview_UserId
                            join c in _context.SubReviewInReview on b.subReview_Id equals c.SRiR_SubReviewId
                            join d in _context.Reviews on c.SRiR_ReviewId equals d.review_id
                            select new {a,b,c,d };


            review = review.Where(x => x.d.pd_Id == id && x.b.review_HideStatus == false);

            var reviewQuery = review.Select(x => new ReviewModel()
            {
                // table Review
                review_id = x.b.review_id,
                review_UserId = x.a.Id,
                review_ProductId = x.d.pd_Id,
                review_Comment = x.b.review_Comment,
                review_UserName = x.a.UserName,
                review_UploadTime = x.b.review_UploadTime,

                review_CountSubReview = 1
                //// table SubReview
                //Subreview = 

                
            });

            SubReview = SubReview.Where(x => x.b.subReview_HideStatus == false);

            var subReviewQuery = SubReview.Select(x => new SubreviewModel()
            {
                subReview_Subid = x.b.subReview_Id,
                subReview_SubComment = x.b.subReview_Commnet,
                subReview_SubUserId = x.b.subReview_UserId,
                subReview_SubUploadTime = x.b.subReview_DateCommnet,
                subReview_UserName = x.a.UserName,
                subReview_ReviewId = x.d.review_id
            });

            List<ReviewModel> reviewAdd = new List<ReviewModel>();
           


            //Query of Review
            foreach (var itemReview in reviewQuery)
            {

                List<SubreviewModel> subreviewAddList = new List<SubreviewModel>();
                //Query of SubReview
                foreach (var itemSubReview in subReviewQuery)
                {
                    //If SubReview In Review
                    if (itemReview.review_id == itemSubReview.subReview_ReviewId)
                    {
                        //SubreviewModel subreviewAdd = new SubreviewModel();
                        //subreviewAdd.subReview_ReviewId = itemSubReview.subReview_ReviewId;
                        //subreviewAdd.subReview_SubComment = itemSubReview.subReview_SubComment;
                        //subreviewAdd.subReview_Subid = itemSubReview.subReview_Subid;
                        //subreviewAdd.subReview_SubUploadTime = itemSubReview.subReview_SubUploadTime;
                        //subreviewAdd.subReview_SubUserId = itemSubReview.subReview_Subid;
                        //subreviewAdd.subReview_UserName = itemSubReview.subReview_UserName;

                        subreviewAddList.Add(itemSubReview);
                    }
                }

                itemReview.review_SubreviewModelList = subreviewAddList;
                itemReview.review_CountSubReview = subreviewAddList.Count();
                reviewAdd.Add(itemReview);
            }
            var reviewQuery1 = reviewAdd.Cast<ReviewModel>().ToArray();



            return View(reviewQuery1);
        }

        [Route("/productdetailadd")]
        [HttpGet("{productid}&{quantity}&{color}&{size}")]
        public async Task<IActionResult> Index(int productid, string quantity,string color,string size)
        {

            try
            {
                string namePc = Environment.MachineName;
                bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();

                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var userName = User.FindFirstValue(ClaimTypes.Name);

                int quantityProduct = Int16.Parse(quantity);

                string cartId = Guid.NewGuid().ToString();
                

                if (checkLogin)
                {
                    

                    

                    // Logined
                    //Create cart
                    var cartCreate = new Cart()
                    {
                        cart_Id = cartId,
                        cart_UserID = userId
                    };

                    _context.Cart.Add(cartCreate);

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
                }else
                {
                    /// No logined
                    /// Create Device in DB
                    var deviceQuery = _context.Devices.FirstOrDefault(a => a.deviceName == namePc);

                    if (deviceQuery == null)
                    {
                        string DeviceId = Guid.NewGuid().ToString();

                        var AddDevice = new Device()
                        {
                            deviceId = DeviceId,
                            deviceName = namePc
                        };

                        _context.Devices.Add(AddDevice);

                        await _context.SaveChangesAsync();
                    }
                    /// Create Device in DB
                    /// 


                    var deviceQueryre = _context.Devices.FirstOrDefault(a => a.deviceName == namePc);

                    //Create cart
                    var CartsDevice = new CartsDevice()
                    {
                        cartd_Id = cartId,
                        cartd_DeviceId = deviceQueryre.deviceId
                    };

                    _context.CartsDevice.Add(CartsDevice);

                    var ProductInCartDevices = new ProductInCartDevices()
                    {
                        picd_CartId = cartId,
                        picd_ProductId = productid,
                        picd_amount = quantityProduct,
                        picd_size = size,
                        picd_color = color
                    };

                    _context.ProductInCartDevices.Add(ProductInCartDevices);

                    await _context.SaveChangesAsync();
                }

                


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
                    review_UploadTime = DateTime.Now,
                    review_HideStatus = false,
                    review_ReviewType ="Review"
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

        [Route("/productcommentreply")]
        [HttpPost]
        public async Task<IActionResult> Commentreply()
        {

            try
            {

                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var userName = User.FindFirstValue(ClaimTypes.Name);

                string SubReviewId = Guid.NewGuid().ToString();

                var SubReviews = new SubReview()
                {
                    subReview_Id = SubReviewId,
                    subReview_Commnet = Request.Form["subcomment"],
                    subReview_DateCommnet = DateTime.Now,
                    subReview_UserId = userId,
                    subReview_HideStatus = false,
                    subreview_SubReviewType = "SubReview"
                };



                string idproduct = Request.Form["idproduct"]; 
                string idCommentMain = Request.Form["idcommentmain"]; 

                int idProductInt = Int32.Parse(idproduct);

                _context.SubReview.Add(SubReviews);

                var SubReviewInReview = new SubReviewInReview()
                {
                    SRiR_ReviewId = idCommentMain,
                    SRiR_SubReviewId = SubReviewId
                };
                _context.SubReviewInReview.Add(SubReviewInReview);


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
