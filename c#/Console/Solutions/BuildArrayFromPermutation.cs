﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class BuildArrayFromPermutation
    {
        public static int[] Solution(int[] nums)
        {
            int[] result = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[nums[i]];
            }
            return result;
        }
    }
}
