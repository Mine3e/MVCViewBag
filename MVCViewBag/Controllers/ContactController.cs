using Microsoft.AspNetCore.Mvc;

namespace MVCViewBag.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
