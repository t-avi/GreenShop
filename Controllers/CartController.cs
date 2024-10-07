using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class CartController : Controller
    {
        private readonly ProductList productList = new ProductList();
        private readonly Cart cart = CartList.TryGetByUserID("userId");
        public CartController() 
        {
         
        }

        public IActionResult Index() //personal cart ID should be added
        {            
            return View(cart);
        }

        public void Add(int productId) 
        {
            var prod = productList.TryGetByID(productId);
            cart.AddProduct(new CartPosition(productList.TryGetByID(productId)));

        }
    }
}
