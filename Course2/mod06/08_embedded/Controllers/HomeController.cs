using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace StarterM.Controllers
{
    public class HomeController : Controller
    {
        readonly IFileProvider _provider;

        public HomeController(IFileProvider provider)
        {
            _provider = provider;
        }

        public IActionResult Index()
        {
            var content = _provider.GetDirectoryContents("");
            return View(content);

        }
        //public IActionResult Select(string name)
        //{
        //    var contents = _provider.GetDirectoryContents("");
        //    var file = _provider.GetFileInfo(name);
        //    using var reader = new StreamReader(file.CreateReadStream());
        //    ViewData["result"] = reader.ReadToEnd();
        //    return View(nameof(Index), contents);
        //}

        public IActionResult Select(string name)
        {
            var file = _provider.GetFileInfo(name);
            using var reader = new StreamReader(file.CreateReadStream());
            TempData["result"] = reader.ReadToEnd();
            return RedirectToAction(nameof(Index));
        }

    }
}
