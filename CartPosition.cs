using System.Diagnostics.Metrics;
using GreenShop.Models;

namespace GreenShop
{
    public class CartPosition : ICartPosition
    {
        public Guid Id { get; private set; }
        public IProduct Product { get; set; }
        public int Count { get; set; }
        public decimal PositionPrice { get => Count * Product.Cost; }

        public CartPosition(IProduct p)
        {
            Id = Guid.NewGuid();
            Product = p;
            Count = 1;
        }

    }

}
