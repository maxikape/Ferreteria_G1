using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;

using FerreteriaNetCore.Models.Entities;

namespace FerreteriaNetCore.DAO
{
    public class UserDAO
    {
        private ISession session;

        public UserDAO(ISession session)
        {
            this.session = session;
        }

        public UserModel GetUser(string userName, string password)
        {
            ICriteria criterio = this.session.CreateCriteria<UserModel>();

            criterio.Add(Restrictions.Eq("Username", userName));
            criterio.Add(Restrictions.Eq("Password", password));

            IList<UserModel> users = criterio.List<UserModel>();

            if(users != null && users.Count > 0) return users[0];

            return null;
        }

        public UserModel GetUserByName(string userName)
        {
            ICriteria criterio = this.session.CreateCriteria<UserModel>();

            criterio.Add(Restrictions.Eq("Username", userName));

            IList<UserModel> users = criterio.List<UserModel>();

            if(users != null && users.Count > 0) return users[0];

            return null;
        }

        public UserModel GetUserByEmail(string email)
        {
            ICriteria criterio = this.session.CreateCriteria<UserModel>();

            criterio.Add(Restrictions.Eq("Email", email));

            IList<UserModel> users = criterio.List<UserModel>();

            if(users != null && users.Count > 0) return users[0];

            return null;
        }

        public void SaveUser(UserModel user){
            this.session.Save(user);
        }
    }
}