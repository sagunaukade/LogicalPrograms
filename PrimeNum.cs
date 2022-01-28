using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNum
    {
        public void PrimeNumber()
        {
            int i, num, f;
            Console.WriteLine("Enter number ");
            num = Convert.ToInt32(Console.ReadLine());
            f = 0;
            for(i=2;i<=num/2;i++)
            {
                if(num%i==0)
                {
                    f = 1;
                }
            }
            if(f==0)
            {
                Console.WriteLine(num+ "is prime number");
            }
            else
            {
                Console.WriteLine(num + "is not prime number");

            }
            Console.WriteLine();

        }
    }
}
