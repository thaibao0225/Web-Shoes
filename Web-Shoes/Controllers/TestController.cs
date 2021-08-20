using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Controllers
{
    public class TestController : Controller
    {

        [Route("/test")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
