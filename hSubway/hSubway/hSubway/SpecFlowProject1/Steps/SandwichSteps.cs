using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class SandwichSteps
    {
        // Test 1
        [Given(@"There is only (.*) slices of white left")]
        public void GivenThereIsOnlySlicesOfWhiteLeft(int p0)
        {

            ScenarioContext.Current.Pending();
        }

        [Given(@"a PBJ on white is ordered")]
        public void GivenAPBJOnWhiteIsOrdered()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Sell (.*) PBJ on white sandwich")]
        public void ThenSellPBJOnWhiteSandwich(int p0)
        {
            ScenarioContext.Current.Pending();
        }


        // Test 2
        [Given(@"There is only (.*) slice of white left")]
        public void GivenThereIsOnlySliceOfWhiteLeft(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Cannot sell PBJ on white sandwich")]
        public void ThenCannotSellPBJOnWhiteSandwich()
        {
            ScenarioContext.Current.Pending();
        }

        // Test 3
        [Given(@"white costs (.*)")]
        public void GivenWhiteCosts(double p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"PBJ costs (.*)")]
        public void GivenPBJCosts(double p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"when a PBJ on white is ordered")]
        public void GivenWhenAPBJOnWhiteIsOrdered()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the cost should be (.*)")]
        public void ThenTheCostShouldBe(double p0)
        {
            ScenarioContext.Current.Pending();
        }


        // Test 4
        [Given(@"when a PBJ on wheat is ordered")]
        public void GivenWhenAPBJOnWheatIsOrdered()
        {
            ScenarioContext.Current.Pending();
        }

        // Cost of Rye
        [Given(@"rye costs (.*)")]
        public void GivenRyeCosts(double p0)
        {
            ScenarioContext.Current.Pending();
        }

        // PBJ on Rye
        [Given(@"when a PBJ on rye is ordered")]
        public void GivenWhenAPBJOnRyeIsOrdered()
        {
            ScenarioContext.Current.Pending();
        }

        // Cost of Shredded Chicken
        [Given(@"shredded chicken costs (.*)")]
        public void GivenShreddedChickenCosts(double p0)
        {
            ScenarioContext.Current.Pending();
        }

        // Shredded Chicken on White
        [Given(@"when a shredded chicken on white is ordered")]
        public void GivenWhenAShreddedChickenOnWhiteIsOrdered()
        {
            ScenarioContext.Current.Pending();
        }

        // Cost of Wheat Bread
        [Given(@"wheat costs (.*)")]
        public void GivenWheatCosts(double p0)
        {
            ScenarioContext.Current.Pending();
        }

        // Chicken on Wheat
        [Given(@"when a shredded chicken on wheat is ordered")]
        public void GivenWhenAShreddedChickenOnWheatIsOrdered()
        {
            ScenarioContext.Current.Pending();
        }

        // Chicken on Rye
        [Given(@"when a shredded chicken on rye is ordered")]
        public void GivenWhenAShreddedChickenOnRyeIsOrdered()
        {
            ScenarioContext.Current.Pending();
        }

        // Cost of Cheese
        [Given(@"cheese costs (.*)")]
        public void GivenCheeseCosts(double p0)
        {
            ScenarioContext.Current.Pending();
        }

        // Cost of Lettuce
        [Given(@"lettuce costs (.*)")]
        public void GivenLettuceCosts(double p0)
        {
            ScenarioContext.Current.Pending();
        }

        // Cost of Tomato
        [Given(@"tomato costs (.*)")]
        public void GivenTomatoCosts(double p0)
        {
            ScenarioContext.Current.Pending();
        }

        // Cost of Bacon
        [Given(@"bacon costs (.*)")]
        public void GivenBaconCosts(double p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
