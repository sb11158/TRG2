using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TRG2.Models;

namespace TRG2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AllProjects()
        {
            return View();
        }
        public IActionResult MultiFamilyProjects()
        {
            return View();
        }
        public IActionResult IndustrialProjects()
        {
            return View();
        }
        public IActionResult HospitalityProjects()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult GiveBack()
        {
            return View();
        }
        public IActionResult History()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Sustainability()
        {
            return View();
        }
        public IActionResult News()
        {
            return View();
        }
        public IActionResult TESTER()
        {
            return View();
        }

        //Project Details
        public IActionResult Element31()
        {
            return View("Home/ProjectPages/MultiFamily/Element31.cshtml");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
