using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;

namespace Web_Shoes.Controllers
{
    public class TestController : Controller
    {

        private readonly ApplicationDbContext _context;


        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }


        [Route("/test")]
        [HttpGet]
        public IActionResult Index()
        {
            //string search = Request.Form["search"];


            return View();
        }


        [Route("/search")]
        [HttpPost]
        public IActionResult search()
        {
            string search = Request.Form["search"];

            var searchQuery = _context.Products.Where(a => a.pd_Name.Contains("a"));

            foreach (var item in searchQuery)
            {
                string aaa = item.pd_Name;
            }

            return Redirect("/");
        }
    }
}
