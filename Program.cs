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
            Console.WriteLine("1:Flipcoin \n2:Leap Year \n3.\n4.Palindrome\n5.SumOfDigits\n6.ReverseWord\n7.PrimeNumber\n8.Factorial\n9.Swapping Number\n10.OddorEven");
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
                //case 4:
                    
                //    break;
                //case 5:
                    
                //    break;
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
