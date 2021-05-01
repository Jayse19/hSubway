using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public abstract class Bread
    {
        public string Name = "We don't have that bread";

        public virtual string GetDescription()
        {
            return this.Name;
        }

        public abstract double GetPrice();

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }




    }
    public class White : Bread
    {
        public Bread bread;
        public White(Bread bt)
        {
            bread = bt;
            this.Name = bread.GetDescription() + " on white bread";
        }

        public override double GetPrice()
        {
            return 2.00 + bread.GetPrice();
        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }
    }
    public class Rye : Bread
    {
        public Bread bread;
        public Rye(Bread bt)
        {
            bread = bt;
            this.Name = bread.GetDescription() + " on rye bread";
        }

        public override double GetPrice()
        {
            return 2.00 + bread.GetPrice();
        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }
    }
    public class Wheat : Bread
    {
        public Bread bread;
        public Wheat(Bread bt)
        {
            bread = bt;
            this.Name = bread.GetDescription() + " on wheat bread";
        }

        public override double GetPrice()
        {
            return 2.00 + bread.GetPrice();
        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }
    }
    



}
