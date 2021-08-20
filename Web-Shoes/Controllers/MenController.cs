using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;

namespace Web_Shoes.Controllers
{
    public class MenController : Controller
    {

        private readonly ApplicationDbContext _context;

        public MenController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var MenQuery = from a in _context.Products select a;

            return View(MenQuery);
        }


    }
}
