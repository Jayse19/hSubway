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
            temp.TotalSales += Math.Round(b.GetPrice()*1.03, 2, MidpointRounding.ToEven);
            return temp.TotalSales;
        }


        public bool CurrentStock(string [] test)
        {
            foreach (var item in test)
            {
                    switch (item)
                    {
                        case "white":
                        if (whiteBread <= 1)
                        {
                            Console.WriteLine(item + " is out of stock");
                            return false; 
                        }
                        else 
                        {
                            whiteBread = whiteBread - 2;
                            break;
                        }
                            
                        case "wheat":
                        if (wheatBread <= 1)
                        {
                            Console.WriteLine(item + " is out of stock");
                            return false;
                        }
                        else
                        {
                            wheatBread -= 2;
                            break;
                        }

                        case "rye":
                        if (ryeBread <= 1)
                        {
                            Console.WriteLine(item + " is out of stock");
                            return false;
                        }
                        else
                        {
                            ryeBread -= 2;
                            break;
                        }

                    case "Chicken":
                        if (chicken == 0)
                        {
                            Console.WriteLine(item + " is out of stock");
                            return false;
                        }
                        else
                        {
                            chicken--;
                            break;
                        }

                    case "PBJ":
                        if (pbj == 0)
                        {
                            Console.WriteLine(item + " is out of stock");
                            return false;
                        }
                        else
                        {
                            pbj--;
                            break;
                        }

                    case "BLT":
                        if (blt == 0)
                        {
                            Console.WriteLine(item + " is out of stock");
                            return false;
                        }
                        else
                        {
                            blt--;
                            break;
                        }

                    case "bacon":
                        if (bacon == 0)
                        {
                            Console.WriteLine(item + " is out of stock");
                            return false;
                        }
                        else
                        {
                            bacon--;
                            break;
                        }

                    case "BBQ":
                        if (bbq == 0)
                        {
                            Console.WriteLine(item + " is out of stock");
                            return false;
                        }
                        else
                        {
                            bbq--;
                            break;
                        }

                    case "cheese":
                        if (cheese == 0)
                        {
                            Console.WriteLine(item + " is out of stock");
                            return false;
                        }
                        else
                        {
                            cheese--;
                            break;
                        }

                    case "ham":
                        if (ham == 0)
                        {
                            Console.WriteLine(item + " is out of stock");
                            return false;
                        }
                        else
                        {
                            ham--;
                            break;
                        }

                    case "lettuce":
                        if (lettuce == 0)
                        {
                            Console.WriteLine(item + " is out of stock");
                            return false;
                        }
                        else
                        {
                            lettuce--;
                            break;
                        }

                    case "mayo":
                        if (mayo == 0)
                        {
                            Console.WriteLine(item + " is out of stock");
                            return false;
                        }
                        else
                        {
                            mayo--;
                            break;
                        }

                    case "mustard":
                        if (mustard == 0)
                        {
                            Console.WriteLine(item + " is out of stock");
                            return false;
                        }
                        else
                        {
                            mustard--;
                            break;
                        }

                    case "tomato":
                        if (tomato == 0)
                        {
                            Console.WriteLine(item + " is out of stock");
                            return false;
                        }
                        else
                        {
                            tomato--;
                            break;
                        }

                    default:
                            break;
                    }
            }
            return false;
        } 


    }
}
