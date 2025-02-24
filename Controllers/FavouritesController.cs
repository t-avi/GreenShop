using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class FavouritesController : Controller
    {
        private readonly IProductRepository productList;
        private readonly IFavouritesRepository favouritesList;
        private readonly IFavourites favourites;

        public FavouritesController(IProductRepository productList, IFavouritesRepository favouritesList, IFavourites favourites)
        {
            this.productList = productList;
            this.favouritesList = favouritesList;
            this.favourites = favouritesList.TryGetByUserID(Constants.UserId);
        }
        public IActionResult Index()
        {
            return View(favourites);
        }
        public IActionResult Add(Guid productId)
        {
            favourites.AddProduct(new CartPosition(productList.TryGetByID(productId)));
            return RedirectToAction("Index"); 
        }
        public IActionResult Remove(Guid productId)
        {
            favourites.TryRemoveProduct(new CartPosition(productList.TryGetByID(productId)));
            return RedirectToAction("Index");
        }
    }
}
