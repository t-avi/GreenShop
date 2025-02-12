using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class ProductController : Controller
    {

        private readonly ProductRepository productRepository;

        public ProductController(ProductRepository productRepository)
        {
            this.productRepository = productRepository; 
        }
   

        public IActionResult Index(int id)
        { 
            return View(productRepository.TryGetByID(id)); 
        }
    }
}
