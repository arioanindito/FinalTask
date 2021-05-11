using DSS_MVC.Models;
using DSS_MVC.Repository;
using DSS_MVC.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSS_MVC.Controllers
{
    public class StatusController : Controller
    {
        private readonly IStatus _Status;
        private DBContext db;
        public StatusController(IStatus _IStatus,DBContext _db)
        {
            _Status = _IStatus;
            db = _db;
        }
        public IActionResult Index()
        {
            return View(_Status.GetStatuses);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Status model)
        {
            if (ModelState.IsValid)
            {
                _Status.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Delete(int? ID)
        {
            if (ID == null)
            {
                return NotFound();
            }
            else
            {
                Status model = _Status.GetStatus(ID);
                return View(model);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? ID)
        {
            _Status.Remove(ID);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Edit(int? ID)
        {
            var model = _Status.GetStatus(ID);
            return View("Edit", model);
            //return View(model);
        }
        [HttpPost]
        public IActionResult Edit(Status model)
        {
            if (ModelState.IsValid)
            {
                _Status.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
