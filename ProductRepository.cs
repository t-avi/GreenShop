using GreenShop.Models;

namespace GreenShop
{
    public class ProductRepository
    {
        private static List<Product> products = new List<Product>() {
            new Product("Monstera", 20, "Some plant", "1.PNG"),
            new Product("Senecio", 35, "Another plant", "2.PNG"),
            new Product("Anthurium", 60, "It's plant too", "3.PNG"),
            new Product("Alocasia", 50, "It's plant too", "4.PNG")
        };

        public void AddListFromJson() { }
        public void LoadNewListFromJson() { }
        public void SaveListToJson() { }

        public void AddProduct(Product p) => products.Add(p); 

        public Product TryGetByID(int id) => products.FirstOrDefault(product => product.ID == id)!; //apply try catch to incorrect id, ! means non-nullable (check for errors)

        public int GetCount() => products.Count; 

        public List<Product> GetAll() => products;

        public ProductRepository() { }       

    }
}
