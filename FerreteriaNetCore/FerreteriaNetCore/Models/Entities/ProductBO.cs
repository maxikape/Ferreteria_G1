using proyectoFerreteria.Models.DTOs;

namespace FerreteriaNetCore.Models.Entities
{
    public class ProductBO : IProductBO
    {

        public ProductBO(){}
        public string Name { get; set; }

        public string Brand { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }
        public bool applies() 
        {
            return true;
        }

        public IProductBO buildNewProduct(ProductEditDTO productDto)
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

        public void updateQuantity(ProductModel product)
        {
            product.updateQuantity(this.Quantity);
            
        }

        
    }

}
