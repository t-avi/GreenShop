namespace GreenShop.Models
{
    public class Compare : ICompare
    {
        public int UserId { get; set; }
        private readonly List<IProduct> products;

        public Compare()
        {
            UserId = Constants.UserId;
            products = new List<IProduct>();
        }

        public void AddToCompare(IProduct p) 
        {
            if (p != null && products.FirstOrDefault(c => c.ID == p.ID) == null) //if product exists and was not compared 
            {
                products.Add(p);
            }
        }
        
        public void RemoveFromCompared(IProduct p) => products.Remove(p); 
        
        public List<IProduct> GetComparedProducts() => products;
    }
}
