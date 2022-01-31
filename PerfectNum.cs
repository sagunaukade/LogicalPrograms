using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNum
    {
        public void PerfectNumber()
        {
            
           int n,i,sum;
           int mn,mx;
  
	         Console.Write("Input the starting range or number : ");
             mn = Convert.ToInt32(Console.ReadLine());  
             Console.Write("Input the ending range of number : ");
             mx = Convert.ToInt32(Console.ReadLine());  
             Console.Write("The Perfect numbers within the given range : ");

               for(n=mn;n<=mx;n++)
               {
                 i=1;
                 sum = 0;
                    while(i<n)
	                {
                       if(n%i==0)
                       sum=sum+i;
                       i++;
                    }
                     if(sum==n)
                     Console.Write("{0} ",n);
               }
                 
        } 
    }
}
