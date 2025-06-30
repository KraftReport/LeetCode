using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public class LongestHarmoniousSubsequence
    {
        public static int Solution(int[] nums)
        {
            var longestValue = 0; 

            for (var i = 0; i < nums.Length-1; i++)
            {
                if (nums[i+1] - nums[i] < 2)
                {
                    longestValue++;
                } 
            }

            return longestValue;
        }
    }
}
