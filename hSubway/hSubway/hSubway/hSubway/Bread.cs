using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public abstract class Bread
    {

        public string Name = "";

        public virtual string GetDescription()
        {
            return this.Name;
        }

        public abstract double GetPrice();

        public string Print()
        {
            string test;
            test = this.GetDescription() + ": $" + Math.Round(this.GetPrice(), 2, MidpointRounding.ToEven);
            Console.WriteLine(this.GetDescription() + ": $" + Math.Round(this.GetPrice(), 2, MidpointRounding.ToEven));
            return test;
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
            return 2.50 + bread.GetPrice();
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
            return 2.25 + bread.GetPrice();
        }

    }
    



}
