using System;
using TechTalk.SpecFlow;
using FluentAssertions;
using hSubway;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class SandwichSteps
    {
        // Test 1
        [Given(@"There is only (.*) slices of white left")]
        public int GivenThereIsOnlySlicesOfWhiteLeft(int threeSliceOfWhite)
        {
            PantryInventory checkWhite = new PantryInventory
            {
                whiteBread = 3
            };
            if (checkWhite.whiteBread <= 1)
            {
                Console.WriteLine("Sandwich can not be made.");
                return 0;
            }
            else
            {
                return threeSliceOfWhite;
            }
        }

        [Given(@"a PBJ on white is ordered")]
        public void GivenAPBJOnWhiteIsOrdered()
        {
            Bread sandwich = new PbjSand();
            sandwich = new White(sandwich);
        }

        [Then(@"Sell (.*) PBJ on white sandwich")]
        public int ThenSellPBJOnWhiteSandwich(int amountSold)
        {
            Bread sandwich = new PbjSand();
            sandwich = new White(sandwich);
            amountSold = 1;
            return amountSold;
        }


        // Test 2
        [Given(@"There is only (.*) slice of white left")]
        public int GivenThereIsOnlySliceOfWhiteLeft(int sliceOfWhite)
        {
            PantryInventory checkWhite = new PantryInventory();
            checkWhite.whiteBread = 1;
            if (checkWhite.whiteBread <= 1)
            {
                Console.WriteLine("You have only 1 slice of white bread left.");
                return sliceOfWhite;
            }
            else
            {
                Console.WriteLine("You have more than 1 slice of white bread left.");
                return sliceOfWhite;
            }
        }

        [Then(@"Cannot sell PBJ on white sandwich")]
        public void ThenCannotSellPBJOnWhiteSandwich()
        {

            PantryInventory checkWhite = new PantryInventory();
            checkWhite.whiteBread = 1;
            if (checkWhite.whiteBread <= 1)
            {
                Console.WriteLine("You can not make the sandwich.");
                return;
            }
            else
            {
                Console.WriteLine("You can make the sandwich");
                return;
            }
        }

        // Test 3
        [Given(@"white costs (.*)")]
        public double GivenWhiteCosts(double costOfWhite)
        {
            Bread whiteBread = new PbjSand();
            whiteBread = new White(whiteBread);
            costOfWhite = whiteBread.GetPrice() -0.75;
            return costOfWhite;
        }

        [Given(@"PBJ costs (.*)")]
        public double GivenPBJCosts(double costOfPBJ)
        {
            Bread PBJ = new PbjSand();
            costOfPBJ = PBJ.GetPrice();
            return costOfPBJ;
        }

        [Given(@"when a PBJ on white is ordered")]
        public void GivenWhenAPBJOnWhiteIsOrdered()
        {
            Bread sandwich = new PbjSand();
            sandwich = new White(sandwich);
        }

        [Then(@"the cost should be (.*)")]
        public double ThenTheCostShouldBe(double totalCost)
        {
            Bread PBJonWhite = new PbjSand();
            PBJonWhite = new White(PBJonWhite);
            totalCost = PBJonWhite.GetPrice();
            return totalCost;
        }


        // Test 4
        [Given(@"when a PBJ on wheat is ordered")]
        public void GivenWhenAPBJOnWheatIsOrdered()
        {
            Bread sandwich = new PbjSand();
            sandwich = new Wheat(sandwich);
        }

        // Cost of Rye
        [Given(@"rye costs (.*)")]
        public double GivenRyeCosts(double costOfRye)
        {
            Bread ryeBread = new PbjSand();
            ryeBread = new White(ryeBread);
            costOfRye = ryeBread.GetPrice() - 0.75;
            return costOfRye;
        }

        // PBJ on Rye
        [Given(@"when a PBJ on rye is ordered")]
        public void GivenWhenAPBJOnRyeIsOrdered()
        {
            Bread sandwich = new PbjSand();
            sandwich = new Rye(sandwich);
        }

        // Cost of Shredded Chicken
        [Given(@"shredded chicken costs (.*)")]
        public double GivenShreddedChickenCosts(double costOfShreddedChicken)
        {
            Bread shredded = new ChickenSand();
            costOfShreddedChicken = shredded.GetPrice();
            return costOfShreddedChicken;
        }

        // Shredded Chicken on White
        [Given(@"when a shredded chicken on white is ordered")]
        public void GivenWhenAShreddedChickenOnWhiteIsOrdered()
        {
            Bread sandwich = new ChickenSand();
            sandwich = new White(sandwich);
        }

        // Cost of Wheat Bread
        [Given(@"wheat costs (.*)")]
        public double GivenWheatCosts(double costOfWheat)
        {
            Bread wheatBread = new PbjSand();
            wheatBread = new Wheat(wheatBread);
            costOfWheat = wheatBread.GetPrice() - 0.75;
            return costOfWheat;
        }

        // Chicken on Wheat
        [Given(@"when a shredded chicken on wheat is ordered")]
        public void GivenWhenAShreddedChickenOnWheatIsOrdered()
        {
            Bread sandwich = new ChickenSand();
            sandwich = new Wheat(sandwich);
        }

        // Chicken on Rye
        [Given(@"when a shredded chicken on rye is ordered")]
        public void GivenWhenAShreddedChickenOnRyeIsOrdered()
        {
            Bread sandwich = new ChickenSand();
            sandwich = new Rye(sandwich);
        }

        // Cost of Cheese
        [Given(@"cheese costs (.*)")]
        public double GivenCheeseCosts(double costOfCheese)
        {
            Bread cheese = new PbjSand();
            cheese = new Cheese(cheese);
            costOfCheese = cheese.GetPrice() - 0.75;
            return costOfCheese;
        }

        // Cost of Lettuce
        [Given(@"lettuce costs (.*)")]
        public double GivenLettuceCosts(double costOfLettuce)
        {
            Bread lettuce = new PbjSand();
            lettuce = new Lettuce(lettuce);
            costOfLettuce = lettuce.GetPrice() - 0.75;
            return costOfLettuce;
        }

        // Cost of Tomato
        [Given(@"tomato costs (.*)")]
        public double GivenTomatoCosts(double costOfTomato)
        {
            Bread tomato = new PbjSand();
            tomato = new Tomato(tomato);
            costOfTomato = tomato.GetPrice() - 0.75;
            return costOfTomato;
        }

        // Cost of Bacon
        [Given(@"bacon costs (.*)")]
        public double GivenBaconCosts(double costOfBacon)
        {
            Bread bacon = new PbjSand();
            bacon = new Bacon(bacon);
            costOfBacon = bacon.GetPrice() - 0.75;
            return costOfBacon;
        }

        [Given(@"mayo costs (.*)")]
        public double GivenMayoCosts(double costOfMayo)
        {
            Bread mayo = new PbjSand();
            mayo = new Mayo(mayo);
            costOfMayo = mayo.GetPrice() - 0.75;
            return costOfMayo;
        }

        [Given(@"mustard costs (.*)")]
        public double GivenMustardCosts(double costOfMustard)
        {
            Bread mustard = new PbjSand();
            mustard = new Mustard(mustard);
            costOfMustard = mustard.GetPrice() - 0.75;
            return costOfMustard;
        }

    }
}
