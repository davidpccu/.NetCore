using Microsoft.AspNetCore.Mvc;

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
    }
}
