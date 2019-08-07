﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GameStatistics
{
    class GameStatistics
    {
        static void Main(string[] args)
        {
            double minutes = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            if (minutes == 0)
            {
                Console.WriteLine("Match has just began!");
            }
            else if (minutes < 45)
            {
                Console.WriteLine("First half time.");
                if (minutes <= 10 && minutes!= 0)
                {
                    Console.WriteLine($"{name} missed a penalty.");
                    if (minutes % 2 == 0)
                    {
                        Console.WriteLine($"{name} was injured after the penalty.");
                    }
                }
                else if (minutes > 10 && minutes <= 35)
                {
                    Console.WriteLine($"{name} received yellow card.");
                    if (minutes % 2 != 0)
                    {
                        Console.WriteLine($"{name} got another yellow card.");
                    }
                }
                else if (minutes > 35 && minutes < 45)
                {
                    Console.WriteLine($"{name} SCORED A GOAL !!!");                    
                }
            }
            else if (minutes >= 45)
            {
                Console.WriteLine("Second half time.");
                if (minutes > 45 && minutes <= 55)
                {
                    Console.WriteLine($"{name} got a freekick.");
                    if (minutes % 2 == 0)
                    {
                        Console.WriteLine($"{name} missed the freekick.");
                    }
                }
                else if (minutes > 55 && minutes <= 80)
                {
                    Console.WriteLine($"{name} missed a shot from corner.");
                    if (minutes % 2 != 0)
                    {
                        Console.WriteLine($"{name} has been changed with another player.");
                    }
                }
                else if (minutes > 80 && minutes <= 90)
                {
                    Console.WriteLine($"{name} SCORED A GOAL FROM PENALTY !!!");
                }
            }


        }
    }
}
