using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KarmaMetee.Business.Contracts;
using NHibernate;
using NHibernate.Linq;
using KarmaMetee.Business.Domain;

namespace KarmaMeter.DataAccess.Repositories
{
    public class RatingRepository : BaseRepository, IRatingRepository
    {
         public RatingRepository(string ConnectionString)
            : base(ConnectionString)
        {
        }

         public RatingRepository(ISession Session)
             : base(Session)
        {
        }

        public IQueryable<Rating> SelectAllAccounts()
        {
            return null;
            //return Session.Linq<Rating>().Where(s => s.;
        }

        public bool HasStoryBeenRatedByUserAlready(string username)
        {
            throw new NotImplementedException();
        }
    }
}
