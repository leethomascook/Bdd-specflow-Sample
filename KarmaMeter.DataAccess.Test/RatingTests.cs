using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Moq;
using KarmaMeter.Business.Contracts;
using KarmaMeter.DataAccess.Repositories;
using KarmaMeter.DataAccess.Test.TestHelpers;
using KarmaMeter.Business.Domain;

namespace KarmaMeter.DataAccess.Test
{
    [TestFixture]
    public class RatingTests : TestBase
    {
        [Test]
        public void Has_Action_Been_Rated_Before_By_Me()
        {
            IUserRepository userRepository = new UserRepository(Session);
            User user = userRepository.GetUser("leecook");

            string username = "leecook";
            IRatingRepository ratingRepository = new RatingRepository(Session);
            bool result = ratingRepository.HasStoryBeenRatedByUserAlready(user.Id);
            Assert.IsTrue(result);
        }
    }
}
