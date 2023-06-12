using Microsoft.AspNetCore.Mvc;

namespace StarterM.Controllers
{
    public class HomeController : Controller
    {
        readonly IMyService _myService;

        public HomeController(IMyService myService)
        {
            _myService = myService;
        }

        public IActionResult Index()
        {
            //IMyService service=new MySevice();
            //Console.WriteLine(service.Id);
            //Console.WriteLine(service.Id);

            ViewBag.id=_myService.Id;

            return View();
        }
    }
}
