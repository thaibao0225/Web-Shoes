using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;

namespace Web_Shoes.Controllers
{
    public class AllProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AllProductsController(ApplicationDbContext context)
        {

            _context = context;
        }



        // GET: AllProductsController
        [Route("/allproduct")]
        [HttpGet]
        public ActionResult Index()
        {

            var AllProductQuery = from a in _context.Products select a;
            return View(AllProductQuery);
        }

        // GET: AllProductsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AllProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AllProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: AllProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AllProductsController/Edit/5
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

        // GET: AllProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AllProductsController/Delete/5
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
