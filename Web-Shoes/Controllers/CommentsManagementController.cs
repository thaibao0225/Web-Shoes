using Microsoft.AspNetCore.Http;
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
    public class CommentsManagementController : Controller
    {
        private readonly ApplicationDbContext _context;


        public CommentsManagementController(ApplicationDbContext context)
        {
            _context = context;
        }



        // GET: CommentsManagementController
        [Route("/commentsmanagement")]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // GET: CommentsManagementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CommentsManagementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CommentsManagementController/Create
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

        // GET: CommentsManagementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CommentsManagementController/Edit/5
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

        // GET: CommentsManagementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CommentsManagementController/Delete/5
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
