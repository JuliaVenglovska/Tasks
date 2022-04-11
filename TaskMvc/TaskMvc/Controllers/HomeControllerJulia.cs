using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TaskMvc.Models;

namespace TaskMvc.Controllers
{
    public class HomeControllerJulia : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PersonViewModel person)
        {
            return View("Name", person);
        }
    }
}
