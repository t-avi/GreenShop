using GreenShop.Models;

namespace GreenShop
{
    public interface ICartPosition
    {
        int Count { get; set; }
        decimal PositionPrice { get; }
        IProduct Product { get; set; }

    }
}