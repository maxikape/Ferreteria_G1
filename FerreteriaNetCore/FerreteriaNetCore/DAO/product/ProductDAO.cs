using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;

using FerreteriaNetCore.Models.Entities;

namespace FerreteriaNetCore.DAO
{
    public class ProductDAO
    {
        private ISession session;

        public ProductDAO(ISession session)
        {
            this.session = session;
        }

        public ProductModel GetProduct(string name, string brand)
        {
            ICriteria criterio = this.session.CreateCriteria<ProductModel>();

            criterio.Add(Restrictions.Eq("Name", name));
            criterio.Add(Restrictions.Eq("Brand", brand));

            IList<ProductModel> products = criterio.List<ProductModel>();

            if(products != null && products.Count > 0) return products[0];

            return null;
        }

         public IList<ProductModel> GetProduct(string name)
        {
            ICriteria criterio = this.session.CreateCriteria<ProductModel>();

            criterio.Add(Restrictions.Eq("Name", name));

            IList<ProductModel> products = criterio.List<ProductModel>();

            if(products != null && products.Count > 0) return products;

            return null;
        }

        public void SaveProduct(ProductModel product){

            this.session.Save(product);
        }
        public void SaveProduct(IProductBO newProduct){

            ProductModel prod = new ProductModel();
            prod.Name = newProduct.Name;
            prod.Brand = newProduct.Brand;
            prod.Category = newProduct.Category;
            prod.Description = newProduct.Description;
            prod.Quantity = newProduct.Quantity;
            this.session.Save(prod);
        }
    }
}