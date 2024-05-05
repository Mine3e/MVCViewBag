using Microsoft.AspNetCore.Mvc;

namespace MVCViewBag.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
