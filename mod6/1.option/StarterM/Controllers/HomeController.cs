using Microsoft.AspNetCore.Mvc;
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
        readonly IOptions<WebsiteProfile> _options;

        public HomeController(IOptions<WebsiteProfile> options)
        {
            _options = options;
        }

        public IActionResult Index()
        {
            return View(_options.Value);
        }
    }
}
