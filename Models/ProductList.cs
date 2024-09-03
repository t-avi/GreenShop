using Microsoft.AspNetCore.Mvc;

namespace GreenShop.Models
{
    public class ProductList
    {
        List<Product> products = new List<Product>();

        public void AddListFromJson() { }
        public void LoadNewListFromJson() { }
        public void SaveListToJson() { }        

        public void AddProduct(Product p) { products.Add(p); }

        public int GetCount() { return products.Count; }

        public List<Product> GetProductList()
        {
            return products;
        }

        public ProductList () {
            AddProduct(new Product("Monstera", 20, "Some plant"));
            AddProduct(new Product("Senecio", 35, "Another plant"));
            AddProduct(new Product("Anthurium", 60, "It's plant too"));
        }   
    }
}
