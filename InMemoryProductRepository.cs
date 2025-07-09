using GreenShop.Models;

namespace GreenShop
{
    public class InMemoryProductRepository : IProductRepository
    {
        private static List<IProduct> products = new List<IProduct>() {
            new Product("Monstera", 20, "Some plant", "1.PNG"),
            new Product("Senecio", 35, "Another plant", "2.PNG"),
            new Product("Anthurium", 60, "It's plant too", "3.PNG"),
            new Product("Alocasia", 50, "It's plant too", "4.PNG")
        };

        //public void AddListFromJson() { }
        //public void LoadNewListFromJson() { }
        //public void SaveListToJson() { }

        public void AddProduct(IProduct p) => products.Add(p);

        public void RemoveProductByID(Guid id) => products.Remove(products.FirstOrDefault(c => c.ID == id)!);
        public IProduct TryGetByID(Guid id) => products.FirstOrDefault(product => product.ID == id)!; //apply try catch to incorrect id, ! means non-nullable (check for errors)

        public int GetCount() => products.Count; 

        public List<IProduct> GetAll() => products;

        public InMemoryProductRepository() { }       

    }
}
