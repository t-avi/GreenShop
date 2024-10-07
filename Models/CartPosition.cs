using System.Diagnostics.Metrics;

namespace GreenShop.Models
{
    public class CartPosition
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
        public decimal PositionPrice {
            get {

                return Count * Product.Cost;
            }
        
        }

        public CartPosition(Product p, int c) { 
        
            Product = p;    
            Count = c;

        }
        public CartPosition(Product p)
        {

            Product = p;
            Count = 1;
        }
    }
}
