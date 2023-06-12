using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using StarterM.Models;

namespace StarterM.Controllers
{
    public class HomeController : Controller
    {
        readonly IOptionsSnapshot<WebsiteProfile> _options;

        public HomeController(IOptionsSnapshot<WebsiteProfile> options)
        {
            _options = options;
        }

        public IActionResult Index()
        {
            return View(_options.Value);
        }
    }
}
