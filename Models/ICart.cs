
namespace GreenShop.Models
{
    public interface ICart

    {
        decimal FullCartPrice { get; }
        void AddProduct(ICartPosition p);
        void ReduceProductCount(ICartPosition p);
        List<ICartPosition> TryGetAll();
        void TryRemoveProduct(ICartPosition p);
    }
}