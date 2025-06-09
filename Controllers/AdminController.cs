using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductRepository productList;
        private readonly IOrderRepository orders;
        public AdminController(IProductRepository productList, IOrderRepository orders)
        {
            this.productList = productList;
            this.orders = orders;

        }
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult Orders()
        {
            return View("Orders");
        }
        public IActionResult Products()
        {
            return View(productList);
        }
        public IActionResult Roles()
        {
            return View("Roles");
        }
        public IActionResult Users()
        {
            return View("Users");
        }
    }
}
