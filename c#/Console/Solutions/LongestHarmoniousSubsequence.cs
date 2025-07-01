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
            var hashMap = nums
                .GroupBy(num => num)
                .ToDictionary(num => num.Key, num => num.Count());

            var result = 0;

            foreach(var map in hashMap)
            {
                var currentValue = 0;

                if(hashMap.ContainsKey(map.Key + 1))
                {
                    currentValue = hashMap[map.Key] + hashMap[map.Key + 1];
                }

                if(currentValue > result)
                {
                    result = currentValue;
                }
            } 

            return result;
        }
    }
}
