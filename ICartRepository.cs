using GreenShop.Models;

namespace GreenShop
{
    public interface ICartRepository
    {
        void Add(Cart cart);
        ICart TryGetByUserID(int userId);
    }
}