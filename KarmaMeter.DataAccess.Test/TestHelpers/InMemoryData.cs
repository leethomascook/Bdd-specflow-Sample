using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KarmaMeter.DataAccess.Test.TestHelpers
{
    public abstract class InMemoryData : InMemoryDatabase
    {
        protected InMemoryData()
        {
           // Account AccountOne = new Account(1, "AC001");
           // Account AccountTwo = new Account(2, "AC002");

          //  Session.Save(AccountOne);
          //  Session.Save(AccountTwo);

            Session.Flush();

          ///  Session.Save(new Person(1, "Dan", "Watson", AccountOne));
          //  Session.Save(new Person(1, "James", "May", AccountTwo));
          ///  Session.Save(new Person(1, "Andrew", "Plum", AccountOne));

            Session.Flush();
        }
    }
      
}
