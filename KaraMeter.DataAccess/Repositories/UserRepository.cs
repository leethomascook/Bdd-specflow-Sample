using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KarmaMeter.Business.Contracts;
using NHibernate;

using KarmaMeter.Business.Domain;

namespace KarmaMeter.DataAccess.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
         public UserRepository(string ConnectionString)
            : base(ConnectionString)
        {
        }

         public UserRepository(ISession Session)
             : base(Session)
        {
        }

        public User GetUser(string username)
        {
            var user = Session.QueryOver<User>().Where(s => s.Username == username).SingleOrDefault();
            return user;
        }
    }
}
