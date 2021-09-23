using System;
using System.Collections.Generic;
using FerreteriaNetCore.Models.Entities;

namespace FerreteriaNetCore.DAO
{
    public interface IProductDAO
    {
        List<ProductsModel> FindAllProducts();
        
        List<ProductsModel> FindProducts(int quantity);

        List<ProductsModel> FindProducts(String brand);

        ProductsModel FindProduct(long id);

        Boolean Save(ProductsModel product);

        Boolean Delete(ProductsModel product);
    }
}
