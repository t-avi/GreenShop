using GreenShop.Models;

namespace GreenShop
{
    public class InMemoryCartRepository : ICartRepository
    {
        private static List<Cart> _carts = new List<Cart>()
        {
            new Cart(Constants.UserId)
        };

        public static Cart TryGetByUserID(int userId) => _carts.FirstOrDefault(c => c.UserId == userId)!;

        public void Add(Cart cart) => _carts.Add(cart);


        public InMemoryCartRepository() { }
    }
}
