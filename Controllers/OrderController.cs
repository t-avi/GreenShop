using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class OrderController : Controller
    {
        //need to add IOrder, Order and IOrderRepository, OrderRepository in future
        private readonly ICart cart = InMemoryCartRepository.TryGetByUserID(Constants.UserId);

        public IActionResult Index()
        {
            return View(cart);
        }
        public IActionResult Done()
        {
            return View("Done");
        }
        public IActionResult Make() {

            //here we write down data
            cart.Clear();
            return RedirectToAction("Done");
        }
    }
}
