﻿/*Write a program to print Fibonacci series.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class L2P5
    {
        public static void Main()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
