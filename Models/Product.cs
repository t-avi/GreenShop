namespace GreenShop.Models
{
    public class Product
    {
        private static int IdCounter = 1024; //counter for id generation (static allows counting)
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public int ID { get; }

        public Product(string name, decimal cost, string description) {
            Name = name;
            Description = description;
            Cost = cost;

            ID = IdCounter++;            
        }

        public override string ToString()
        {
            return $"Id: {ID}\nName: {Name}\nDescription: {Description}\nCost: {Cost}$";
            //need to override ToString to better mapping
        }
        
    }
}
