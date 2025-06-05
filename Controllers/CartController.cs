using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductRepository productList;
        private readonly ICartRepository cartList;
        private readonly ICart cart;

        private readonly ICompare comparedProducts;

        public CartController(IProductRepository productList, ICartRepository cartList, IOrderRepository orders, ICompare comparedProducts)
        {
            this.productList = productList;
            this.cartList = cartList;
            this.cart = cartList.TryGetByUserID(Constants.UserId);

            this.comparedProducts = comparedProducts;
        }
        public IActionResult Index()
        {
            var cart = cartList.TryGetByUserID(Constants.UserId) == null ? new Cart(Constants.UserId) : cartList.TryGetByUserID(Constants.UserId);
            return View(cart);
        }
        public IActionResult Add(Guid productId) 
        {
            cart.AddProduct(new CartPosition(productList.TryGetByID(productId)));
            return RedirectToAction("Index", "Home");
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
    }
}
