using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            var ex = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var status = HttpContext.Response.StatusCode;

            return View((ex, status));
        }
    }
}
