using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GreenShop.Models
{
    public class Cart : ICart   
    {

        public Guid Id { get; private set; }

        public int UserId;

        private List<ICartPosition> positions;
        public List<ICartPosition> Positions { get => positions; private set => positions = value; }
        public decimal FullCartPrice { get => Positions.Sum(p => p.PositionPrice); }

        public Cart(int userId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Positions = new List<ICartPosition>();
        }

        public void AddProduct(ICartPosition p) {

            int i = Positions.FindIndex(c => c.Product.Name == p.Product.Name);

            if (i is not -1) { Positions[i].Count++; }
            else { Positions.Add(p); }
       
        }

        public void TryRemoveProduct(ICartPosition p) {
            //удалять или уменьшать количество(!)

            int i = Positions.FindIndex(c => c.Product.Name == p.Product.Name);

            if (i is not -1) { Positions.RemoveAt(i); }
        }

        public List<ICartPosition> TryGetAll() => Positions;

    }
    
}
