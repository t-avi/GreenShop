using GreenShop.Models;

namespace GreenShop
{
    public class InMemoryFavouritesRepository : IFavouritesRepository
    {
        private static List<IFavourites> _favs = new List<IFavourites>()
        {
            new Favourites(Constants.UserId)
        };

        public IFavourites TryGetByUserID(int userId) => _favs.FirstOrDefault(c => c.UserId == userId)!;
        public void Add(IFavourites favourites) => _favs.Add(favourites);
    }
}

