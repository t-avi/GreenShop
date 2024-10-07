using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class ProductController : Controller
    {

        private readonly ProductList productList;

        public ProductController()
        {
            productList = new ProductList(); 
        }
   

        public IActionResult Index(int id)
        {            
            var product = productList.TryGetByID(id);

            return View(product); 

        }
    }
}
