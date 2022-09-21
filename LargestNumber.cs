using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_Program
{
    internal class LargestNumber
    {
        public static void largestNumber()
        {
            Console.WriteLine("INPUT THREE NUMBERS AS :");

            int n1 = Convert.ToInt32(Console.ReadLine());

            int n2 = Convert.ToInt32(Console.ReadLine());

            int n3 = Convert.ToInt32(Console.ReadLine());

            //check if A1 is greater than A2 (by nested if)
            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.Write("n1 is the largest");
                }
                else
                {
                    Console.Write("n3 is the largest");
                }
            }
            else if (n2 > n3)
            {

                Console.Write("n2 is the largest");
            }
            else
                Console.Write("n3 is the largest");
        }
    }
}
