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
        public IActionResult NewProduct()
        {
            return View("NewProduct");
        }
        public IActionResult RemoveProduct(Guid ID)
        {
            productList.RemoveProductByID(ID);
            return RedirectToAction("Products");
        }
        public IActionResult EditProduct(Guid ID)
        {
            return View("EditProduct", productList.TryGetByID(ID));
        }

        [HttpPost]
        public IActionResult EditSelectedProduct(string name, string description, string cost, string ID)
        {
            productList.TryGetByID(Guid.Parse(ID)).Edit(name,  description,  Convert.ToDecimal(cost));
            return RedirectToAction("Products");
        }

        [HttpPost]
        public string AddProduct(string name, string description, string cost)
        {
            productList.AddProduct(new Product(name, Convert.ToDecimal(cost), description, "7.jpg"));
            return $"Done. Product added!";
        }
    }
}
