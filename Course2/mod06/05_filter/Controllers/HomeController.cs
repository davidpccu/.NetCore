using Microsoft.AspNetCore.Mvc;
using StarterM.Models;

namespace StarterM.Controllers
{
    public class HomeController : Controller
    {
        readonly ILogger _logger;

        public HomeController(ILoggerFactory  factory)
        {
            _logger = factory.CreateLogger("MyLog");
        }

        public IActionResult Index()
        {
            _logger.LogCritical("Log Message - Critical:{path} {time:t}", Request.Path, DateTime.Now);
            _logger.LogError("Log Message - Error:{path}", Request.Path);
            _logger.LogWarning("Log Message - Warning:{path}", Request.Path);
            _logger.LogInformation("Log Message - Information:{path}", Request.Path);
            _logger.LogDebug("Log Message - Debug:{path}", Request.Path);
            _logger.LogTrace("Log Message - Trace:{path}", Request.Path);

            //Console.WriteLine($"{DateTime.Now:t}");

            return View();
        }

        [HttpPost]
        public IActionResult Index(string number)
        {
            try
            {
                int i = int.Parse(number);
                ViewBag.Message = $"Result: {i * i}";
            }
            catch (ArgumentNullException ex)
            {
                _logger.LogWarning(MyLogEvents.ArgumentNullError, ex, "Path:{path}", Request.Path);
                ViewBag.Message = "沒有輸入值";
            }
            catch (OverflowException ex)
            {
                _logger.LogWarning(MyLogEvents.OverflowError, ex, "Path:{path}", Request.Path);
                ViewBag.Message = "超過數值範圍";
            }
            catch (FormatException ex)
            {
                _logger.LogWarning(MyLogEvents.FormatError, ex, "Path:{path}", Request.Path);
                ViewBag.Message = "請輸入數字";
            }
            return View();
        }

    }
}
