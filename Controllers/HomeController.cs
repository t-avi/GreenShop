using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GreenShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productList;
        private readonly ICartRepository cartList;

        public HomeController(IProductRepository productList, ICartRepository cartList)
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
