namespace FerreteriaNetCore.Models.Entities
{
    public class ProductModel
    {
        public string Name { get; set; }

        public string Brand { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public void updateQuantity(int quantity)
        {
            this.Quantity = this.Quantity + quantity;

        }
    }
}
