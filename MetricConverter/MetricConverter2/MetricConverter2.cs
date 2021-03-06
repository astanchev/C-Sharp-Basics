﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter2
{
    class MetricConverter2
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string firstMeasure = Console.ReadLine();
            string secondMeasure = Console.ReadLine();
            var measure = new Dictionary<string, double>()
            {
                { "m", 1},
                { "mm", 1000},
                { "cm", 100},
                { "mi", 0.000621371192},
                { "in", 39.3700787},
                { "km", 0.001},
                { "ft", 3.2808399}, 
                { "yd", 1.0936133},
            };
            double result = number / measure[firstMeasure] * measure[secondMeasure];
            Console.WriteLine("{0} {1}", result, secondMeasure);

        }
    }
}
