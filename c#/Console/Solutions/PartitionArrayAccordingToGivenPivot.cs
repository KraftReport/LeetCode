using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
    public static class PartitionArrayAccordingToGivenPivot
    {
        public static int[] Solution(int[] nums,int pivot)
        {
            List<int> smaller = new List<int>();
            List<int> equal = new List<int>();
            List<int> larger = new List<int>();
            int[] result = new int[nums.Length];
            int index = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < pivot) smaller.Add(nums[i]);
                if (nums[i] > pivot) larger.Add(nums[i]);
                if (nums[i] == pivot) equal.Add(nums[i]);
            }

            foreach (int num in smaller) result[index++] = num;
            foreach (int num in equal) result[index++] = num;
            foreach (int num in larger) result[index++] = num;
            return result;
        }
    }
}
