using ActionResult.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ActionResult.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        ////// Content Result
        //public IActionResult Index()
        //{
        //    return Content("<h1>Hello, I am Leyla</h1>", "text/html");
        //}

        ////// Json Result
        //public IActionResult Index()
        //{
        //    Human human = new Human()
        //    {
        //        Id= 1,
        //        Name = "Leyla",
        //        Surname = "Shafiyeva",
        //        Age = 19
        //    };
        //    return Json(human);
        //}

        ////// RedirectResult
        //public IActionResult Index()
        //{
        //    return Redirect("https://www.google.com/");
        //}

        ////// EmptyResult
        //public IActionResult Index()
        //{
        //    return new EmptyResult();
        //}

        //ViewResult
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