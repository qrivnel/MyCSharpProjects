﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product hardDisk = new Product(50);
            hardDisk.ProductName = "Hard Disk";
            hardDisk.stockControlEvent += HardDisk_stockControlEvent;

            Product gsm = new Product(50);

            for(int i = 0; i < 10; i++)
            {
                hardDisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
        }

        private static void HardDisk_stockControlEvent()
        {
            Console.WriteLine("Refresh Hard Disk Stock!!");
        }
    }
}
