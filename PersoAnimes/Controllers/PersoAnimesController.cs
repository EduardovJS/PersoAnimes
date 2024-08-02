using Microsoft.AspNetCore.Mvc;

namespace PersoAnimes.Controllers
{
    public class PersoAnimesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
