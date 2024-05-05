using Microsoft.AspNetCore.Mvc;
using MVCViewBag.Models;

namespace MVCViewBag.Controllers
{
    public class DesignController : Controller
    {
        public IActionResult Index()
        {
            Furniture furniture = new Furniture()
            {
                Id = 1,
                Name = "Chair1",
                Price = 100
            };
            Furniture furniture1 = new Furniture()
            {
                Id = 2,
                Name = "Chair2",
                Price = 100
            };
            Furniture furniture2 = new Furniture()
            {
                Id = 3,
                Name = "Chair3",
                Price = 100
            };
            List<Furniture> furnitures = new List<Furniture>();
            furnitures.Add(furniture1);
            furnitures.Add(furniture2);
            furnitures.Add(furniture);
            ViewBag.Data= furnitures;
            return View();
        }
    }
}
