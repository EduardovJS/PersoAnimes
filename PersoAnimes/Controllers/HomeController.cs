using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace PersoAnimes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
