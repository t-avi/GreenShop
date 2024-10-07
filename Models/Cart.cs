using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GreenShop.Models
{
    public class Cart {

        public Guid Id;

        public string UserId;

        private static List<CartPosition> Positions { get; set; } //make it get-set


        public decimal Cost
        {

            get { return Positions.Sum(p => p.PositionPrice); }

        }
        public void AddProduct(CartPosition p) {
            Positions.Add(p);
        }

        public void RemoveProduct(CartPosition p) { }

        public List<CartPosition> GetAll() { return Positions; }

        public Cart(string userId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Positions = new List<CartPosition>();
        }
    }
    
}
