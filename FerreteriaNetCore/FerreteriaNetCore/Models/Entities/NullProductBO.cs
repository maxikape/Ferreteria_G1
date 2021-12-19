using FerreteriaNetCore.Models.DTOs;

namespace FerreteriaNetCore.Models.Entities
{
    public class NullProductBO : IProductBO
    {
        public virtual string Name { get; set; }

        public virtual string Brand { get; set; }

        public virtual string Category { get; set; }

        public virtual string Description { get; set; }

        public virtual int Quantity { get; set; }
        public virtual bool applies() 
        {
            return false;
        }

        public virtual IProductBO buildNewProduct(ProductEditDTO productDto)
        {
            return new NullProductBO();
        }

        public virtual void updateQuantity(ProductModel product){}
    }

}
