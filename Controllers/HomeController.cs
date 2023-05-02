using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAgeApp.Models;

namespace WebAgeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index(DateTime? Birthdate)
        {
            Ages ages = new Ages();
            ages.Birthdate = Birthdate;
            return View(ages);
        }

        //    public IActionResult Index()
        //{
        //    return View();
        //}

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