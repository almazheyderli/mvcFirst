using FurnitureWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureWebApp.Controllers
{
    public class OurDesignController : Controller
    {
        public IActionResult Index()
        {
            Furniture chair = new Furniture()
            {
                Id = 1,
                Name = "chair",
                Price=50

            };
            Furniture sofa = new Furniture()
            {
                Id = 2,
                Name = "sofa",
                Price = 500

            };
            Furniture table = new Furniture()
            {
                Id = 3,
                Name = "table",
                Price = 40
            };
            List<Furniture> furnitures = new List<Furniture>();
            furnitures.Add(chair);
            furnitures.Add(sofa);
            furnitures.Add(table);
            ViewBag.Furniture = furnitures;

            return View();
        }
    }
}
