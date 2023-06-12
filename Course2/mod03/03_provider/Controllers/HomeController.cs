using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace StarterM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var feature = HttpContext.Features
                    .Get<IRequestCultureFeature>();

            return View(feature);
        }
    }
}
