using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class FindKDistinctIndices
    {
        public static IList<int> Solution(int[] nums,int key,int k)
        {
            HashSet<int> result = new HashSet<int>();
            int kIndex = 0;
            int i = 0;

            while(kIndex < nums.Length)
            {
                while (nums[kIndex] != key)
                {
                    kIndex++;
                    if (kIndex >= nums.Length) break;
                }
                if (int.Abs(i - kIndex) <= k)
                {
                    result.Add(i);
                } 
                if (i == nums.Length - 1)
                {
                    i = 0;
                    kIndex++;
                }
                else
                {
                    i++;
                }
            } 
            return result.ToList();
        }
    }
}
