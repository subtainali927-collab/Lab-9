using Microsoft.AspNetCore.Mvc;
using Muhammad_Haseeb_PMS_MVC_Lab_9.Models;
using System.Diagnostics;

namespace Muhammad_Haseeb_PMS_MVC_Lab_9.Controllers
{
    public class HomeController : Controller
    {
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
