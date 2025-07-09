using GreenShop.Models;

namespace GreenShop
{
    public interface IProductRepository
    {
        void AddProduct(IProduct p);
        List<IProduct> GetAll();
        int GetCount();
        void RemoveProductByID(Guid iD);
        IProduct TryGetByID(Guid id);
    }
}