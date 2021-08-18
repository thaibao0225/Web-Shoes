using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Shoes.Data;

namespace Web_Shoes.Controllers
{
    public class RoleManagementController : Controller
    {

        private readonly ApplicationDbContext _context;


        public RoleManagementController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RoleManagementController
        [Route("/rolemanagement")]
        [HttpGet]
        public ActionResult Index()
        {

            var roleQuery = from a in _context.AppRole select a;
            return View(roleQuery);
        }


       // GET: RoleManagementController/Details/5
       [Route("/rolemanagement/details/{id:guid?}")]
        [HttpGet]
        public ActionResult Details(string id)
        {
            var roleQuery = _context.AppRole.FirstOrDefault(a => a.Id == id);
            return View(roleQuery);
        }

        // GET: RoleManagementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoleManagementController/Create
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

        // GET: RoleManagementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoleManagementController/Edit/5
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

        // GET: RoleManagementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoleManagementController/Delete/5
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
