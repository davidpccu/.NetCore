using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using StarterM.Models;

namespace StarterM.Controllers
{
    public class HomeController : Controller
    {
        readonly IOptionsSnapshot<WebsiteProfile> _options;
        readonly IConfiguration _configuration;

        public HomeController(IOptionsSnapshot<WebsiteProfile> options, IConfiguration configuration)
        {
            _options = options;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View(_options.Value);
            //===========================
            //WebsiteProfile p = new();
            //_configuration.GetSection("aaa:bbb").Bind(p);
            //return View(p);
        }

        public IActionResult GetEmail()
        {
            return Content(_configuration["email"]);
        }
        public IActionResult GetDefault()
        {
            return Content(_configuration["logging:loglevel:default"]);
        }
    }
}
