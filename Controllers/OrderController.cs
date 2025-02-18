using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductRepository productList;
        private readonly ICartRepository cartList;
        private readonly IOrderRepository orders;
        private readonly ICart cart;

        public OrderController(IProductRepository productList, ICartRepository cartList, IOrderRepository orders)
        {
            this.productList = productList;
            this.cartList = cartList;
            this.orders = orders;
            this.cart = cartList.TryGetByUserID(Constants.UserId);
        }
        public IActionResult Index()
        {
            return View(cart);
        }
        public IActionResult Done()
        {
            return View("Done");
        }
        public IActionResult Make() 
        {
            var id = orders.Add(cart);
            cart.Clear(); //deleted from order list, debug this
            return RedirectToAction("Done");
        }
    }
}
