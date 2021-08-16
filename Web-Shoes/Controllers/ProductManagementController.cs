using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Entity;
using Web_Shoes.Models;


namespace Web_Shoes.Controllers
{

    public class ProductManagementController : Controller
    {
        private readonly ApplicationDbContext _context;


        // public IList<Products> hihi { get; set; }


        //public async Task<List<ProductModel>> haha()
        //{
        //    var ddd = from d in _context.Products select new { d };
        //    var listKq = new List<ProductModel>();


        //    var aaa = await ddd.Select(x => new ProductModel()
        //    {
        //        pd_Id = x.d.pd_Id,
        //        pd_Name = x.d.pd_Name,
        //        pd_Description = x.d.pd_Description,
        //        pd_Price = x.d.pd_Price,
        //        pd_ReducePrice = x.d.pd_ReducePrice,
        //        pd_Img1 = x.d.pd_Img1,
        //        pd_Img2 = x.d.pd_Img2,
        //        pd_Img3 = x.d.pd_Img3,
        //        pd_Img4 = x.d.pd_Img4,
        //        pd_Rate = x.d.pd_Rate,
        //        pd_MenuFacturer = x.d.pd_MenuFacturer,
        //        pd_ShortDescription = x.d.pd_ShortDescription,
        //        pd_Size = x.d.pd_Size,
        //        pd_Brand = x.d.pd_Brand,
        //        pd_Style = x.d.pd_Style,
        //        pd_Color = x.d.pd_Color,
        //        pd_Material = x.d.pd_Material,
        //        pd_Technologies = x.d.pd_Technologies,


        //    }).ToListAsync();
            
        //    return aaa;
        


               

            
        //}
        public ProductManagementController(ApplicationDbContext context)
        {
            _context = context;
        }
        ProductModel ggg = new ProductModel();

        [BindProperty(SupportsGet = true)]

        public string SearchString { get; set; }
        [Route("/productmanagement")]
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            
            try {


                //var pro = await (from p in _context.Products select  p ).ToListAsync();

             var ddd = from d in _context.Products select  d ;
               
                
                foreach (var item in ddd)
                {
                 
                       
                    
                }

                // //haha = pro;

                // // Đọc (nạp) Article


                // var data = await pro.Select(x => new ProductModel()
                //{
                //    pd_Id = x.d.pd_Id,
                //    pd_Name = x.d.pd_Name,
                //    pd_Description = x.d.pd_Description,
                //    pd_Price = x.d.pd_Price,
                //    pd_ReducePrice = x.d.pd_ReducePrice,
                //    pd_Img1 = x.d.pd_Img1,
                //     pd_Img2 = x.d.pd_Img2,
                //     pd_Img3 = x.d.pd_Img3,
                //     pd_Img4 = x.d.pd_Img4,
                //     pd_Rate = x.d.pd_Rate,
                //     pd_MenuFacturer = x.d.pd_MenuFacturer,
                //     pd_ShortDescription = x.d.pd_ShortDescription,
                //     pd_Size = x.d.pd_Size,
                //     pd_Brand = x.d.pd_Brand,
                //     pd_Style = x.d.pd_Style,
                //     pd_Color = x.d.pd_Color,
                //     pd_Material = x.d.pd_Material,
                //     pd_Technologies = x.d.pd_Technologies,


                // }).ToListAsync();
                // var pagedResult = new PagedResult<ProductModel>()
                // {

                //     Items = data
                // };
                // //return pagedResult;
               

                return View();


            }

            catch
            {
                ViewBag.thongbao = "Cann't create";
                return View();
            }
        


        }

      

   


        // GET: ProductManagementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [Route("productmanagement/Create")]
        // GET: ProductManagementController/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.thongbao = "test";
            return View();
        }

        // POST: ProductManagementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<ActionResult> Create(ProductModel productModel)
        {
            try
            {

                //var user = await _context.Products.FindAsync(productModel.pd_Name);
                //if (user != null)
                //{

                //    throw new Exception("Product have existed");
                //}




                var product1 = new Products()
                {
                    pd_Name = productModel.pd_Name,
                    pd_Description = productModel.pd_Description,
                    pd_Price = productModel.pd_Price,
                    pd_ReducePrice = productModel.pd_ReducePrice,
                    pd_Img1 = productModel.pd_Img1,
                    pd_Img2 = productModel.pd_Img2,
                    pd_Img3 = productModel.pd_Img3,
                    pd_Img4 = productModel.pd_Img4,
                    pd_Rate = productModel.pd_Rate,
                    pd_MenuFacturer = productModel.pd_MenuFacturer,
                    pd_ShortDescription = productModel.pd_ShortDescription,
                    pd_Size = productModel.pd_Size,
                    pd_Brand = productModel.pd_Brand,
                    pd_Style = productModel.pd_Style,
                    pd_Color = productModel.pd_Color,
                    pd_Material = productModel.pd_Material,
                    pd_Technologies = productModel.pd_Technologies
                };



                //user = new User()
                //{

                //    Email = request.Email,
                //    user_FirstName = request.user_FirstName,
                //    user_LastName = request.user_LastName,
                //    user_FullName = request.user_FullName,
                //    user_DOB = request.user_DOB,
                //    UserName = request.UserName,
                //};

             

                _context.Products.Add(product1);
                await _context.SaveChangesAsync();
                
                


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.thongbao = "Cann't create";
                return View();
            }
        }

        //public async Task<ApiResult<bool>> Register(RegisterRequest request)
        //{
        //    var user = await _userManager.FindByNameAsync(request.UserName);
        //    if (user != null)
        //    {

        //        return new ApiErrorResult<bool>("Account have existed");
        //    }
        //    if (await _userManager.FindByEmailAsync(request.Email) != null)
        //    {
        //        return new ApiErrorResult<bool>("Email have existed");
        //    }
        //    user = new User()
        //    {

        //        Email = request.Email,
        //        user_FirstName = request.user_FirstName,
        //        user_LastName = request.user_LastName,
        //        user_FullName = request.user_FullName,
        //        user_DOB = request.user_DOB,
        //        UserName = request.UserName,
        //    };

        //    var result = await _userManager.CreateAsync(user, request.Password);
        //    if (result.Succeeded)
        //    {
        //        return new ApiSuccessResult<bool>();
        //    }
        //    return new ApiErrorResult<bool>("Register Failed");
        //}



        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {




        //        ViewBag.thongbao = "Created";
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        ViewBag.thongbao = "Cann't create";
        //        return View();
        //    }
        //}

        // GET: ProductManagementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductManagementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        //[HttpPost]
        //public async Task<IActionResult> Edit(UserUpdateRequest request)
        //{
        //    if (!ModelState.IsValid)
        //        return View();
        //    var result = await _userApiClient.EditUser(request.Id, request);
        //    if (result.ISuccessed)
        //    {
        //        TempData["result"] = "Edit successfully";
        //        return RedirectToAction("Index");

        //    }
        //    ModelState.AddModelError("", result.Message);
        //    return View(request);
        //}







        // GET: ProductManagementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductManagementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
