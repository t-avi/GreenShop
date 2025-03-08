using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GreenShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductRepository productList;
        private readonly CartRepository cartList;

        public HomeController()
        {
            productList = new ProductRepository();
            cartList = new CartRepository();
        }

        public IActionResult Index(int id) //use try catch
        {
            var products = productList.GetAll();

            return View(products);            
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       
    }
}
