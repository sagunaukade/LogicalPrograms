using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNum
    {
        public static void ReverseNumber()
        {
            Console.WriteLine("please enter number to reverse");
            int number = Convert.ToInt32(Console.ReadLine());
            int remainder, reverse = 0;
            while (number > 0)
            {
                
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
        }
    }
}
