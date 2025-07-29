using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class HappyNumber
    {
        public static bool Solution(int n)
        {
            
            int slow = n;
            
            int fast = Sum(n);

            while(fast != 1 && slow != fast)
            {
                
                slow = Sum(slow);
                
                fast = Sum(Sum(fast));
            }

            return fast == 1;
        }

        private static int Sum(int n)
        {
            int sum = 0;
            
            while(n> 0)
            {
                int digit = n % 10;
            
                sum += digit * digit;
                
                n /= 10;
            }
            
            return sum;
        }
    }
}
