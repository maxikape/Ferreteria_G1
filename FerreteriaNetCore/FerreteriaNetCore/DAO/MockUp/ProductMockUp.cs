using System;
using System.Collections.Generic;
using FerreteriaNetCore.Models.Entities;

namespace FerreteriaNetCore.DAO.MockUp
{
    public class ProductMockUp : IProductDAO
    {
        public List<ProductsModel> FindProducts(int quantity)
        {

            ProductsModel product1 = new ProductsModel

            {
                Name = "Taladro",
                Brand = "Bosch",
                Category = "Electric tool",
                Description = "An electric driller",
                Quantity = quantity

            };
            ProductsModel product2 = new ProductsModel

            {
                Name = "Lijadora",
                Brand = "Bosch",
                Category = "Electric tool",
                Description = "An electric sander",
                Quantity = quantity

            };
            ProductsModel product3 = new ProductsModel

            {
                Name = "Amoladora",
                Brand = "Bosch",
                Category = "Electric tool",
                Description = "An electric grinder",
                Quantity = quantity

            };
            List<ProductsModel> lista = new List<ProductsModel>();
            lista.Add(product1);
            lista.Add(product2);
            lista.Add(product3);

            return lista;
        }

        public List<ProductsModel> FindProducts(String brand)
        {
            ProductsModel product1 = new ProductsModel

            {
                Name = "Taladro",
                Brand = brand,
                Category = "Electric tool",
                Description = "An electric driller",
                Quantity = 10

            };
            ProductsModel product2 = new ProductsModel

            {
                Name = "Lijadora",
                Brand = brand,
                Category = "Electric tool",
                Description = "An electric sander",
                Quantity = 10

            };
            ProductsModel product3 = new ProductsModel

            {
                Name = "Amoladora",
                Brand = brand,
                Category = "Electric tool",
                Description = "An electric grinder",
                Quantity = 10

            };
            List<ProductsModel> lista = new List<ProductsModel>();
            lista.Add(product1);
            lista.Add(product2);
            lista.Add(product3);

            return lista;
        }

        public ProductsModel FindProduct(long id)
        {
            ProductsModel product1 = new ProductsModel

            {
                Name = "Taladro",
                Brand = "Bosch",
                Category = "Electric tool",
                Description = "An electric driller",
                Quantity = 10

            };
            ProductsModel product2 = new ProductsModel

            {
                Name = "Lijadora",
                Brand = "Bosch",
                Category = "Electric tool",
                Description = "An electric sander",
                Quantity = 10

            };
            ProductsModel product3 = new ProductsModel

            {
                Name = "Amoladora",
                Brand = "Bosch",
                Category = "Electric tool",
                Description = "An electric grinder",
                Quantity = 10

            };
            Dictionary<long, ProductsModel> products_dict = new Dictionary<long, ProductsModel>();

            products_dict.Add(1, product1);

            products_dict.Add(2, product2);

            products_dict.Add(3, product3);

            if (products_dict.ContainsKey(id))
            {

                return products_dict[id];

            }

            else
            {
                return null;
            }
        }

        public Boolean Save(ProductsModel product)
        {
            return true;
        }

        public Boolean Delete(ProductsModel product)
        {
            return true;
        }

        public List<ProductsModel> FindAllProducts()
        {

            ProductsModel product1 = new ProductsModel

            {
                Name = "Taladro",
                Brand = "Bosch",
                Category = "Electric tool",
                Description = "An electric driller",
                Quantity = 10

            };
            ProductsModel product2 = new ProductsModel

            {
                Name = "Lijadora",
                Brand = "Bosch",
                Category = "Electric tool",
                Description = "An electric sander",
                Quantity = 10

            };
            ProductsModel product3 = new ProductsModel

            {
                Name = "Amoladora",
                Brand = "Bosch",
                Category = "Electric tool",
                Description = "An electric grinder",
                Quantity = 10

            };
            List<ProductsModel> lista = new List<ProductsModel>();
            lista.Add(product1);
            lista.Add(product2);
            lista.Add(product3);

            return lista;
        }

    }

}
