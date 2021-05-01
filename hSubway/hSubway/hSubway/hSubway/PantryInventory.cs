using System;
using System.Collections.Generic;
using System.Text;

namespace hSubway
{
    public class PantryInventory
    {
        
        // Inventory
        public int whiteBread { get; set; }
        public int wheatBread { get; set; }
        public int ryeBread;
        public int pbj;
        public int chicken;
        public int blt;
        public int Tbacon;
        public double TotalSales;


        public bool inventoryInStock()
        {
            if (whiteBread <= 1 || wheatBread <= 1 || ryeBread <= 1 || pbj == 0 || chicken == 0 || blt == 0 )
            {
                return true;
            }
            else return false;

        }


        public void inventoryRestock()
        {
            whiteBread = 50;
            wheatBread = 50;
            ryeBread = 50;
            pbj = 10;
            chicken = 10;
            blt = 10;
            TotalSales = 0.0;
        } 




    }
}
