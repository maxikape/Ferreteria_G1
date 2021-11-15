using proyectoFerreteria.Models.DTOs;

namespace FerreteriaNetCore.Models.Entities
{
    public class NullProductBO : IProductBO
    {
        public string Name { get; set; }

        public string Brand { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }
        public bool applies() 
        {
            return false;
        }

        public IProductBO buildNewProduct(ProductEditDTO productDto)
        {
            return new NullProductBO();
        }

        public void updateQuantity(ProductModel product){}
    }

}
