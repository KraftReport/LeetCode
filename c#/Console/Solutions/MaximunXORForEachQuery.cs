using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class MaximunXORForEachQuery
    {
        public static int[] Solution(int[] nums,int maximumBit)
        { 
            int[] result = new int[nums.Length];  
            
            int xorall = 0;

            foreach(int num in nums) xorall ^= num;

            int mask = Power(2, maximumBit) - 1;

            for(int i = 0; i <nums.Length; i++)
            {
                result[i] = mask ^ xorall;
                xorall ^= nums[nums.Length - 1 - i];
            } 

            return result;
        }

        private static int Power(int baseNumber,int exponent)
        {
            if (exponent == 0) return 1;
            if(exponent % 2 == 0)
            {
                int halfPower = Power(baseNumber, exponent / 2);
                return halfPower * halfPower;
            }
            else
            {
                return baseNumber * Power(baseNumber, exponent - 1);
            }
        }
    }
}
