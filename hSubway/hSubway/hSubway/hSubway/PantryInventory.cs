using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class PantryInventory
    {
        
        // Inventory
        int whiteBread = 50;
        int wheatBread = 50;
        int ryeBread = 50;
        int pbj = 10;
        int chicken = 10;
        int blt = 10;
        int extraServings = 4000;



        //Prices

        double whiteBreadCost = 2.00;
        double wheatBreadCost = 2.25;
        double ryeBreadCost = 2.50;
 

        int mayo, mustard, bbq, usedBacon, usedHam;


        double bacon = 0.75;
        double ham = 0.60;
        double cheese = 0.75;
        double lettuce = 0.25;
        double tomato = 0.25;
        double extraPBJ = 0.75;
        double extraBLT = 2.50;
        double extraChicken = 2.00;

        public void inventoryInStock()
        {
            if (whiteBread <= 1 || wheatBread <= 1 || ryeBread <= 1 || pbj == 0 || chicken == 0 || blt == 0 || extraServings == 0)
            {
                Console.WriteLine("Out of stock of that option");
            }

        }


        public void inventoryRestock()
        {
            whiteBread = 50;
            wheatBread = 50;
            ryeBread = 50;
            pbj = 10;
            chicken = 10;
            blt = 10;
            extraServings = 4000;
        } 




    }
}
