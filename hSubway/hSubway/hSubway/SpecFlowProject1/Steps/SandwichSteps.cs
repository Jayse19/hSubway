using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class SandwichSteps
    {
        // Test 1
        [Given(@"There is only (.*) slices of white left")]
        public void GivenThereIsOnlySlicesOfWhiteLeft(int white)
        {
            //Read how many slices of white are left and if greater than 1 return (true?, the amount of white left?). 
            ScenarioContext.Current.Pending();
        }

        [Given(@"a PBJ on white is ordered")]
        public void GivenAPBJOnWhiteIsOrdered()
        {
            // Check to make sure the sandwich order is PBJ and white. And if so return (true?).
            ScenarioContext.Current.Pending();
        }

        [Then(@"Sell (.*) PBJ on white sandwich")]
        public int ThenSellPBJOnWhiteSandwich(int amountSold)
        {
            // Return that, 1 PBJ on white was ordered.
            amountSold = 1;
            return amountSold;
        }


        // Test 2
        [Given(@"There is only (.*) slice of white left")]
        public void GivenThereIsOnlySliceOfWhiteLeft(int white)
        {
            // Check to see how many slices of white there are left. Return the amount
            ScenarioContext.Current.Pending();
        }

        [Then(@"Cannot sell PBJ on white sandwich")]
        public void ThenCannotSellPBJOnWhiteSandwich()
        {
            // Check to see if amount of white bread >= 2 if not, return cant sell sandwich for lack of bread.
            ScenarioContext.Current.Pending();
        }

        // Test 3
        [Given(@"white costs (.*)")]
        public void GivenWhiteCosts(double costOfWhite)
        {

            // Read and return the cost of white bread.
            ScenarioContext.Current.Pending();
        }

        [Given(@"PBJ costs (.*)")]
        public void GivenPBJCosts(double costOfPBJ)
        {

            // Read and return the cost of a PBJ sandwich.
            ScenarioContext.Current.Pending();
        }

        [Given(@"when a PBJ on white is ordered")]
        public void GivenWhenAPBJOnWhiteIsOrdered()
        {
            // Check the bread to make sure of stock, and return true if valid.
            ScenarioContext.Current.Pending();
        }

        [Then(@"the cost should be (.*)")]
        public void ThenTheCostShouldBe(double totalCost)
        {
            // Read cost of white bread and of PBJ and return totalCost.
            ScenarioContext.Current.Pending();
        }


        // Test 4
        [Given(@"when a PBJ on wheat is ordered")]
        public void GivenWhenAPBJOnWheatIsOrdered()
        {
            // Check wheat bread to make sure it is in stock and return ture if valid.
            ScenarioContext.Current.Pending();
        }

        // Cost of Rye
        [Given(@"rye costs (.*)")]
        public void GivenRyeCosts(double costOfRye)
        {
            // Read and return the cost of Rye bread.
            ScenarioContext.Current.Pending();
        }

        // PBJ on Rye
        [Given(@"when a PBJ on rye is ordered")]
        public void GivenWhenAPBJOnRyeIsOrdered()
        {
            // Verify the stock of Rye bread and return true if valid.
            ScenarioContext.Current.Pending();
        }

        // Cost of Shredded Chicken
        [Given(@"shredded chicken costs (.*)")]
        public void GivenShreddedChickenCosts(double costOfShreddedChicken)
        {
            // Read and return the cost of shredded chicken
            ScenarioContext.Current.Pending();
        }

        // Shredded Chicken on White
        [Given(@"when a shredded chicken on white is ordered")]
        public void GivenWhenAShreddedChickenOnWhiteIsOrdered()
        {
            // Verify the stock of white bread and return true if valid.
            ScenarioContext.Current.Pending();
        }

        // Cost of Wheat Bread
        [Given(@"wheat costs (.*)")]
        public void GivenWheatCosts(double costOfWhite)
        {
            // Read and return the cost of wheat bread.
            ScenarioContext.Current.Pending();
        }

        // Chicken on Wheat
        [Given(@"when a shredded chicken on wheat is ordered")]
        public void GivenWhenAShreddedChickenOnWheatIsOrdered()
        {
            // Verify the stock of wheat bread and return true if valid.
            ScenarioContext.Current.Pending();
        }

        // Chicken on Rye
        [Given(@"when a shredded chicken on rye is ordered")]
        public void GivenWhenAShreddedChickenOnRyeIsOrdered()
        {
            // Verify the stock of Rye bread, return true if valid.
            ScenarioContext.Current.Pending();
        }

        // Cost of Cheese
        [Given(@"cheese costs (.*)")]
        public void GivenCheeseCosts(double costOfCheese)
        {
            // Read and return the cost of cheese.
            ScenarioContext.Current.Pending();
        }

        // Cost of Lettuce
        [Given(@"lettuce costs (.*)")]
        public void GivenLettuceCosts(double costOfLettuce)
        {
            // Read and return the cost of lettuce.
            ScenarioContext.Current.Pending();
        }

        // Cost of Tomato
        [Given(@"tomato costs (.*)")]
        public void GivenTomatoCosts(double costOfTomato)
        {
            // Read and return the cost of tomato.
            ScenarioContext.Current.Pending();
        }

        // Cost of Bacon
        [Given(@"bacon costs (.*)")]
        public void GivenBaconCosts(double costOfBacon)
        {
            // Read and return the cost of bacon.
            ScenarioContext.Current.Pending();
        }

    }
}
