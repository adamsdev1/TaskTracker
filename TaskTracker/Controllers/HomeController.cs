using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Template.Controllers
{
    public class HomeController : Controller
    {
        // private context

        public HomeController()
        {
        }

        public async Task <IActionResult> Index()
        {
            //https://stackoverflow.com/questions/29282190/where-is-request-isajaxrequest-in-asp-net-core-mvc
            bool isAjax = HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";
            return View();
            //List<Teacher> teachers = await _teacherService.GetTeachers();

            //if (isAjax)
            //    return PartialView("_TeachersGrid", teachers);

            //return View(teachers);
        }

        
    }
}
