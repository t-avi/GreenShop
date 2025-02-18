using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace GreenShop.Models
{
    public class Cart : ICart   
    {
        public int UserId;
        public Guid Id { get; private set; } 
        public List<ICartPosition> Positions { get; private set; }
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
        public void ReduceProductCount(ICartPosition p)
        {
            int i = Positions.FindIndex(c => c.Product.Name == p.Product.Name);

            if (i is not -1) 
            {
                if (Positions[i].Count >  1) { Positions[i].Count--; }
                else { TryRemoveProduct(p); }
            }
            
        }
        public void TryRemoveProduct(ICartPosition p) {

            int i = Positions.FindIndex(c => c.Product.Name == p.Product.Name);

            if (i is not -1) { Positions.RemoveAt(i); }

        }
        public void Clear() => Positions.Clear();        
        public List<ICartPosition> TryGetAll() => Positions;

    }
    
}
