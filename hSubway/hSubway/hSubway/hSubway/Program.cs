using System;

namespace hSubway
{
    class Program
    {
        static void Main(string[] args)
        {
            PantryInventory c = new PantryInventory();
            
            char[] mySplits = { ' ', ':' };
            string test;
            Bread b = new ChickenSand();
            b = new Rye(b);
            b = new Bacon(b);
            b = new Bacon(b);
            b = new Tomato(b);
            b = new Cheese(b);
            b = new Lettuce(b);
            b = new Ham(b);
            b = new BBQSauce(b);
            b = new Mustard(b);
            b = new Mayo(b);

            test = b.Print();
            
            string[] testSplit = test.Split(mySplits);
            c.CurrentStock(testSplit);


            Bread p = new PbjSand();
            p = new White(p);
            p = new Tomato(p);
            p = new BBQSauce(p);
            p = new Mustard(p);
            p = new Mayo(p);
            p = new Cheese(p);

            test = p.Print();
            testSplit = test.Split(mySplits);
            c.CurrentStock(testSplit);

            Bread d = new BLTSand();
            d = new Rye(d);
            d = new Bacon(d);
            d = new Bacon(d);
            d = new Tomato(d);
            d = new Cheese(d);
            d = new Lettuce(d);
            d = new Ham(d);
            d = new BBQSauce(d);
            d = new Mustard(d);
            d = new Mayo(d);
            d = new Bacon(d);
            d = new Bacon(d);
            d = new Bacon(d);
            d = new Bacon(d);
            d = new Bacon(d);
            d = new Bacon(d);
            d = new Bacon(d);
            d = new Bacon(d);
            d = new Bacon(d);
            d = new Bacon(d);
            d = new Bacon(d);
            d = new Bacon(d);
            d = new Bacon(d);



            test = d.Print();
            testSplit = test.Split(mySplits);
            c.CurrentStock(testSplit);

            Console.WriteLine("The total cost of all your sandwiches plus tax is: $" + (c.SellSandwich(b) + c.SellSandwich(p) + c.SellSandwich(d)));


            c.InventoryRestock();
        }

    }
}
