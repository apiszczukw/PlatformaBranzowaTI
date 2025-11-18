using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PlatformaBranzowaTI.Models;

namespace PlatformaBranzowaTI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MapaSektorow()
        {
            return View();
        }

        public IActionResult Raporty()
        {
            return View();
        }

        public IActionResult DaneHistoryczne()
        {
            return View();
        }

        public IActionResult Pogoda()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
