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

    public class Pbj : Bread
    {
        public Pbj()
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
    public class ChickenSandwich : Bread
    {
        public ChickenSandwich()
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
    

    public class Must : Bread
    {
        public Bread bread;
        public Must(Bread topping)
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
    public class Mayonnaise : Bread
    {
        public Bread bread;
        public Mayonnaise(Bread topping)
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
    public class BaconT : Bread
    {
        public Bread bread;
        public BaconT(Bread topping)
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

    public class LettuceT : Bread
    {
        public Bread bread;
        public LettuceT(Bread topping)
        {
            bread = topping;
            this.Name = bread.GetDescription() + " with Lettuce";
        }

        public override double GetPrice()
        {
            return 0.25 + bread.GetPrice();
        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }


    }

    public class HamT : Bread
    {
        public Bread bread;
        public HamT(Bread topping)
        {
            bread = topping;
            this.Name = bread.GetDescription() + " with Ham";
        }

        public override double GetPrice()
        {
            return 0.60 + bread.GetPrice();
        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }


    }

    public class CheeseT : Bread
    {
        public Bread bread;
        public CheeseT(Bread topping)
        {
            bread = topping;
            this.Name = bread.GetDescription() + " with Cheese";
        }

        public override double GetPrice()
        {
            return 0.60 + bread.GetPrice();
        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }


    }

    public class TomatoT : Bread
    {
        public Bread bread;
        public TomatoT(Bread topping)
        {
            bread = topping;
            this.Name = bread.GetDescription() + " with Tomato";
        }

        public override double GetPrice()
        {
            return 0.25 + bread.GetPrice();
        }

        public void Print()
        {
            Console.WriteLine(this.GetDescription() + ": " + this.GetPrice());
        }


    }

}
