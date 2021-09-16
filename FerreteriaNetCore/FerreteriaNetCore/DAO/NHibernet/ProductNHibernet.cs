using System;
using FerreteriaNetCore.Models.Entities;

namespace FerreteriaNetCore.DAO.NHibernet
{
    public class ProductNHibernet : IProductDAO
    {
        public ProductsModel FindProduct(int quantity)
        {
            throw new NotImplementedException();
        }

        public ProductsModel FindProduct(String brand)
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
