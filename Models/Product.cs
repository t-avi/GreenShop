namespace GreenShop.Models
{
    public class Product
    {
        private static int IdCounter = 1024; //counter for id generation (static allows counting)
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public int ProductID { get; }

        public Product(string name, double cost, string description) {
            Name = name;
            Description = description;
            Cost = cost;

            ProductID = IdCounter++;            
        }

        public override string ToString()
        {
            return $"Id: {ProductID}\nName: {Name}\nDescription: {Description}\nCost: {Cost}$";
            //need to override ToString to better mapping
        }
        
    }
}
