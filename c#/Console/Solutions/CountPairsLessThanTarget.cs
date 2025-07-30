using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class CountPairsLessThanTarget
    {
        public static int Solution(List<int> nums,int target)
        {
            int result = 0;

            for(int i = 0; i <nums.Count; i++)
            {
                int left = i;
                int right = nums.Count - 1;

                while(left != right)
                {
                    if(nums[left]+nums[right]<target) result++; 
                    right--;
                }
            }

            return result;
        }
    }
}
