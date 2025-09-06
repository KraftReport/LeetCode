using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class MinimunNumberOfOperationsToMakeArrayXOREqualToK
    {
        public static int Solution(int[] nums, int k)
        {
            int count = 0;
            int xor = 0;
            foreach (int num in nums) xor ^= num;
            int diff = xor ^ k;
            while(diff > 0)
            {
                count += (diff & 1);
                diff >>= 1;
            }
            return count;
        }
    }
}
