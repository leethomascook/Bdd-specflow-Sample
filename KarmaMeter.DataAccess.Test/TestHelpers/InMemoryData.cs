using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KarmaMeter.Business.Domain;

namespace KarmaMeter.DataAccess.Test.TestHelpers
{
    public abstract class InMemoryData : InMemoryDatabase
    {
        protected InMemoryData()
        {
            User user1 = new User() { Username = "leecook" };
            User user2 = new User(){ Username = "hazelgray"};

            Session.Save(user1);
            Session.Save(user2);

            Session.Flush();

           Rating rating1 = new Rating(){ UserId = user1.Id, TimeRated = DateTime.Now, SubmittedRating = 1 };
            Session.Save(rating1);
            Session.Flush();
        }
    }
      
}
