namespace GreenShop.Models
{
    public class Product : IProduct
    {
        public Guid ID { get; set; }
        public string Src { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public Product(string name, decimal cost, string description, string src)
        {
            Name = name;
            Description = description;
            Cost = cost;

            ID = Guid.NewGuid();
            Src = src;
        }
        public override string ToString() => $"Id: {ID}\nName: {Name}\nDescription: {Description}\nCost: {Cost}$";

    }
}
