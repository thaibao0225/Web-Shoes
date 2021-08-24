using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;
using Web_Shoes.Entity;
using Web_Shoes.Models;

namespace Web_Shoes.Controllers
{
    public class AboutController : Controller
    {

        private readonly ApplicationDbContext _context;


        public AboutController(ApplicationDbContext context)
        {
            _context = context;
        }


        [Route("/about")]
        [HttpGet]
        public IActionResult Index()
        {
            var about = _context.About.FirstOrDefault(a => a.about_id == 1);

            return View(about);
        }

        [HttpGet("/aboutmanagement/edit/")]
        // GET: ProductManagementController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {

                //var productQuery = _context.Products.FirstOrDefault(x => x.pd_Id == id);

                return View();
            }
            catch (Exception)
            {

                ViewBag.thongbao = "Cann't create";
                return View();
            }

        }

        // POST: ProductManagementController/Edit/5
        [HttpPost("/aboutmanagement/edit/{id:int?}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, About productModel)
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
