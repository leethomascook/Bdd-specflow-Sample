using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace KarmaMeter.DataAccess.Test.TestHelpers
{
    [TestFixture]
    public abstract class TestBase : InMemoryData
    {
       // protected IPersonData PersonData { get; set; }
       // protected IAccountData AccountData { get; set; }

        [SetUp]
        public void Init()
        {
           // PersonData = new PersonData(Session);
           // AccountData = new AccountData(Session);
        }

        [TestFixtureTearDown]
        public void Die()
        {
            Dispose();
        }

    }
      
}
