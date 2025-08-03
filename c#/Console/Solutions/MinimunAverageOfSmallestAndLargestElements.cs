using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class MinimunAverageOfSmallestAndLargestElements
    {
        public static double Solution(int[] nums)
        {
            int i = 0;
            double average = double.MaxValue;
            int min = 0;
            int max = nums.Length - 1;

            while (i < nums.Length - 1)
            {
                if (nums[i] > nums[i + 1])
                {
                    int temp = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = temp;
                    i = 0;
                }
                else
                {
                    i++;
                }
            } 
            
            while (min <= max)
            {
                double currentAverage = (nums[min] + nums[max]) / 2.0;
                if (currentAverage < average) average = currentAverage;
                min++;
                max--;
            } 
            return average; 
        }
    }
}
