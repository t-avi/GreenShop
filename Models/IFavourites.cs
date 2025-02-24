namespace GreenShop.Models
{
    public interface IFavourites
    {
        public int UserId { get; }
        void AddProduct(ICartPosition p);
        List<ICartPosition> TryGetAll();
        void TryRemoveProduct(ICartPosition p);
        void Clear();
    }
}