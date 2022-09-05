using HotelManagementSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HotelManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HotelDbContext db;
        

        public HomeController(ILogger<HomeController> logger, HotelDbContext db, UserManager<User> userManager, SignInManager<User> signInManager)
        {

            _logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult About()
        {
            ViewBag.Message = "This is the best hotel in the area with a lot of services that may enhance your experience";
            return View();
        }
        public IActionResult Services()
        {
            ViewBag.Message = "This hotel provides you with the following services";
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
        

    }
}