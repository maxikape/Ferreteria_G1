using proyectoFerreteria.Models.DTOs;

namespace FerreteriaNetCore.Models.Entities
{
    public interface IProductBO
    {
        public string Name { get; set; }

        public string Brand { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public bool applies();

        public IProductBO buildNewProduct(ProductEditDTO productDto);
    
        public void updateQuantity(ProductModel product);
    }
}