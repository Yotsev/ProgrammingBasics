﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MyFort
{
    class MyFort
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n / 2), new string('_', 2 * n - (2 * (n / 2)) - 4));
            for (int i = 0; i < n-3; i++)
            {
                Console.WriteLine("|{0}|",new string(' ',n*2));
            }
            Console.WriteLine("|{0}{1}{0}|", new string(' ', n / 2), new string('_', 2 * n - (2 * (n / 2)) - 4));
        }
    }
}
