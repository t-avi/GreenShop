using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductRepository productList;
        private readonly ICart cart = CartRepository.TryGetByUserID(Constants.UserId);
     

        public IActionResult Index() //personal cart ID should be added
        {
            return View(cart);
        }

        public IActionResult Add(Guid productId) 
        {
            cart.AddProduct(new CartPosition(productList.TryGetByID(productId)));
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Remove(Guid productId)
        {
            //del or -=?

            cart.TryRemoveProduct(new CartPosition(productList.TryGetByID(productId)));
            return RedirectToAction("Index", "Cart");
        }
        public CartController(IProductRepository productList)
        {
             this.productList = productList;
        }
    }
}
