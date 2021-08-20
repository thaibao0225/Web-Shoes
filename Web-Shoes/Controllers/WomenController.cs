using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;

namespace Web_Shoes.Controllers
{
    public class WomenController : Controller
    {

        private readonly ApplicationDbContext _context;

        public WomenController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var WonmenQuery = from a in _context.Products select a;

            return View(WonmenQuery);
        }
    }
}
