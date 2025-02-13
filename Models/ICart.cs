
namespace GreenShop.Models
{
    public interface ICart
    {
        void AddProduct(ICartPosition p);
        List<ICartPosition> TryGetAll();
        void TryRemoveProduct(ICartPosition p);
    }
}