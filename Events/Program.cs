﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            //her zaman kullanılmazlar ihtiyac olunca kullanılırlar

            Product harddisk = new Product(50);
            harddisk.ProductName = "Hard Disk";

            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent; //gsm i eventa abone ettik

            for (int i=0; i<10;i++)
            {
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
                


        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Gsm about to finsh!!!");
        }
    }
}
