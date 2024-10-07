using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GreenShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductList productList;
        private readonly CartList cartList;

        public HomeController()
        {
            productList = new ProductList();
            cartList = new CartList();
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
