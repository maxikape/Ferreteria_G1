using System;
using FerreteriaNetCore.Models.Entities;

namespace FerreteriaNetCore.DAO.NHibernet
{
    public class UserNHibernet : IUserDAO
    {
        public bool Delete(UserModel user)
        {
            return true;
        }

        public UserModel FindUser(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public UserModel FindUser(long id)
        {
            throw new NotImplementedException();
        }

        public bool Save(UserModel user)
        {
            return true;
        }
    }
}
