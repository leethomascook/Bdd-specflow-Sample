using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
      
namespace KarmaMeter.DataAccess.Test.TestHelpers
{
    public abstract class InMemoryDatabase : IDisposable
    {
        private static Configuration _configuration;
        private static ISessionFactory _sessionFactory;
      
        protected ISession Session { get; set; }
      
        protected InMemoryDatabase()
        {
        _sessionFactory = CreateSessionFactory();
        Session = _sessionFactory.OpenSession();
        BuildSchema(Session);
        }
        private static ISessionFactory CreateSessionFactory()
        {
        return Fluently.Configure()
            .Database(SQLiteConfiguration.Standard.InMemory().ShowSql())
            .Mappings(M => M.FluentMappings.AddFromAssemblyOf<KarmaMeter.DataAccess.Maps.UserMap>())
            .ExposeConfiguration(Cfg => _configuration = Cfg)
            .BuildSessionFactory();
        }
        private static void BuildSchema(ISession Session)
        {
        SchemaExport export = new SchemaExport(_configuration);
        export.Execute(true, true, false, Session.Connection, null);
      
        }
      
        public void Dispose()
        {
        Session.Dispose();
        }
    }
}

