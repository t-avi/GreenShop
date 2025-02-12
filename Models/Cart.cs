using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GreenShop.Models
{
    public class Cart {

        public Guid Id;

        public int UserId;

        private List<CartPosition> positions;
        public List<CartPosition> Positions { get => positions; private set => positions = value; }
        public decimal FullCartPrice { get => Positions.Sum(p => p.PositionPrice); }

        public Cart(int userId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Positions = new List<CartPosition>();
        }

        public void AddProduct(CartPosition p) {

            int i = Positions.FindIndex(c => c.Product.Name == p.Product.Name);

            if (i is not -1) { Positions[i].Count++; }
            else { Positions.Add(p); }
       
        }

        public void TryRemoveProduct(CartPosition p) {
            //удалять или уменьшать количество(!)

            int i = Positions.FindIndex(c => c.Product.Name == p.Product.Name);

            if (i is not -1) { Positions.RemoveAt(i); }
        }

        public List<CartPosition> TryGetAll() => Positions;

    }
    
}
