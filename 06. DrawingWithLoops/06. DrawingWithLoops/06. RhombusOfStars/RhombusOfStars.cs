﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int spaceCol = 1; spaceCol <= n - row; spaceCol++)
                {
                    Console.Write(" ");
                }
                for (int col = 1; col < row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("*");
            }
            for (int row = n - 1; row >= 1; row--)
            {
                for (int spaceCol = 1; spaceCol <= n - row; spaceCol++)
                {
                    Console.Write(" ");
                }
                for (int col = 1; col < row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("*");
            }
        }
    }
}
