using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Moq;
using KarmaMetee.Business.Contracts;
using KarmaMeter.DataAccess.Repositories;
using KarmaMeter.DataAccess.Test.TestHelpers;

namespace KarmaMeter.DataAccess.Test
{
    [TestFixture]
    public class RatingTests : TestBase
    {
        [Test]
        public void Has_Action_Been_Rated_Before_By_Me()
        {
            string username = "leecook";
            IRatingRepository ratingRepository = new RatingRepository(Session);
            bool result = ratingRepository.HasStoryBeenRatedByUserAlready(username);
            Assert.IsTrue(result);
        }
    }
}
