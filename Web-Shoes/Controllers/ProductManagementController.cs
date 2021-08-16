using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        public ProductManagementController(ApplicationDbContext context)
        {
            _context = context;
        }

        //public ProductManagementController()
        //{
        //    haha = "aaa";
        //}

        [HttpGet]
        [Route("productmanagement")]
        // GET: ProductManagementController
        public async Task<ActionResult> Index()
        {
            try
            {
                var query = from p in _context.Products select new { p };


                var productsView = await query.Select(x => new Products
                {
                    pd_Id = x.p.pd_Id,
                    pd_Name = x.p.pd_Name,
                    pd_Description = x.p.pd_Description,
                    pd_ReducePrice = x.p.pd_ReducePrice,
                    pd_Price = x.p.pd_Price,
                    pd_Rate = x.p.pd_Rate
                }).ToListAsync();

                //var productsView = from a in _context.Products select a;

                //productsView = (IQueryable<Products>)await productsView.ToListAsync();

                query = await query.ToListAsync();


                return View(productsView);

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
