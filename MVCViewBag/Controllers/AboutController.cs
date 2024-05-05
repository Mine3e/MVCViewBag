using Microsoft.AspNetCore.Mvc;

namespace MVCViewBag.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
