using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Controllers
{
    public class RoleManagementController : Controller
    {
        // GET: RoleManagementController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoleManagementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
