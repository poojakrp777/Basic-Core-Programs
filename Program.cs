using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one program from below options");
            Console.WriteLine("1:Flipcoin \n2:Leap Year \n3.Powerof2\n4.Harmonic Number \n5.Factors\n6.\n7.\n8.\n9.\n10.");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Percentage of Head and Tails as :");
                    FlipCoin.flipcoin();
                    break;
                case 2:
                    Console.WriteLine("To Check given Year is Lear Year or Not : ");
                    LeapYear.leapyear();
                    break;
                case 3:
                    Console.WriteLine("Entered Number to print Power Of two ");
                    Powerof2.powerOf2();
                    break;
                case 4:
                    Console.WriteLine("The Harmonic vaue of entered number is :");
                    Harmonic.harmonic();
                    break;
                case 5:
                    Console.WriteLine("Prime Factors of given number are :");
                    Factors.factors();
                    break;
                //case 6:

                //    break;
                //case 7:
                //    //PrimeNumber.FindPrimes();
                //    break;
                //case 8:
                //    //Factorial.FindFactorial();
                //    break;
                //case 9:
                //    //SwapNumber.SwappingNumber();
                //    break;
                //case 10:
                //    //OddOrEven.Oddreven();
                //    break;

                default:
                    //Console.WriteLine("Please enter number within range");
                    break;
            }
            Console.ReadLine();
        }
    }
}
