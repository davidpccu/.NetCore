using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace StarterM.Controllers
{
    public class HomeController : Controller
    {
        readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            ViewBag.Message = _localizer["greeting"];

            var feature = HttpContext.Features
                    .Get<IRequestCultureFeature>();

            return View(feature);
        }
    }
}
