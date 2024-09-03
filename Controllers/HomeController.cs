using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GreenShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        ProductList productList = new ProductList();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id) //use try catch
        {

            var products = productList.GetProductList();

            /*int _id = id ?? -1;

            if (_id < 0) {
                var products = productList.GetProductList();
                return string.Join("\n\n", products);
            }
            else {
                var products = productList.GetProductList();
                return products[_id].ToString();
            }*/

            return View(products);
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
