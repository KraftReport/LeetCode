using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class CountMaximunNumberOfBitwistORSubsets
    {
        public static int Solution(int[] nums)
        {
            int maxOr = 0;
            foreach (int num in nums)
                maxOr |= num;
             
            int n = nums.Length;
            int count = 0;
             
            for (int mask = 1; mask < (1 << n); mask++)
            {
                int currentOr = 0;
                for (int i = 0; i < n; i++)
                {
                    var data = 1 << i;
                    var wow = mask & data;
                    if ((mask & (1 << i)) != 0)
                    {
                        currentOr |= nums[i];
                    }
                }
                if (currentOr == maxOr) count++;
            }

            return count;
        }
    }
}
