using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using StarterM.Models;

namespace StarterM.Controllers
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
