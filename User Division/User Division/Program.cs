﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_01;
            int num_02;

            Console.Write("Please enter your first number: ");
            num_01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            num_02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The numbers " + num_01 + "/" + num_02 + " = " + (num_01 / num_02));
            Console.ReadKey();
        }
    }
}
