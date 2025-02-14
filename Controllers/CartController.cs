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
            return RedirectToAction("Index"); //should redirect to home or cart, now only to cart
        }

        public IActionResult Remove(Guid productId)
        {
            cart.TryRemoveProduct(new CartPosition(productList.TryGetByID(productId)));
            return RedirectToAction("Index");
        }
        public IActionResult ReduceCount(Guid productId)
        {
            cart.ReduceProductCount(new CartPosition(productList.TryGetByID(productId)));
            return RedirectToAction("Index");
        }
        public CartController(IProductRepository productList)
        {
             this.productList = productList;
        }
    }
}
