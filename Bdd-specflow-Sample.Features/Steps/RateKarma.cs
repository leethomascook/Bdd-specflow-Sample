using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Bdd_specflow_Sample.Features.Steps
{
    [Binding]
    public class RateKarma
    {

        [Given(@"They have not been rated by me before")]
        public void GivenTheyHaveNotBeenRatedByMeBefore()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I submit a rating")]
        public void WhenISubmitARating()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be stored in the database")]
        public void ThenTheResultShouldBeStoredInTheDatabase()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
