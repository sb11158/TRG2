using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TRG2.Controllers
{
    public class ProjectPagesController : Controller
    {
        private readonly ILogger<ProjectPagesController> _logger;

        public ProjectPagesController(ILogger<ProjectPagesController> logger)
        {
            _logger = logger;
        }
        //Multi Family
        public IActionResult Element31()
        {
            return View();
        }
        public IActionResult Midtown360()
        {
            return View();
        }
        //Hospitality
        public IActionResult KoloaLanding()
        {
            return View();
        }
        public IActionResult WestQuarter()
        {
            return View();
        }
        //Industrial
        public IActionResult XR1()
        {
            return View();
        }

    }
}
