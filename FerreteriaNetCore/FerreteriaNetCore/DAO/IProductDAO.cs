using System;
using FerreteriaNetCore.Models.Entities;

namespace FerreteriaNetCore.DAO
{
    public interface IProductDAO
    {
        ProductsModel FindProduct(int quantity);

        ProductsModel FindProduct(String brand);

        ProductsModel FindProduct(long id);

        Boolean Save(ProductsModel product);

        Boolean Delete(ProductsModel product);
    }
}
