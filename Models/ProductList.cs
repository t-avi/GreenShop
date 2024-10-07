using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GreenShop.Models
{
    public class ProductList
    {
        private static List<Product> products = new List<Product>() {
            new Product("Monstera", 20, "Some plant"),
            new Product("Senecio", 35, "Another plant"),
            new Product("Anthurium", 60, "It's plant too"),
            new Product("Alocasia", 50, "It's plant too")
        }; 

        public void AddListFromJson() { }
        public void LoadNewListFromJson() { }
        public void SaveListToJson() { }        

        public void AddProduct(Product p) { products.Add(p); }

        public Product TryGetByID(int id) => products.FirstOrDefault(product => product.ID == id)!; //apply try catch to incorrect id, ! means non-nullable (check for errors)

        public int GetCount() { return products.Count; }

        public List<Product> GetAll() { return products; }

        public ProductList () {

        }   
    }
}
