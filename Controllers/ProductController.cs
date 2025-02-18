using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository; 
        }
   
        public IActionResult Index(Guid id)
        { 
            return View(productRepository.TryGetByID(id)); 
        }
    }
}
