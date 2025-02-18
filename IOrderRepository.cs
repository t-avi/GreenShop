using GreenShop.Models;

namespace GreenShop
{
    public interface IOrderRepository
    {
        Guid Add(ICart cart);
        Dictionary<Guid, ICart> TryGetAll();
        ICart ShowOrderById(Guid id);
    }
}