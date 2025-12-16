using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PlatformaBranzowaTI.DAL;
using PlatformaBranzowaTI.Models;

namespace PlatformaBranzowaTI.Controllers
{
    public class HomeController : Controller
    {
        SensorsContext db;

        public HomeController(SensorsContext db)
        {
            this.db = db;
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
            var dane = db.SensorReports.ToList();

            return View(dane);
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
