using GreenShop.Models;

namespace GreenShop
{
    public interface ICartRepository
    {
        void Add(Cart cart);
        //Cart TryGetByUserID(int userId);
    }
}