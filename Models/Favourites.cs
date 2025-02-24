namespace GreenShop.Models
{
    public class Favourites : IFavourites
    {

        public int UserId { get; }
        public Guid Id { get; private set; }
        public List<ICartPosition> Positions { get; private set; }

        public Favourites(int userId)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Positions = new List<ICartPosition>();
        }
        public void AddProduct(ICartPosition p)
        {

            int i = Positions.FindIndex(c => c.Product.Name == p.Product.Name);

            if (i is not -1) { }
            else { Positions.Add(p); }

        }
        public void TryRemoveProduct(ICartPosition p)
        {

            int i = Positions.FindIndex(c => c.Product.Name == p.Product.Name);

            if (i is not -1) { Positions.RemoveAt(i); }

        }
        public void Clear() => Positions.Clear();
        public List<ICartPosition> TryGetAll() => Positions;
    }
}
