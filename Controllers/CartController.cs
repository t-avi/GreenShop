using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class CartController : Controller
    {
        private readonly ProductRepository productList;
        private readonly Cart cart = CartRepository.TryGetByUserID(Constants.UserId);
     

        public IActionResult Index() //personal cart ID should be added
        {
            return View(cart);
        }

        public IActionResult Add(int productId) 
        {
            cart.AddProduct(new CartPosition(productList.TryGetByID(productId)));
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Remove(int productId)
        {
            //del or -=?
            cart.TryRemoveProduct(new CartPosition(productList.TryGetByID(productId)));
            return RedirectToAction("Index", "Cart");
        }
        public CartController(ProductRepository productList)
        {
             this.productList = productList;
        }
    }
}
