﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_Program
{
    internal class OddOrEven
    {
        public static void Oddreven()
        {

            Console.Write("Enter a Number : ");
            int i = Convert.ToInt32(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}
