using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;

namespace Web_Shoes.Controllers
{
    public class ProductDetailController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ProductDetailController(ApplicationDbContext context)
        {
            _context = context;
        }


     

        [Route("/productdetail")]
        [HttpGet("{id}")]
        public IActionResult Index(int id)
        
        {




            var productDetailQuery = _context.Products.FirstOrDefault(a => a.pd_Id == id);
        

            return View(productDetailQuery);
        }


        
    }
}
