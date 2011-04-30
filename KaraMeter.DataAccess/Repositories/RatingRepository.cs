using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KarmaMeter.Business.Contracts;
using NHibernate;

using KarmaMeter.Business.Domain;

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

        public bool HasStoryBeenRatedByUserAlready(Guid userid)
        {
            int count = Session.QueryOver<Rating>().Where(s => s.UserId == userid).RowCount();

            return  count >= 1;
        }
    }
}
