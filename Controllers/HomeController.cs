using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GreenShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductRepository productList;
        private readonly CartRepository cartList;

        public HomeController(ProductRepository productList, CartRepository cartList)
        {
            this.productList = productList;
            this.cartList = cartList;
        }

        public IActionResult Index(int id) //use try catch
        {
            return View(productList.GetAll());            
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       
    }
}
