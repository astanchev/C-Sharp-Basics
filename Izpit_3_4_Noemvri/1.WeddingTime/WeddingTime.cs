﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.WeddingTime
{
    class WeddingTime
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double waterQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double champagneQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double champagnePrice = whiskeyPrice * 0.5;
            double winePrice = champagnePrice * 0.4;
            double waterPrice = champagnePrice * 0.1;

            double champagneSum = champagneQuantity * champagnePrice;
            double wineSum = wineQuantity * winePrice;
            double waterSum = waterQuantity * waterPrice;
            double whiskeySum = whiskeyQuantity * whiskeyPrice;

            double totalSum = champagneSum + wineSum + waterSum + whiskeySum;

            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
