using GreenShop.Models;

namespace GreenShop
{
    public class CartRepository
    {
        private static List<Cart> _carts = new List<Cart>()
        {
            new Cart(Constants.UserId)
        };

        public static Cart TryGetByUserID(int userId)
        {
            return _carts.FirstOrDefault(c => c.UserId == userId)!;
        }
        public CartRepository()
        {
                
        }
    }
}
