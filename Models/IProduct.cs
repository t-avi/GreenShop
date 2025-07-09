namespace GreenShop.Models
{
    public interface IProduct
    {
        decimal Cost { get; set; }
        string Description { get; set; }
        //int ID { get; }
        public Guid ID { get; set; }
        string Name { get; set; }
        string Src { get; set; }

        void Edit(string name, string description, decimal cost);
    }
}