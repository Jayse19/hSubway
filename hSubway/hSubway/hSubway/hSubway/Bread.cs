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




    }

    public class PbjSand : Bread
    {
        public PbjSand()
        {
            this.Name = "Peanut Butter and Jelly Sandwich";
        }

        public override double GetPrice()
        {
            return 0.75;

        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }

    }
    public class ChickenSand : Bread
    {
        public ChickenSand()
        {
            this.Name = "Shredded Chicken Sandwich";
        }

        public override double GetPrice()
        {
            return 2.00;

        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }

    }
    public class BltSand : Bread
    {
        public BltSand()
        {
            this.Name = "Bacon Lettuce and Tomato Sandwich";
        }

        public override double GetPrice()
        {
            return 2.50;

        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }

    }


    public class White: Bread
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

    public class Mustard : Bread
    {
        public Bread bread;
        public Mustard(Bread topping)
        {
            bread = topping;
            this.Name = bread.GetDescription() + " with Mustard";
        }

        public override double GetPrice()
        {
            return bread.GetPrice();
        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }

       
    }
    public class Mayo : Bread
    {
        public Bread bread;
        public Mayo(Bread topping)
        {
            bread = topping;
            this.Name = bread.GetDescription() + " with Mayo";
        }

        public override double GetPrice()
        {
            return bread.GetPrice();
        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }


    }
    public class Bbq : Bread
    {
        public Bread bread;
        public Bbq(Bread topping)
        {
            bread = topping;
            this.Name = bread.GetDescription() + " with BBQ sauce";
        }

        public override double GetPrice()
        {
            return bread.GetPrice();
        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }


    }
    public class Bacon : Bread
    {
        public Bread bread;
        public Bacon(Bread topping)
        {
            bread = topping;
            this.Name = bread.GetDescription() + " with Bacon";
        }

        public override double GetPrice()
        {
            return 0.75 + bread.GetPrice();
        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }


    }

}
