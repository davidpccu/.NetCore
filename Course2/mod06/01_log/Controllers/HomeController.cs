using Microsoft.AspNetCore.Mvc;

namespace StarterM.Controllers
{
    public class HomeController : Controller
    {
        readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Home.Index");
            return View();
        }
    }
}
