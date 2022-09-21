using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_core_Program
{
    internal class QuotientNRemainder
    {
        public static void quotientNreminder()
        {
            Console.WriteLine("ENTER DIVIDENT VALUE :");
            int divident = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER DIVISOR VALUE :");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = divident / divisor;
            int reminder = divident % divisor;

            Console.WriteLine("Quotient :" + quotient);
            Console.WriteLine("Reminder :" + reminder);
            Console.ReadLine();
        }
    }
}
