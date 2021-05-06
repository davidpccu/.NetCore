using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using StarterM.Modles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.Controlls
{
    public class HomeController : Controller
    {
        readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;;
        }

        public IActionResult Index()
        {
            WebsiteProfile wkProfile = new WebsiteProfile();
            _configuration.Bind(wkProfile);

            //return Content(_configuration["email"]);
            //return Content(_configuration["logging:loglevel:default"]);
            return Json(wkProfile);
        }
    }
}
