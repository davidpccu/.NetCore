using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.Controllers
{
    public class StatusCodeController : Controller
    {
        public IActionResult Index(string code)
        {
            ViewBag.code = code;
            return View();
        }
    }
}
