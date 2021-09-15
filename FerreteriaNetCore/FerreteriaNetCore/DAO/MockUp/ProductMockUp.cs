using System;
using FerreteriaNetCore.Models.Entities;

namespace FerreteriaNetCore.DAO.MockUp
{
    public class ProductMockUp : IProductDAO
    {
        public ProductsModel FindProduct(int quantity)
        {
            return new ProductsModel { SomeValue = "Producto X con " + quantity.ToString() + " unidades disponibles." };
        }

        public ProductsModel FindProduct(String brand)
        {
            return new ProductsModel { SomeValue = "Producto X de marca " + brand };
        }

        public ProductsModel FindProduct(long id)
        {
            return new ProductsModel { SomeValue = "Producto X con id " + id.ToString() };
        }

        public Boolean Save(ProductsModel product)
        {
            return true;
        }

        public Boolean Delete(ProductsModel product)
        {
            return true;
        }

    }
}
