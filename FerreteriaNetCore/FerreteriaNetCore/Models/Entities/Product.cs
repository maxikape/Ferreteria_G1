namespace FerreteriaNetCore.Models.Entities
{
    public class ProductModel
    {
        public virtual long Id {get; set; }
        public virtual string Name { get; set; }

        public virtual string Brand { get; set; }

        public virtual string Category { get; set; }

        public virtual string Description { get; set; }

        public virtual int Quantity { get; set; }

        public virtual void updateQuantity(int quantity)
        {
            this.Quantity = this.Quantity + quantity;

        }
    }
}
