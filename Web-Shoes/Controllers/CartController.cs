using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;

namespace Web_Shoes.Controllers
{
    public class CartController : Controller
    {


        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }


        [Route("/cart")]
        [HttpGet("{productid}&{quantity}")]
        public IActionResult Index(int productid,int quantity)
        {

            int aa = productid;


            int b = quantity;
            return View();
        }
    }
}
