using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GreenShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productList;
        private readonly ICartRepository cartList;
        private readonly IOrderRepository orders;
        private readonly ICompare comparedProducts;

        public HomeController(IProductRepository productList, ICartRepository cartList, IOrderRepository orders, ICompare comparedProducts)
        {
            this.productList = productList;
            this.cartList = cartList;
            this.orders = orders;
            this.comparedProducts = comparedProducts;

        }

        public IActionResult Index(int id)
        {
            //var cart = cartList.TryGetByUserID(Constants.UserId) == null ? new Cart(Constants.UserId) : cartList.TryGetByUserID(Constants.UserId);
            //ViewBag.ProductCount = cart?.Amount == 0 ? "" : cart?.Amount.ToString();

            //var amount = comparedProducts.GetComparedProducts().Count;
            //ViewBag.ComparedCount = amount == 0 ? "" : amount.ToString();

            return View(productList);            
        }

        [HttpPost]
        public IActionResult Search(string name)
        {
            List<IProduct> result = new List<IProduct>();

            //InMemoryProductRepository result = new InMemoryProductRepository(); 
            //result.GetAll().Clear(); //why result is a copy of productList......

            foreach (var product in productList.GetAll().ToList()) 
            {
                if (product.Name.ToLower() == name.ToLower())
                {
                    result.Add(product);
                }
            }

            return View("SearchResult", result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       
    }
}
