﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Controllers
{
    public class OrderCompleteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}