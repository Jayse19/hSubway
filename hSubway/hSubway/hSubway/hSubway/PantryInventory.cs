using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class PantryInventory
    {

        // Inventory
        public int wheatBread= 50;
        public int whiteBread=50;
        public int ryeBread=50;
        public int pbj=10;
        public int chicken=10;
        public int blt=10;
        public int bacon=4000;
        public int lettuce=4000;
        public int tomato=4000;
        public int cheese=4000;
        public int bbq=4000;
        public int mustard=4000;
        public int mayo=4000;
        public int ham=4000;
        public double TotalSales=0.0;


        public bool InventoryNotInStock()
        {
            if (whiteBread <= 1 || wheatBread <= 1 || ryeBread <= 1 || pbj == 0 || chicken == 0 || blt == 0 || bacon == 0 || lettuce == 0 || tomato == 0 || cheese == 0|| bbq == 0 || mustard == 0 || mayo == 0 || ham == 0)
            {
                return true;
            }
            else 
                return false;

        }


        public void InventoryRestock()
        {
            whiteBread = 50;
            wheatBread = 50;
            ryeBread = 50;
            pbj = 10;
            chicken = 10;
            blt = 10;
            bacon = lettuce = tomato = cheese = bbq = mustard = ham = mayo = 4000;
            TotalSales = 0.0;
        } 

        public PantryInventory ShallowCopy()
        {
            return (PantryInventory)this.MemberwiseClone();
        }

        public double SellSandwich(Bread b)
        { 
            PantryInventory temp = this.ShallowCopy();
            temp.TotalSales += Math.Round(b.GetPrice() * 1.03, 2, MidpointRounding.ToEven);
            return temp.TotalSales;
        }

        public void CurrentStock(string [] test)
        {
            foreach (var item in test)
            {
                if (InventoryNotInStock())
                {
                    return;
                }
                else
                {
                    switch (item)
                    {
                        case "white":
                            whiteBread = whiteBread - 2;
                            Console.WriteLine("white: " + whiteBread);
                            break;
                        case "wheat":
                            wheatBread = wheatBread - 2;
                            Console.WriteLine("wheat: " + wheatBread);
                            break;

                        case "rye":
                            ryeBread = ryeBread - 2;
                            Console.WriteLine("rye: " + ryeBread);
                            break;

                        case "Chicken":
                            chicken--;
                            Console.WriteLine("chicken: " + chicken);
                            break;

                        case "PBJ":
                            pbj--;
                            Console.WriteLine("PBJ: " + pbj);
                            break;

                        case "BLT":
                            blt--;
                            Console.WriteLine("BLT: " + blt);
                            break;

                        case "bacon":
                            bacon--;
                            Console.WriteLine("bacon: " + bacon);
                            break;

                        case "BBQ":
                            bbq--;
                            Console.WriteLine("BBQ: " + bbq);
                            break;

                        case "cheese":
                            cheese--;
                            Console.WriteLine("cheese: " + cheese);
                            break;

                        case "ham":
                            ham--;
                            Console.WriteLine("ham: " + ham);
                            break;

                        case "lettuce":
                            lettuce--;
                            Console.WriteLine("lettuce: " + lettuce);
                            break;

                        case "mayo":
                            mayo--;
                            Console.WriteLine("mayo: " + mayo);
                            break;

                        case "mustard":
                            mustard--;
                            Console.WriteLine("mustard: " + mustard);
                            break;

                        case "tomato":
                            tomato--;
                            Console.WriteLine("tomato: " + tomato);
                            break;

                        default:
                            break;
                    }
                }
            }
        }


    }
}
