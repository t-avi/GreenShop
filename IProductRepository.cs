using GreenShop.Models;

namespace GreenShop
{
    public interface IProductRepository
    {
        void AddProduct(IProduct p);
        List<IProduct> GetAll();
        int GetCount();
        IProduct TryGetByID(Guid id);
    }
}