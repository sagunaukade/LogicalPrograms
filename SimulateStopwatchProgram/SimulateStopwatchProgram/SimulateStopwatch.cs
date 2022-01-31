using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateStopwatchProgram
{
    internal class SimulateStopwatch
    {
        public static System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        private static int ch;

        public static void StartWatch()
        {
            do
            {
                Console.WriteLine("1. Start\n2. Stop \n3. Elapsed \n4. Exit");
                Console.Write("Enter Your Choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        watch.Start();
                        break;
                    case 2:
                        watch.Stop();
                        break;
                    case 3:
                        double elapsedTime = Math.Round((double)watch.ElapsedMilliseconds / 1000, 2);
                        Console.WriteLine("Elapsed Time is : " + elapsedTime + " Seconds");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }

            } while (ch < 3);
        }
    }
}
    
