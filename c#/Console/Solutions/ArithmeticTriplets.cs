using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class ArithmeticTriplets
    {
        public static int Solution(int[] nums,int diff)
        {
            int result = 0; 
            for (int i = nums.Length-1; i > 0; i--)
            {
                int firstPointer = i;
                int secondPointer = firstPointer-1; 
                while(secondPointer > -1)
                {
                    if (nums[firstPointer] - nums[secondPointer] == diff)
                    {
                        int thirdPointer = secondPointer - 1;
                        while (thirdPointer > -1)
                        {
                            if (nums[secondPointer] - nums[thirdPointer] == diff)
                            {
                                result++; 
                            }
                            thirdPointer--;
                        }
                    }
                    secondPointer--;
                } 
            } 
            return result;
        }
    }
}
