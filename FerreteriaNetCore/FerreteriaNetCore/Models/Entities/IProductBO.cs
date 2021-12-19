using FerreteriaNetCore.Models.DTOs;

namespace FerreteriaNetCore.Models.Entities
{
    public interface IProductBO
    {
        string Name { get; set; }

        string Brand { get; set; }

        string Category { get; set; }

        string Description { get; set; }

        int Quantity { get; set; }

        bool applies();

        IProductBO buildNewProduct(ProductEditDTO productDto);
    
        void updateQuantity(ProductModel product);
    }
}