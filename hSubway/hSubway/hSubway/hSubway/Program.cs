using System;

namespace hSubway
{
    class Program
    {
        static void Main(string[] args)
        {
            Bread b = new ChickenSand(White);
            b = new Bacon(b);
            b.GetDescription();
            b.GetPrice();
        }

    }
}
