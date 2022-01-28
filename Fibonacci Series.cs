using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Fibonacci_Series
    {
        public void FiboSeries()
        {
            Console.WriteLine("please enter how many fibonocci number");
            int number = Convert.ToInt32(Console.ReadLine());
            int first = 0, second = 1;
            int result = 0;
            result = first + second;
            Console.Write("{0} {1} {2},first, second, result");
            for (int i = 3; i < number; i++)
            {
                first = second;
                second = result;
                result = first + second;
                Console.Write("" + result);
            }
        }
    }
}
        

