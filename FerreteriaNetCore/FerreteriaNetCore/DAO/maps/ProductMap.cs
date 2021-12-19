using FerreteriaNetCore.Models.Entities;
using FluentNHibernate.Mapping;

namespace FerreteriaNetCore.DAO
{
    public class ProductMap : ClassMap<ProductModel>
    {
        public ProductMap()
        {
            Table("ProductModel");

            Id(x => x.Id);
            
            Map(x => x.Name);
            Map(x => x.Brand);
            Map(x => x.Category);
            Map(x => x.Description);
            Map(x => x.Quantity);
        }
    }
}