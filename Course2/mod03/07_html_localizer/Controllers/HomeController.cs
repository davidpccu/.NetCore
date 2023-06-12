using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;

namespace StarterM.Controllers
{
    public class HomeController : Controller
    {
        readonly IStringLocalizer<HomeController> _localizer;
        readonly IHtmlLocalizer<HomeController> _localizer2;

        public HomeController(IStringLocalizer<HomeController> localizer, IHtmlLocalizer<HomeController> localizer2)
        {
            _localizer = localizer;
            _localizer2 = localizer2;
        }

        public IActionResult Index()
        {
            ViewBag.Message = _localizer["greeting"];
             ViewBag.Message2 = _localizer2["greeting"];

            var feature = HttpContext.Features
                    .Get<IRequestCultureFeature>();

            return View(feature);
        }
    }
}
