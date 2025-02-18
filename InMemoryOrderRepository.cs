using GreenShop.Models;

namespace GreenShop
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private Dictionary<Guid, ICart> orders = new Dictionary<Guid, ICart>();

        public Guid Add(ICart cart) 
        {
            Guid id = Guid.NewGuid();
            orders.Add(id, cart);
            return id;
        }         
        public Dictionary<Guid, ICart> TryGetAll() { return orders; }
        public ICart ShowOrderById(Guid id) => orders[id];

    }
}
