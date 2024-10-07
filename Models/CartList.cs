using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace GreenShop.Models
{
    public class CartList
    {
        private static List<Cart> _carts = new List<Cart>() 
        {
        new Cart("userId")
        };

        public static Cart TryGetByUserID(string userId)
        {
            return _carts.FirstOrDefault(c => c.UserId == userId)!;
        }

        public CartList()
        {

        }
    }
}
