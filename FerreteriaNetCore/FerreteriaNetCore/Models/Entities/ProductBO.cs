using FerreteriaNetCore.Models.DTOs;

namespace FerreteriaNetCore.Models.Entities
{
    public class ProductBO : IProductBO
    {

        public ProductBO(){}
        public virtual string Name { get; set; }

        public virtual string Brand { get; set; }

        public virtual string Category { get; set; }

        public virtual string Description { get; set; }

        public virtual int Quantity { get; set; }
        public virtual bool applies() 
        {
            return true;
        }

        public virtual IProductBO buildNewProduct(ProductEditDTO productDto)
        {
            if (
                productDto.ProductName != null && productDto.ProductName != "" &&
                productDto.Brand != null && productDto.Brand != "" &&
                productDto.Category != null && productDto.Category != ""
                )
            {
                this.Name = productDto.ProductName;
                this.Brand = productDto.Brand;
                this.Category = productDto.Category;
                this.Description = productDto.Description;
                this.Quantity = productDto.Quantity;

                return this;

            } else {
                
                return new NullProductBO();
            }
            
        }

        public virtual void updateQuantity(ProductModel product)
        {
            product.updateQuantity(this.Quantity);
            
        }

        
    }

}
