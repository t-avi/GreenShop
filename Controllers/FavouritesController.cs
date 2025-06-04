using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Controllers
{
    public class FavouritesController : Controller
    {
        private readonly IProductRepository productList;
        private readonly IFavouritesRepository favouritesList;
        private readonly IFavourites favourites;

        private readonly ICompare comparedProducts;
        private readonly ICartRepository cartList;

        public FavouritesController(IProductRepository productList, IFavouritesRepository favouritesList, IFavourites favourites, ICompare comparedProducts, ICartRepository cartList)
        {
            this.productList = productList;
            this.favouritesList = favouritesList;
            this.favourites = favouritesList.TryGetByUserID(Constants.UserId);

            this.comparedProducts = comparedProducts;
            this.cartList = cartList;
        }
        public IActionResult Index()
        {
            var cart = cartList.TryGetByUserID(Constants.UserId);
            ViewBag.ProductCount = cart?.Amount == 0 ? "" : cart?.Amount.ToString();

            var amount = comparedProducts.GetComparedProducts().Count;
            ViewBag.ComparedCount = amount == 0 ? "" : amount.ToString();

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
