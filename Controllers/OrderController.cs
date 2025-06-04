using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization.Formatters.Binary;

namespace GreenShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductRepository productList;
        private readonly ICartRepository cartList;
        private readonly IOrderRepository orders;
        private readonly ICart cart;

        private readonly ICompare comparedProducts;

        public OrderController(IProductRepository productList, ICartRepository cartList, IOrderRepository orders, ICompare comparedProducts)
        {
            this.productList = productList;
            this.cartList = cartList;
            this.orders = orders;
            this.cart = cartList.TryGetByUserID(Constants.UserId);

            this.comparedProducts = comparedProducts;
        }
        public IActionResult Index()
        {
            var cart = cartList.TryGetByUserID(Constants.UserId);
            ViewBag.ProductCount = cart?.Amount == 0 ? "" : cart?.Amount.ToString();

            var amount = comparedProducts.GetComparedProducts().Count;
            ViewBag.ComparedCount = amount == 0 ? "" : amount.ToString();

            return View(cart);
        }
        public IActionResult Done()
        {
            return View("Done");
        }

        [HttpPost]
        public string Make(Order order) 
        {
            var actualCart = cartList.TryGetByUserID(Constants.UserId);
            orders.Add(actualCart);
            cartList.Clear(Constants.UserId); //tf this one kills both cart and orders i hate keep objs in memory bruh. i think i neet to keep in on DB or smth
            return $"Done. Your order total price is: {actualCart.FullCartPrice}";
        }
    }
}

