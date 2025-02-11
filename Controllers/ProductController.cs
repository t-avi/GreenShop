using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class ProductController : Controller
    {

        private readonly ProductRepository productRepository;

        public ProductController()
        {
            productRepository = new ProductRepository(); 
        }
   

        public IActionResult Index(int id)
        {            
            var product = productRepository.TryGetByID(id);

            return View(product); 

        }
    }
}
