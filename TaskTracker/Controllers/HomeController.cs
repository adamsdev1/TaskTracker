using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Template.Models;
using Template.Services;

namespace Template.Controllers
{
    public class HomeController : Controller
    {
        private TeacherService _teacherService;
        // private context

        public HomeController(TeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public async Task <IActionResult> Index()
        {
            //https://stackoverflow.com/questions/29282190/where-is-request-isajaxrequest-in-asp-net-core-mvc
            bool isAjax = HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest"; 

            List<Teacher> teachers = await _teacherService.GetTeachers();

            if (isAjax)
                return PartialView("_TeachersGrid", teachers);

            return View(teachers);
        }

        [HttpGet]
        public IActionResult AddTeacher()
        {
            //return View("_OpenMe");
            return PartialView("_AddTeacher");
        }

        [HttpGet]
        public IActionResult SectionOne()
        {
            return PartialView("_SectionOne");
        }

        [HttpGet]
        public IActionResult OpenMe()
        {
            var model = new Teacher();
            //return View("_OpenMe");
            return PartialView("_OpenMe", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
