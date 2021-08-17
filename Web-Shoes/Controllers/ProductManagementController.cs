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


        public ProductManagementController(ApplicationDbContext context)
        {
            _context = context;
        }


        [Route("/productmanagement")]
        [HttpGet]
        public ActionResult Index()
        {
            try
            {

                var productListTest1 = from a in _context.Products select a;

                return View(productListTest1);

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

        [HttpGet("/hoc-lap-trinh-asp/{id:int?}/")]
        // GET: ProductManagementController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {

                var productQuery = _context.Products.FirstOrDefault(x => x.pd_Id == id);

                return View(productQuery);
            }
            catch (Exception)
            {

                ViewBag.thongbao = "Cann't create";
                return View();
            }
            
        }

        // POST: ProductManagementController/Edit/5
        [HttpPost("/hoc-lap-trinh-asp/{id:int?}/")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductModel productModel)
        {
            try
            {

                var productQuery = _context.Products.FirstOrDefault(x => x.pd_Id == id);




                productQuery.pd_Name = productModel.pd_Name;
                productQuery.pd_Description = productModel.pd_Description;
                productQuery.pd_Price = productModel.pd_Price;
                productQuery.pd_ReducePrice = productModel.pd_ReducePrice;
                productQuery.pd_Img1 = productModel.pd_Img1;
                productQuery.pd_Img2 = productModel.pd_Img2;
                productQuery.pd_Img3 = productModel.pd_Img3;
                productQuery.pd_Img4 = productModel.pd_Img4;
                productQuery.pd_Rate = productModel.pd_Rate;
                productQuery.pd_MenuFacturer = productModel.pd_MenuFacturer;
                productQuery.pd_ShortDescription = productModel.pd_ShortDescription;
                productQuery.pd_Size = productModel.pd_Size;
                productQuery.pd_Brand = productModel.pd_Brand;
                productQuery.pd_Style = productModel.pd_Style;
                productQuery.pd_Color = productModel.pd_Color;
                productQuery.pd_Material = productModel.pd_Material;
                productQuery.pd_Technologies = productModel.pd_Technologies;



                _context.SaveChanges();

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
