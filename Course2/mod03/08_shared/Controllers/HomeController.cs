using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Localization;
using StarterM.Shared;

namespace StarterM.Controllers
{
    public class HomeController : Controller
    {
        readonly IStringLocalizer<HomeController> _localizer;
        readonly IHtmlLocalizer<HomeController> _localizer2;
        readonly IHtmlLocalizer<Common> _localizer3;

        public HomeController(IStringLocalizer<HomeController> localizer, IHtmlLocalizer<HomeController> localizer2, IHtmlLocalizer<Common> localizer3)
        {
            _localizer = localizer;
            _localizer2 = localizer2;
            _localizer3 = localizer3;
        }

        public IActionResult Index()
        {
            ViewBag.Message = _localizer["greeting"];
            ViewBag.Message2 = _localizer2["greeting"];
            ViewBag.Message3 = _localizer3["fileNotFound"];

            var feature = HttpContext.Features
                    .Get<IRequestCultureFeature>();

            return View(feature);
        }
    }
}
