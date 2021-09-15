﻿using System;
using FerreteriaNetCore.Models.Entities;

namespace FerreteriaNetCore.DAO.MockUp
{
    public class UserMockUp : IUserDAO
    {
        public Boolean Delete(UserModel user)
        {
            return true;
        }

        public UserModel FindUser(string userName, string password)
        {
            return new UserModel { Username = "Facundo", Password = "1234" };
        }

        public UserModel FindUser(long id)
        {
            throw new NotImplementedException();
        }

        public Boolean Save(UserModel user)
        {
            return true;
        }
    }
}