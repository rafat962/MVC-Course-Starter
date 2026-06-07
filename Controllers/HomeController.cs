using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebGIS46.Models;

namespace WebGIS46.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ContentResult ContentResult()
        {
            return Content("Hello World");
        }

        public ViewResult ShowView()
        {
            return View("raafat");
        }
        // home/ShowMix/id?no=13&name=rafat [Querystring]
        public IActionResult ShowMix(int no,string name,int id)
        {
            if(no==13)
            {
                return View("raafat");
            }
            else
            {
                NotFoundResult result = new NotFoundResult();
                return result;
            }
        }
        // Home/Hello ==> Endpoint: /Home/Hello
        public IActionResult Hello()
        {
            return Ok("good") ;
        }

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


        public ViewResult View(string viewName)
        {
            ViewResult result = new ViewResult();

            result.ViewName = viewName;
            return result;
        }
    }
}
