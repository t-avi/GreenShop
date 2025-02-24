using GreenShop.Models;

namespace GreenShop
{
    public interface IFavouritesRepository
    {
        void Add(IFavourites favourites);
        IFavourites TryGetByUserID(int userId);
    }
}