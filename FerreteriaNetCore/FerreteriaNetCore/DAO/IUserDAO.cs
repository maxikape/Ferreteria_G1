using System;
using FerreteriaNetCore.Models.Entities;

namespace FerreteriaNetCore.DAO
{
    public interface IUserDAO
    {
        UserModel FindUser(String userName, String password);

        UserModel FindUser(long id);

        Boolean Save(UserModel user);

        Boolean Delete(UserModel user);
    }
}
