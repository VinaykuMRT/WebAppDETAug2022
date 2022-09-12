using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppDETAug2022MCV.Filters;
using WebAppDETAug2022MCV.Models;

namespace WebAppDETAug2022MCV.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Helo(string name,string loc, string contact)
        {
            ViewBag.UserName = name;
            ViewBag.location = loc;
            ViewBag.Contact = contact;
            ViewBag.UserName = "VINAY";
            return View();

        }
        [MyLog]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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