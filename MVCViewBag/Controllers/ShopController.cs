using Microsoft.AspNetCore.Mvc;

namespace MVCViewBag.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
