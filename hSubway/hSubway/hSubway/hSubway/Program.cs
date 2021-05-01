using System;

namespace hSubway
{
    class Program
    {
        static void Main(string[] args)
        {
            Bread b = new ChickenSand();
            b = new White(b);
            b = new Bacon(b);
            b = new Bacon(b);
            b = new Tomato(b);
            b = new Cheese(b);
            b = new Lettuce(b);
            b = new Ham(b);
            b = new BBQSauce(b);
            b = new Mustard(b);
            b = new Mayo(b);

            b.Print();

            Bread p = new PbjSand();
            p = new White(p);
            p = new Tomato(p);
            p = new BBQSauce(p);
            p = new Mustard(p);
            p = new Mayo(p);
            p = new Cheese(p);

            p.Print();

            PantryInventory c = new PantryInventory();
            Console.WriteLine(c.SellSandwich(b) + c.SellSandwich(p));
        }

    }
}
