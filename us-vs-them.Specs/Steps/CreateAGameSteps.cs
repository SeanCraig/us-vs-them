using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace us_vs_them.Specs.Steps
{
    [Binding]
    public class CreateAGameSteps
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        [Given(@"I have entered (.*)/(.*) into the date field")]
        public void GivenIHaveEnteredIntoTheDateField(string p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have entered (.*)pm into the time field")]
        public void GivenIHaveEnteredPmIntoTheTimeField(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press Create")]
        public void WhenIPressCreate()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"a game of basketball should be created on (.*)/(.*) at (.*)pm")]
        public void ThenAGameOfBasketballShouldBeCreatedOnAtPm(string p0, int p1, int p2)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
