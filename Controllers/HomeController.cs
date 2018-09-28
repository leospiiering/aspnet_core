using System.Diagnostics;
using aspnet_core___Copia.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_core___Copia.Controllers
{
    public class HomeController : Controller
    {
 public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    
    }
}
