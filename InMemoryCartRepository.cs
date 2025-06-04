using GreenShop.Models;

namespace GreenShop
{
    public class InMemoryCartRepository : ICartRepository
    {
        private static List<Cart> _carts = new List<Cart>()
        {
            new Cart(Constants.UserId)
        };
         
        public void Clear(int userId) {
            _carts = _carts.Where(c => c.UserId != userId).ToList();
            //var i = _carts.IndexOf(_carts.FirstOrDefault(c => c.UserId == userId)!);
            //_carts[i].Clear();
        }        
        public ICart TryGetByUserID(int userId) => _carts.FirstOrDefault(c => c.UserId == userId)!;
        public void Add(Cart cart) => _carts.Add(cart);
    }
}
