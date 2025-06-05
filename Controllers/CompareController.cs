using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class CompareController : Controller
    {
        private readonly IProductRepository productList;
        private readonly ICompare comparedProducts;
        private readonly ICartRepository cartList;

        public CompareController(IProductRepository productList, ICompare comparedProducts, ICartRepository cartList)
        {
            this.productList = productList;
            this.comparedProducts = comparedProducts;
            this.cartList = cartList;
        }
        public IActionResult Index()
        {
            return View(comparedProducts);
        }
        public IActionResult Add(Guid productId)
        {
            IProduct p = productList.TryGetByID(productId);
            comparedProducts.AddToCompare(p);
            return RedirectToAction("Index", "Home"); 
        }
        public IActionResult Remove(Guid productId)
        {
            IProduct p = productList.TryGetByID(productId);
            comparedProducts.RemoveFromCompared(p);
            return RedirectToAction("Index");
        }
    }
}
