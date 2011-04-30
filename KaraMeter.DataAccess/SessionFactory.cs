using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace KarmaMeter.DataAccess
{
    public class SessionFactory
    {
        public ISessionFactory CreateSessionFactory(string ConnectionString)
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2005
                              .ConnectionString(
                              C => C.Is(ConnectionString)))
                .Mappings(M => M.FluentMappings.AddFromAssemblyOf<SessionFactory>())
                .BuildSessionFactory();
        }
    }
}
