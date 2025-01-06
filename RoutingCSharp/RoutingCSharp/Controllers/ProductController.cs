using Microsoft.AspNetCore.Mvc;
using RoutingCSharp.Models;

namespace RoutingCSharp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(string id)
        {
            return View(new Product()
            {
                Id = id,
                Name = $"Product Name: {id}"
            });
        }
    }
}
