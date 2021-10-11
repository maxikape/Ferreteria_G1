using FluentNHibernate.Mapping;
using FerreteriaNetCore.Models.Entities;

namespace FerreteriaNetCore.DAO
{
    public class UserMap : ClassMap<UserModel>
    {
        public UserMap()
        {
            Table("UserModel");

            Id(x => x.Id);

            Map(x => x.Username);
            Map(x => x.Password);
            Map(x => x.Email);
            Map(x => x.Birthdate);
        }
    }
}