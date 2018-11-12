using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDD.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DDD.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentAppService _studentAppService;
        public StudentController(IStudentAppService studentAppService)
        {
            _studentAppService = studentAppService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var data = _studentAppService.GetAll();
            return View(data);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

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

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,IFormCollection collection)
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

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,IFormCollection collection)
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
