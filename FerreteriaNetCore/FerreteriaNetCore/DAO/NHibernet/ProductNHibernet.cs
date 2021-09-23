using System;
using System.Collections.Generic;
using FerreteriaNetCore.Models.Entities;

namespace FerreteriaNetCore.DAO.NHibernet
{
    public class ProductNHibernet : IProductDAO
    {
        public List<ProductsModel> FindAllProducts()
        {
            throw new NotImplementedException();
        }

        public List<ProductsModel> FindProducts(int quantity)
        {
            throw new NotImplementedException();
        }

        public List<ProductsModel> FindProducts(String brand)
        {
            throw new NotImplementedException();
        }

        public ProductsModel FindProduct(long id)
        {
            throw new NotImplementedException();
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
