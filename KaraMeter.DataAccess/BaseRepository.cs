using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace KarmaMeter.DataAccess
{
    public abstract class BaseRepository
    {
        protected ISession Session { get; set; }

        protected BaseRepository()
        {
            throw new InvalidOperationException("Please pass in either an ISession or a Connection String");
        }
        protected BaseRepository(ISession Session)
        {
            this.Session = Session;
        }
        protected BaseRepository(string ConnectionString)
        {
            Session = new SessionFactory().CreateSessionFactory(ConnectionString).OpenSession();
        }
    }
}
