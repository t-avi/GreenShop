namespace GreenShop.Models
{    
    public interface ICompare
    {
        int UserId { get; set; }
        public void AddToCompare(IProduct p);
        public void RemoveFromCompared(IProduct p);
        public List<IProduct> GetComparedProducts();
    }
}