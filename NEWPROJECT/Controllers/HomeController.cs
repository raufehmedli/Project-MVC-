using Microsoft.AspNetCore.Mvc;
using NEWPROJECT.Models;
using System.Diagnostics;

namespace NEWPROJECT.Controllers
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
            ViewBag.Link = "Home";
            return View();
        }
        public IActionResult Contact()
        {
            ViewBag.Link = "Contact";
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Link = "About";
            return View();
        }
    

     
    }
}